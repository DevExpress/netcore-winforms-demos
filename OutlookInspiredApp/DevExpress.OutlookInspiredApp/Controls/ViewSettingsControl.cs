namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.ViewModels;

    public partial class ViewSettingsControl : BaseModuleControl {
        public ViewSettingsControl(CollectionUIViewModel collectionViewModel)
            : base(typeof(ViewSettingsViewModel), new object[] { collectionViewModel }) {
            InitializeComponent();
            BindCommands();
        }
        public ViewSettingsViewModel ViewModel {
            get { return GetViewModel<ViewSettingsViewModel>(); }
        }
        void BindCommands() {
            this.resetFiltersBtn.BindCommand(() => ViewModel.ResetCustomFilters(), ViewModel);
            this.resetViewBtn.BindCommand(() => ViewModel.ResetView(), ViewModel);
            //
            this.okBtn.BindCommand(() => ViewModel.OK(), ViewModel);
            this.cancelBtn.BindCommand(() => ViewModel.Cancel(), ViewModel);
        }
    }
}
namespace DevExpress.DevAV.ViewModels {
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    public class ViewSettingsViewModel {
        CollectionUIViewModel collectionUIViewModelCore;

        public static ViewSettingsViewModel Create(CollectionUIViewModel collectionUIViewModel) {
            return ViewModelSource.Create(() => new ViewSettingsViewModel(collectionUIViewModel));
        }
        protected ViewSettingsViewModel(CollectionUIViewModel collectionUIViewModel) {
            this.collectionUIViewModelCore = collectionUIViewModel;
        }
        [Command]
        public void ResetCustomFilters() {
            var vm = ViewModelHelper.GetParentViewModel<ISupportCustomFilters>(this);
            if(vm != null)
                vm.ResetCustomFilters();
        }
        public CollectionUIViewModel CollectionUIViewModel {
            get { return collectionUIViewModelCore; }
        }
        [Command]
        public void ResetView() {
            CollectionUIViewModel.ResetView();
        }
        public IDocument Document { get; set; }
        [Command]
        public void OK() {
            Document.Close();
        }
        [Command]
        public void Cancel() {
            Document.Close();
        }
    }
}