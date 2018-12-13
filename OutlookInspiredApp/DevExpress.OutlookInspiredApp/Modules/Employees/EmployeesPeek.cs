namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.Presenters;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Utils.MVVM;

    public partial class EmployeesPeek : BaseModuleControl {
        EmployeePeekListPresenter presenterCore;
        IPropertyBinding entitiesBinding;
        public EmployeesPeek()
            : base(typeof(EmployeeCollectionViewModel)) {
            InitializeComponent();
            entitiesBinding = mvvmContext.SetBinding(gridControl, g => g.DataSource, "Entities");
            presenterCore = CreatePresenter();
        }
        protected override void OnDisposing() {
            Presenter.Dispose();
            entitiesBinding.Dispose();
            base.OnDisposing();
        }
        public EmployeeCollectionViewModel ViewModel {
            get { return GetViewModel<EmployeeCollectionViewModel>(); }
        }
        public EmployeePeekListPresenter Presenter {
            get { return presenterCore; }
        }
        protected virtual EmployeePeekListPresenter CreatePresenter() {
            return new EmployeePeekListPresenter(gridView, ViewModel);
        }
    }
}