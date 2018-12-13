namespace DevExpress.DevAV.Presenters {
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraGrid.Views.Grid;

    public class EmployeePeekListPresenter : PeekListPresenter<DevAV.Employee, long, IDevAVDbUnitOfWork> {
        public EmployeePeekListPresenter(GridView gridView, EmployeeCollectionViewModel viewModel)
            : base(gridView, viewModel) {
        }
        protected override ModuleType GetMainModuleType() {
            return ModuleType.Employees;
        }
    }
    public class CustomerPeekListPresenter : PeekListPresenter<DevAV.Customer, long, IDevAVDbUnitOfWork> {
        public CustomerPeekListPresenter(GridView gridView, CustomerCollectionViewModel viewModel)
            : base(gridView, viewModel) {
        }
        protected override ModuleType GetMainModuleType() {
            return ModuleType.Customers;
        }
    }
    public class ProductPeekListPresenter : PeekListPresenter<DevAV.Product, long, IDevAVDbUnitOfWork> {
        public ProductPeekListPresenter(GridView gridView, ProductCollectionViewModel viewModel)
            : base(gridView, viewModel) {
        }
        protected override ModuleType GetMainModuleType() {
            return ModuleType.Products;
        }
    }
}