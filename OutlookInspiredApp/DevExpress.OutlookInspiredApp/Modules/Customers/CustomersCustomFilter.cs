namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;

    public partial class CustomersCustomFilter : BaseModuleControl {
        public CustomersCustomFilter(CustomFilterViewModel customFilterViewModel)
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
        public CustomerCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<CustomerCollectionViewModel>(); }
        }
        void BuildFilterColumns() {
            var builder = new FilterColumnCollectionBuilder<Customer>(filterControl.FilterColumns);
            builder
                .AddColumn(c => c.Name)
                .AddColumn(c => c.HomeOffice.Line)
                .AddColumn(c => c.Phone)
                .AddColumn(c => c.Fax)
                .AddColumn(c => c.Website)
                .AddColumn(c => c.TotalEmployees)
                .AddColumn(c => c.TotalStores)
                .AddLookupColumn(c => c.Status)
                .AddLookupColumn(c => c.HomeOffice.State);
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