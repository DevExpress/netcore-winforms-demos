namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;

    public partial class OrdersCustomFilter : BaseModuleControl {
        public OrdersCustomFilter(CustomFilterViewModel customFilterViewModel)
            : base(typeof(CustomFilterViewModel), customFilterViewModel) {
            InitializeComponent();
            ViewModel.QueryFilterCriteria += ViewModel_QueryFilterCriteria;
            bindingSource.DataSource = customFilterViewModel;
            BuildFilterColumns();
            BindEditors();
            BindCommands();
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.QueryFilterCriteria -= ViewModel_QueryFilterCriteria;
        }
        protected override void OnLoad(System.EventArgs ea) {
            base.OnLoad(ea);
            filterControl.FilterCriteria = ViewModel.FilterCriteria;
        }
        void ViewModel_QueryFilterCriteria(object sender, QueryFilterCriteriaEventArgs e) {
            e.FilterCriteria = filterControl.FilterCriteria;
        }
        public CustomFilterViewModel ViewModel {
            get { return GetViewModel<CustomFilterViewModel>(); }
        }
        public OrderCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<OrderCollectionViewModel>(); }
        }
        void BuildFilterColumns() {
            var builder = new FilterColumnCollectionBuilder<Order>(filterControl.FilterColumns);
            builder
                .AddColumn(e => e.Customer.Name, caption: "Customer")
                .AddColumn(e => e.Employee.FullName, caption: "Employee")
                .AddColumn(e => e.InvoiceNumber)
                .AddDateTimeColumn(e => e.OrderDate)
                .AddColumn(e => e.PONumber)
                .AddColumn(e => e.SaleAmount)
                .AddDateTimeColumn(e => e.ShipDate)
                .AddLookupColumn(e => e.ShipMethod)
                .AddColumn(e => e.ShippingAmount)
                .AddColumn(e => e.Store.Crest.CityName, caption: "Store")
                .AddColumn(e => e.TotalAmount);
        }
        void BindEditors() {
            var errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider();
            errorProvider.ContainerControl = this;
            errorProvider.DataSource = bindingSource;
        }
        void BindCommands() {
            this.okBtn.BindCommand(() => ViewModel.OK(), ViewModel);
            this.cancelBtn.BindCommand(() => ViewModel.Cancel(), ViewModel);
        }
    }
}