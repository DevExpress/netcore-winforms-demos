namespace DevExpress.DevAV.Presenters {
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraBars.Navigation;

    public class EmployeeFilterPanePresenter : FilterPanePresenter<DevAV.Employee, long, IDevAVDbUnitOfWork> {
        public EmployeeFilterPanePresenter(OfficeNavigationBar navigationBar, EmployeesFilterTreeViewModel viewModel)
            : base(navigationBar, viewModel) {
        }
        public new EmployeeCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as EmployeeCollectionViewModel; }
        }
        protected override void BindAllFoldersItem(NavigationBarItem allFoldersItem) {
            allFoldersItem.BindCommand(() => CollectionViewModel.ShowAllFolders(), CollectionViewModel);
        }
    }
    public class CustomerFilterPanePresenter : FilterPanePresenter<DevAV.Customer, long, IDevAVDbUnitOfWork> {
        public CustomerFilterPanePresenter(OfficeNavigationBar navigationBar, CustomersFilterTreeViewModel viewModel)
            : base(navigationBar, viewModel) {
        }
        public new CustomerCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as CustomerCollectionViewModel; }
        }
        protected override void BindAllFoldersItem(NavigationBarItem allFoldersItem) {
            allFoldersItem.BindCommand(() => CollectionViewModel.ShowAllFolders(), CollectionViewModel);
        }
    }
    public class ProductFilterPanePresenter : FilterPanePresenter<DevAV.Product, long, IDevAVDbUnitOfWork> {
        public ProductFilterPanePresenter(OfficeNavigationBar navigationBar, ProductsFilterTreeViewModel viewModel)
            : base(navigationBar, viewModel) {
        }
        public new ProductCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as ProductCollectionViewModel; }
        }
        protected override void BindAllFoldersItem(NavigationBarItem allFoldersItem) {
            allFoldersItem.BindCommand(() => CollectionViewModel.ShowAllFolders(), CollectionViewModel);
        }
    }
    public class OrderFilterPanePresenter : FilterPanePresenter<DevAV.Order, long, IDevAVDbUnitOfWork> {
        public OrderFilterPanePresenter(OfficeNavigationBar navigationBar, OrdersFilterTreeViewModel viewModel)
            : base(navigationBar, viewModel) {
        }
        public new OrderCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as OrderCollectionViewModel; }
        }
        protected override void BindAllFoldersItem(NavigationBarItem allFoldersItem) {
            allFoldersItem.BindCommand(() => CollectionViewModel.ShowAllFolders(), CollectionViewModel);
        }
    }
    public class QuoteFilterPanePresenter : FilterPanePresenter<DevAV.Quote, long, IDevAVDbUnitOfWork> {
        public QuoteFilterPanePresenter(OfficeNavigationBar navigationBar, QuotesFilterTreeViewModel viewModel)
            : base(navigationBar, viewModel) {
        }
        public new QuoteCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as QuoteCollectionViewModel; }
        }
        protected override void BindAllFoldersItem(NavigationBarItem allFoldersItem) {
            allFoldersItem.BindCommand(() => CollectionViewModel.ShowAllFolders(), CollectionViewModel);
        }
    }
}