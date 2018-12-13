namespace DevExpress.DevAV {
    using System;
    using System.Windows.Forms;
    using DevExpress.Mvvm;
    using DevExpress.DevAV.ViewModels;

    class FilterDialogDocumentManagerService : DialogDocumentManagerService {
        readonly ModuleType viewModuleType;
        public FilterDialogDocumentManagerService(ModuleType viewModuleType) {
            this.viewModuleType = viewModuleType;
        }
        protected override IDocument CreateDocumentCore(string documentType, object viewModel, object parentViewModel, object parameter) {
            var moduleLocator = GetService<Services.IModuleLocator>(parentViewModel);
            object view = moduleLocator.GetModule(viewModuleType, viewModel);
            return RegisterDocument(view,
                (form) => new DialogDocument(this, form, viewModel),
                () => new FilterForm() { Text = documentType });
        }
    }
    class ViewSettingsDialogDocumentManagerService : DialogDocumentManagerService {
        Func<CollectionUIViewModel> collectionUIViewModelAccessor;
        public ViewSettingsDialogDocumentManagerService(Func<CollectionUIViewModel> collectionUIViewModel) {
            this.collectionUIViewModelAccessor = collectionUIViewModel;
        }
        protected override IDocument CreateDocumentCore(string documentType, object viewModel, object parentViewModel, object parameter) {
            object view = new Modules.ViewSettingsControl(collectionUIViewModelAccessor());
            viewModel = EnsureViewModel(viewModel, parameter, parentViewModel, view);
            return RegisterDocument(view,
                (form) => new ViewSettingsDialogDocument(this, form, viewModel),
                () => new FilterForm() { Text = documentType });
        }
        #region Document
        class ViewSettingsDialogDocument : DialogDocument {
            public ViewSettingsDialogDocument(ViewSettingsDialogDocumentManagerService owner, Form form, object content)
                : base(owner, form, content) {
                var viewModel = content as ViewSettingsViewModel;
                if(viewModel != null) viewModel.Document = this;
            }
        }
        #endregion Document
    }
}