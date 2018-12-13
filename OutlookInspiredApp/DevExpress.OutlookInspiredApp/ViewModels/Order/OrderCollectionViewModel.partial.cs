namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    partial class OrderCollectionViewModel : ISupportMap, ISupportCustomFilters {
        public override void Refresh() {
            base.Refresh();
            RaiseReload();
        }
        protected override void OnSelectedEntityChanged() {
            base.OnSelectedEntityChanged();
            this.RaiseCanExecuteChanged(x => x.ShowMap());
            this.RaiseCanExecuteChanged(x => x.PrintInvoice());
            this.RaiseCanExecuteChanged(x => x.QuickReport(SalesReportType.Invoice));
            this.RaiseCanExecuteChanged(x => x.QuickReportFormat(ReportFormat.Doc));
        }
        public event EventHandler Reload;
        public event EventHandler CustomFilter;
        public event EventHandler CustomFiltersReset;
        [Command]
        public void ShowMap() {
            ShowMapCore(SelectedEntity);
        }
        public bool CanShowMap() {
            return CanShowMapCore(SelectedEntity);
        }
        protected internal void ShowMapCore(Order order) {
            ShowDocument<OrderMapViewModel>("MapView", order.Id);
        }
        protected internal bool CanShowMapCore(Order order) {
            return order != null;
        }
        [Command]
        public void ShowViewSettings() {
            var dms = this.GetService<IDocumentManagerService>("View Settings");
            if(dms != null) {
                var document = dms.Documents.FirstOrDefault(d => d.Content is ViewSettingsViewModel);
                if(document == null)
                    document = dms.CreateDocument("View Settings", null, null, this);
                document.Show();
            }
        }
        [Command]
        public void NewCustomFilter() {
            RaiseCustomFilter();
        }
        [Command]
        public void PrintSalesReport() {
            RaisePrint(SalesReportType.SalesReport);
        }
        [Command]
        public void PrintSalesByStore() {
            RaisePrint(SalesReportType.SalesByStore);
        }
        [Command(UseCommandManager = false, CanExecuteMethodName = "CanPrint")]
        public void PrintInvoice() {
            RaisePrint(SalesReportType.Invoice);
        }
        public bool CanPrint() {
            return SelectedEntity != null;
        }
        [Command]
        public void QuickReport(SalesReportType reportType) {
            QuickReportCore(SelectedEntity, reportType);
        }
        public bool CanQuickReport(SalesReportType reportType) {
            return CanQuickReportCore(SelectedEntity, reportType);
        }
        protected internal void QuickReportCore(Order order, SalesReportType reportTemplate) {
            ShowDocument<OrderMailMergeViewModel>("MailMerge", reportTemplate);
        }
        protected internal bool CanQuickReportCore(Order order, SalesReportType reportTemplate) {
            return order != null;
        }
        public override void New() {
            GetDocumentManagerService().ShowNewEntityDocument<Order>(this, newOrder => InitializeNewOrder(newOrder));
        }
        void InitializeNewOrder(Order order) {
            var unitOfWork = CreateUnitOfWork();
            order.InvoiceNumber = GetNewInvoiceNumber(unitOfWork);
            order.OrderDate = DateTime.Now;
            Customer customer = unitOfWork.Customers.FirstOrDefault();
            if(customer != null) {
                order.CustomerId = customer.Id;
                var store = customer.CustomerStores.FirstOrDefault();
                if(store != null)
                    order.StoreId = store.Id;
                var employee = customer.Employees.FirstOrDefault();
                if(employee != null)
                    order.EmployeeId = employee.Id;
            }
        }
        string GetNewInvoiceNumber(IDevAVDbUnitOfWork unitOfWork) {
            var numberStrings = unitOfWork.Orders.Select(x => x.InvoiceNumber).ToList();
            var invoiceNumbers = numberStrings.ConvertAll(x =>
            {
                int number;
                return int.TryParse(x, out number) ? number : 0;
            });
            return (invoiceNumbers.Max() + 1).ToString();
        }
        [Command]
        public void QuickReportFormat(ReportFormat reportFormatType) {
            QuickReportFormatCore(reportFormatType);
        }
        public bool CanQuickReportFormat(ReportFormat reportFormatType) {
            return CanQuickReportFormatCore(SelectedEntity, reportFormatType);
        }
        protected internal void QuickReportFormatCore(ReportFormat reportFormatTemplate) {
            switch(reportFormatTemplate) {
                case ReportFormat.Pdf:
                    ShowDocument<OrderQuickReportsViewModel>("OrderPdfQuickReportView", new object[] { reportFormatTemplate, SelectedEntity });
                    break;
                case ReportFormat.Xls:
                    ShowDocument<OrderQuickReportsViewModel>("OrderXlsQuickReportView", new object[] { reportFormatTemplate, SelectedEntity });
                    break;
                case ReportFormat.Doc:
                    ShowDocument<OrderQuickReportsViewModel>("OrderDocQuickReportView", new object[] { reportFormatTemplate, SelectedEntity });
                    break;
            }
        }
        protected internal bool CanQuickReportFormatCore(Order order, ReportFormat reportFormatTemplate) {
            return order != null;
        }
        IDevAVDbUnitOfWork orderItemsUnitOfWork;
        protected override void OnBeforeEntityDeleted(long primaryKey, Order entity) {
            base.OnBeforeEntityDeleted(primaryKey, entity);
            if(!entity.OrderItems.Any())
                return;
            var deletedItemKeys = entity.OrderItems.Select(x => x.Id).ToList();
            orderItemsUnitOfWork = CreateUnitOfWork();
            deletedItemKeys.ForEach(x =>
            {
                var item = orderItemsUnitOfWork.OrderItems.Find(x);
                if(item != null)
                    orderItemsUnitOfWork.OrderItems.Remove(item);
            });
        }
        protected override void OnEntityDeleted(long primaryKey, Order entity) {
            base.OnEntityDeleted(primaryKey, entity);
            if(orderItemsUnitOfWork != null)
                orderItemsUnitOfWork.SaveChanges();
            orderItemsUnitOfWork = null;
        }
        [Command]
        public void ShowAllFolders() {
            RaiseShowAllFolders();
        }
        [Command]
        public void ResetCustomFilters() {
            RaiseCustomFiltersReset();
        }
        void RaisePrint(SalesReportType reportType) {
            MainViewModel mainViewModel = ViewModelHelper.GetParentViewModel<MainViewModel>(this);
            if(mainViewModel != null)
                mainViewModel.RaisePrint(reportType);
        }
        void RaiseShowAllFolders() {
            MainViewModel mainViewModel = ViewModelHelper.GetParentViewModel<MainViewModel>(this);
            if(mainViewModel != null)
                mainViewModel.RaiseShowAllFolders();
        }
        void RaiseReload() {
            EventHandler handler = Reload;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomFilter() {
            EventHandler handler = CustomFilter;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomFiltersReset() {
            EventHandler handler = CustomFiltersReset;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void ShowDocument<TViewModel>(string documentType, object parameter) {
            var document = FindDocument<TViewModel>();
            if(parameter is long)
                document = FindDocument<TViewModel>((long)parameter);
            if(document == null)
                document = DocumentManagerService.CreateDocument(documentType, null, parameter, this);
            else
                ViewModelHelper.EnsureViewModel(document.Content, this, parameter);
            document.Show();
        }
        public override IQueryable<Order> GetEntities(Expression<Func<Order, bool>> filter = null) {
            return base.GetEntities(filter).ActualOrders();
        }
        internal IEnumerable<SaleAnalisysInfo> GetSaleAnalisysInfos() {
            return QueriesHelper.GetSaleAnalysis(CreateUnitOfWork().OrderItems);
        }
        internal IEnumerable<SaleSummaryInfo> GetSaleSummaryInfos() {
            return QueriesHelper.GetSaleSummaries(CreateUnitOfWork().OrderItems);
        }
        internal IEnumerable<OrderItem> GetOrderItems() {
            return CreateUnitOfWork().OrderItems.Include(x => x.Order).ToList();
        }
        internal IEnumerable<OrderItem> GetOrderItems(long? storeId) {
            return CreateUnitOfWork().OrderItems.Include(x => x.Order).Where(x => Nullable.Equals(x.Order.StoreId, storeId)).ToList();
        }
        public void ShowRevenueReport() {
            ShowDocument<OrderRevenueViewModel>("OrderRevenueView", new object[] { 
                QueriesHelper.GetRevenueReportItems(CreateUnitOfWork().OrderItems), RevenueReportFormat.Summary});
        }
        public virtual void ShowRevenueAnalysisReport() {
            ShowDocument<OrderRevenueViewModel>("OrderRevenueView", new object[] { 
                QueriesHelper.GetRevenueAnalysisReportItems(CreateUnitOfWork().OrderItems, SelectedEntity.StoreId.Value), RevenueReportFormat.Analysis });
        }
    }
}