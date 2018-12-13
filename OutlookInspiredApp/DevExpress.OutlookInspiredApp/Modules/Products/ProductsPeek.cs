namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Utils.MVVM;

    public partial class ProductsPeek : BaseModuleControl {
        ProductPeekListPresenter presenterCore;
        IPropertyBinding entitiesBinding;
        public ProductsPeek()
            : base(typeof(ProductCollectionViewModel)) {
            InitializeComponent();
            entitiesBinding = mvvmContext.SetBinding(gridControl, g => g.DataSource, "Entities");
            presenterCore = CreatePresenter();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            entitiesBinding.Dispose();
            base.OnDisposing();
        }
        public ProductCollectionViewModel ViewModel {
            get { return GetViewModel<ProductCollectionViewModel>(); }
        }
        public ProductPeekListPresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual ProductPeekListPresenter CreatePresenter() {
            return new ProductPeekListPresenter(gridView, ViewModel);
        }
    }
}