namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using DevExpress.DevAV;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    partial class QuoteCollectionViewModel : ISupportMap, ISupportCustomFilters {
        public override void Refresh() {
            base.Refresh();
            RaiseReload();
        }
        public event EventHandler Reload;
        public event EventHandler CustomFilter;
        public event EventHandler CustomFiltersReset;
        [Command]
        public void ShowMap() {
            ShowDocument<QuoteMapViewModel>("MapView", null);
        }
        public bool CanShowMap() {
            return true;
        }
        [Command]
        public void ShowViewSettings() {
            var dms = this.GetService<DevExpress.Mvvm.IDocumentManagerService>("View Settings");
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
        public void ShowAllFolders() {
            RaiseShowAllFolders();
        }
        [Command]
        public void ResetCustomFilters() {
            RaiseCustomFiltersReset();
        }
        void RaiseShowAllFolders() {
            MainViewModel mainViewModel = ViewModelHelper.GetParentViewModel<MainViewModel>(this);
            if(mainViewModel != null)
                mainViewModel.RaiseShowAllFolders();
        }
        void RaisePrint(SalesReportType reportType) {
            MainViewModel mainViewModel = ViewModelHelper.GetParentViewModel<MainViewModel>(this);
            if(mainViewModel != null)
                mainViewModel.RaisePrint(reportType);
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
        protected virtual IQueryable<Quote> GetQuotes() {
            return CreateRepository().GetFilteredEntities(FilterExpression);
        }
        public IList<QuoteMapItem> GetOpportunities() {
            return QueriesHelper.GetOpportunities(GetQuotes()).ToList();
        }
        public IList<QuoteMapItem> GetOpportunities(Stage stage, Expression<Func<Quote, bool>> filterExpression = null) {
            var unitOfWork = CreateUnitOfWork();
            var quotes = unitOfWork.Quotes.GetFilteredEntities(filterExpression ?? FilterExpression);
            var customers = unitOfWork.Customers;
            return QueriesHelper.GetOpportunities(quotes, customers, stage).ToList();
        }
        public IEnumerable<Address> GetAddresses(Stage stage) {
            var unitOfWork = CreateUnitOfWork();
            return QueriesHelper.GetCustomerStore(unitOfWork.CustomerStores, unitOfWork.Quotes.GetFilteredEntities(FilterExpression).ActualQuotes(), stage).Distinct().Select(cs => cs.Address);
        }
        public decimal GetOpportunity(Stage stage, string city) {
            return QueriesHelper.GetOpportunity(GetQuotes(), stage, city);
        }
        public override void Delete(Quote entity) {
            MessageBoxService.ShowMessage("To ensure data integrity, the Opportunities module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Opportunity", MessageButton.OK);
        }
        public override IQueryable<Quote> GetEntities(Expression<Func<Quote, bool>> filter = null) {
            return base.GetEntities(filter).ActualQuotes();
        }
    }
}