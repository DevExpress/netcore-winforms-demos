namespace DevExpress.DevAV.Presenters {
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraGrid.Views.WinExplorer;

    public class EmployeesGroupFilterPresenter : GroupFilterPresenter<Employee, long, IDevAVDbUnitOfWork> {
        public EmployeesGroupFilterPresenter(WinExplorerView winExplorerView, GroupFilterViewModel viewModel)
            : base(winExplorerView, viewModel) {
        }
        protected override long GetEntityKey(Employee entity) {
            return entity.Id;
        }
    }
    public class CustomersGroupFilterPresenter : GroupFilterPresenter<Customer, long, IDevAVDbUnitOfWork> {
        public CustomersGroupFilterPresenter(WinExplorerView winExplorerView, GroupFilterViewModel viewModel)
            : base(winExplorerView, viewModel) {
        }
        protected override long GetEntityKey(Customer entity) {
            return entity.Id;
        }
    }
    public class ProductsGroupFilterPresenter : GroupFilterPresenter<Product, long, IDevAVDbUnitOfWork> {
        public ProductsGroupFilterPresenter(WinExplorerView winExplorerView, GroupFilterViewModel viewModel)
            : base(winExplorerView, viewModel) {
        }
        protected override long GetEntityKey(Product entity) {
            return entity.Id;
        }
    }
}