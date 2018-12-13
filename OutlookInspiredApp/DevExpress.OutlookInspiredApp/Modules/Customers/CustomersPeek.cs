namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Utils.MVVM;

    public partial class CustomersPeek : BaseModuleControl {
        CustomerPeekListPresenter presenterCore;
        IPropertyBinding entitiesBinding;
        public CustomersPeek()
            : base(typeof(CustomerCollectionViewModel)) {
            InitializeComponent();
            entitiesBinding = mvvmContext.SetBinding(gridControl, g => g.DataSource, "Entities");
            presenterCore = CreatePresenter();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            entitiesBinding.Dispose();
            base.OnDisposing();
        }
        public CustomerCollectionViewModel ViewModel {
            get { return GetViewModel<CustomerCollectionViewModel>(); }
        }
        public CustomerPeekListPresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual CustomerPeekListPresenter CreatePresenter() {
            return new CustomerPeekListPresenter(gridView, ViewModel);
        }
    }
}