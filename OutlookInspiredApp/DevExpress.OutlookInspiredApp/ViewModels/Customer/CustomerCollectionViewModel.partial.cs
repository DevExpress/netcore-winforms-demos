namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    partial class CustomerCollectionViewModel : ISupportMap, ISupportAnalysis, ISupportCustomFilters {
        public override void Refresh() {
            base.Refresh();
            RaiseReload();
        }
        protected override void OnSelectedEntityChanged() {
            base.OnSelectedEntityChanged();
            this.RaiseCanExecuteChanged(x => x.ShowMap());
            this.RaiseCanExecuteChanged(x => x.PrintProfile());
            this.RaiseCanExecuteChanged(x => x.PrintSalesDetail());
            this.RaiseCanExecuteChanged(x => x.PrintSalesSummary());
            this.RaiseCanExecuteChanged(x => x.PrintProfile());
            this.RaiseCanExecuteChanged(x => x.QuickReport(CustomerReportType.Profile));
        }
        public virtual IEnumerable<Customer> Selection { get; set; }
        protected virtual void OnSelectionChanged() {
            this.RaiseCanExecuteChanged(x => x.GroupSelection());
        }
        public event EventHandler Reload;
        public event EventHandler CustomFilter;
        public event EventHandler CustomFiltersReset;
        public event EventHandler CustomGroup;
        public event EventHandler<GroupEventArgs<Customer>> CustomGroupFromSelection;
        [Command]
        public void ShowAnalysis() {
            ShowDocument<CustomerAnalysisViewModel>("Analysis", null);
        }
        [Command]
        public void ShowMap() {
            ShowMapCore(SelectedEntity);
        }
        public bool CanShowMap() {
            return CanShowMapCore(SelectedEntity);
        }
        protected internal void ShowMapCore(Customer customer) {
            ShowDocument<CustomerMapViewModel>("MapView", customer.Id);
        }
        protected internal bool CanShowMapCore(Customer customer) {
            return customer != null;
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
        public void NewGroup() {
            RaiseCustomGroup();
        }
        [Command]
        public void GroupSelection() {
            RaiseCustomGroupFromSelection();
        }
        public bool CanGroupSelection() {
            return (Selection != null) && Selection.Any();
        }
        [Command]
        public void NewCustomFilter() {
            RaiseCustomFilter();
        }
        [Command(UseCommandManager = false, CanExecuteMethodName = "CanPrint")]
        public void PrintProfile() {
            RaisePrint(CustomerReportType.Profile);
        }
        [Command]
        public void PrintContactDirectory() {
            RaisePrint(CustomerReportType.ContactDirectory);
        }
        [Command(UseCommandManager = false, CanExecuteMethodName = "CanPrint")]
        public void PrintSalesSummary() {
            RaisePrint(CustomerReportType.SalesSummary);
        }
        [Command(UseCommandManager = false, CanExecuteMethodName = "CanPrint")]
        public void PrintSalesDetail() {
            RaisePrint(CustomerReportType.SalesDetail);
        }
        [Command]
        public void QuickReport(CustomerReportType reportType) {
            RaisePrint(reportType);
        }
        public bool CanQuickReport(CustomerReportType reportType) {
            return SelectedEntity != null;
        }
        public bool CanPrint() {
            return SelectedEntity != null;
        }
        [Command]
        public void ShowAllFolders() {
            RaiseShowAllFolders();
        }
        [Command]
        public void ResetCustomFilters() {
            RaiseCustomFiltersReset();
        }
        void RaisePrint(CustomerReportType reportType) {
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
        void RaiseCustomGroup() {
            EventHandler handler = CustomGroup;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseCustomGroupFromSelection() {
            EventHandler<GroupEventArgs<Customer>> handler = CustomGroupFromSelection;
            if(handler != null)
                handler(this, new GroupEventArgs<Customer>(Selection));
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
        public override void Delete(Customer entity) {
            MessageBoxService.ShowMessage("To ensure data integrity, the Customers module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Customer", MessageButton.OK);
        }
        internal IQueryable<OrderItem> GetOrderItems() {
            return CreateUnitOfWork().OrderItems;
        }
    }
}