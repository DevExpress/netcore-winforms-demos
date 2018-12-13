namespace DevExpress.DevAV.Presenters {
    using System.Linq;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;
    using IServiceContainer = DevExpress.Mvvm.IServiceContainer;

    public abstract class BasePresenter<TViewModel> where TViewModel : class {
        public BasePresenter(TViewModel viewModel) {
            this.viewModelCore = viewModel;
        }
        bool isDisposing;
        public void Dispose() {
            if(!isDisposing) {
                isDisposing = true;
                OnDisposing();
                this.viewModelCore = null;
            }
        }
        TViewModel viewModelCore;
        public TViewModel ViewModel {
            get { return viewModelCore; }
        }
        protected TParentViewModel GetParentViewModel<TParentViewModel>() {
            return (TParentViewModel)((ISupportParentViewModel)viewModelCore).ParentViewModel;
        }
        protected TService GetService<TService>() where TService : class {
            var serviceContainer = GetServiceContainer();
            return (serviceContainer != null) ? serviceContainer.GetService<TService>() : null;
        }
        Mvvm.IServiceContainer GetServiceContainer() {
            if(!(viewModelCore is ISupportServices)) return null;
            return ((ISupportServices)viewModelCore).ServiceContainer;
        }
        protected virtual void OnDisposing() { }
    }
}