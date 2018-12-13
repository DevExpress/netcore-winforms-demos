namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;

    public partial class EmployeesCustomFilter : BaseModuleControl {
        public EmployeesCustomFilter(CustomFilterViewModel customFilterViewModel)
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
        void BuildFilterColumns() {
            var builder = new FilterColumnCollectionBuilder<Employee>(filterControl.FilterColumns);
            builder
                .AddColumn(e => e.FirstName)
                .AddColumn(e => e.LastName)
                .AddColumn(e => e.FullName)
                .AddColumn(e => e.MobilePhone)
                .AddColumn(e => e.HomePhone)
                .AddColumn(e => e.Address.City)
                .AddColumn(e => e.Address.Line)
                .AddColumn(e => e.Address.ZipCode)
                .AddColumn(e => e.Email)
                .AddColumn(e => e.Skype)
                .AddDateTimeColumn(e => e.BirthDate)
                .AddDateTimeColumn(e => e.HireDate)
                .AddLookupColumn(e => e.Department)
                .AddLookupColumn(e => e.Status)
                .AddLookupColumn(e => e.Address.State)
                .AddLookupColumn(e => e.Prefix);
        }
        void BindEditors() {
            var errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(components);
            errorProvider.ContainerControl = this;
            errorProvider.DataSource = bindingSource;
        }
        void BindCommands() {
            var fluent = mvvmContext.OfType<CustomFilterViewModel>();
            fluent.BindCommand(okBtn, x => x.OK());
            fluent.BindCommand(cancelBtn, x => x.Cancel());
        }
    }
}