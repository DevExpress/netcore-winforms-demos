namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;

    public partial class ProductsCustomFilter : BaseModuleControl {
        public ProductsCustomFilter(CustomFilterViewModel customFilterViewModel)
            : base(typeof(CustomFilterViewModel), customFilterViewModel) {
            InitializeComponent();
            ViewModel.QueryFilterCriteria += ViewModel_QueryFilterCriteria;
            bindingSource.DataSource = customFilterViewModel;
            BuildFilterColumns();
            BindEditors();
            BindCommands();
            FilterControlWithoutLike.Apply(filterControl);
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
        public ProductCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<ProductCollectionViewModel>(); }
        }
        void BuildFilterColumns() {
            var builder = new FilterColumnCollectionBuilder<Product>(filterControl.FilterColumns);
            builder
                .AddColumn(e => e.Name)
                .AddColumn(e => e.Available)
                .AddColumn(e => e.Cost)
                .AddColumn(e => e.CurrentInventory)
                .AddColumn(e => e.RetailPrice)
                .AddColumn(e => e.SalePrice)
                .AddDateTimeColumn(e => e.ProductionStart)
                .AddLookupColumn(e => e.Category);
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