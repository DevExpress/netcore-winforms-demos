namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraGrid.Views.WinExplorer;

    public partial class CustomerView : BaseModuleControl {
        public CustomerView()
            : base(typeof(SynchronizedCustomerViewModel)) {
            InitializeComponent();
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            ItemForHomeOffice.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor;
            ItemForHomeOffice.AppearanceItemCaption.Options.UseForeColor = true;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        public CustomerViewModel ViewModel {
            get { return GetViewModel<CustomerViewModel>(); }
        }
        public bool IsHorizontalLayout {
            get { return winExplorerView.OptionsView.Style == WinExplorerViewStyle.Large; }
            set {
                winExplorerView.OptionsView.Style = value ?
                    WinExplorerViewStyle.Large : WinExplorerViewStyle.Medium;
            }
        }
        void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            UpdateUI(ViewModel.Entity);
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UpdateUI(ViewModel.Entity);
        }
        void UpdateUI(Customer customer) {
            if(customer != null) {
                if(!object.Equals(bindingSource.DataSource, customer))
                    bindingSource.DataSource = customer;
                else
                    bindingSource.ResetBindings(false);
                gridControl.DataSource = customer.CustomerStores;
            }
            moduleLayout.Visible = (customer != null);
        }
    }
}