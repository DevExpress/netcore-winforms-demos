namespace DevExpress.DevAV {
    using System;
    using System.Windows.Forms;
    using DevExpress.DevAV.Modules;
    using DevExpress.DevAV.Services;
    using DevExpress.Mvvm;

    abstract class DetailFormDocumentManagerServiceBase : DocumentManagerServiceBase {
        readonly ModuleType viewModuleType;
        public DetailFormDocumentManagerServiceBase(ModuleType viewModuleType) {
            this.viewModuleType = viewModuleType;
        }
        #region Document
        protected class DetailFormDocument : IDocument, IDocumentInfo {
            readonly object contentCore;
            readonly Form formCore;
            readonly DetailFormDocumentManagerServiceBase owner;
            DocumentState state = DocumentState.Hidden;
            public DetailFormDocument(DetailFormDocumentManagerServiceBase owner, Form form, object content) {
                this.owner = owner;
                this.formCore = form;
                this.contentCore = content;
                form.AutoValidate = AutoValidate.EnableAllowFocusChange;
                form.Closing += form_Closing;
                form.Closed += form_Closed;
            }
            void form_Closed(object sender, EventArgs e) {
                owner.RemoveDocument(this);
                formCore.Closing -= form_Closing;
                formCore.Closed -= form_Closed;
                IDocumentContent documentContent = GetContent() as IDocumentContent;
                if(documentContent != null)
                    documentContent.OnDestroy();
            }
            void form_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
                IDocumentContent documentContent = GetContent() as IDocumentContent;
                if(documentContent != null)
                    documentContent.OnClose(e);
                if(!destroyOnCloseCore) {
                    bool cancel = e.Cancel;
                    e.Cancel = true;
                    if(!cancel)
                        formCore.Hide();
                }
            }
            void IDocument.Show() {
                if(!formCore.Visible)
                    formCore.Show(AppHelper.MainForm);
                else
                    formCore.Activate();
                state = DocumentState.Visible;
            }
            void IDocument.Hide() {
                formCore.Hide();
                state = DocumentState.Hidden;
            }
            void IDocument.Close(bool force) {
                if(force) {
                    formCore.Closing -= form_Closing;
                    DevExpress.XtraEditors.Container.ContainerHelper.ClearUnvalidatedControl(formCore.ActiveControl, formCore);
                }
                formCore.Close();
                state = DocumentState.Hidden;
            }
            bool destroyOnCloseCore = true;
            bool IDocument.DestroyOnClose {
                get { return destroyOnCloseCore; }
                set { destroyOnCloseCore = value; }
            }
            object IDocument.Id { get; set; }
            object IDocument.Title {
                get { return formCore.Text; }
                set { formCore.Text = Convert.ToString(value); }
            }
            object IDocument.Content {
                get { return GetContent(); }
            }
            object GetContent() {
                return contentCore;
            }
            DocumentState IDocumentInfo.State {
                get { return state; }
            }
            string IDocumentInfo.DocumentType {
                get { return null; }
            }
        }
        #endregion Document
        protected bool IsDefaultViewModuleType(ModuleType actualViewModuleType) {
            return viewModuleType == actualViewModuleType;
        }
        protected virtual ModuleType GetActualViewModuleType(string documentType, object parentViewModel) {
            if(documentType == "MapView") {
                var resolver = GetService<Services.IModuleTypesResolver>(parentViewModel);
                return resolver.GetMapModuleType(viewModuleType);
            }
            if(documentType == "MailMerge") {
                var resolver = GetService<Services.IModuleTypesResolver>(parentViewModel);
                return resolver.GetMailMergeModuleType(viewModuleType);
            }
            if(documentType == "Analysis") {
                var resolver = GetService<Services.IModuleTypesResolver>(parentViewModel);
                return resolver.GetAnalysisModuleType(viewModuleType);
            }
            if(documentType == "OrderPdfQuickReportView")
                return ModuleType.OrderPdfQuickReportView;
            if(documentType == "OrderXlsQuickReportView")
                return ModuleType.OrderXlsQuickReportView;
            if(documentType == "OrderDocQuickReportView")
                return ModuleType.OrderDocQuickReportView;
            if(documentType == "OrderRevenueView")
                return ModuleType.OrderRevenueView;
            return viewModuleType;
        }
        protected static object CreateView(object parameter, ModuleType actualModuleType, IModuleLocator moduleLocator) {
            if(parameter is Delegate)
                return moduleLocator.CreateModule(actualModuleType);
            if(parameter is long)
                return moduleLocator.GetModule(actualModuleType, (long)parameter);
            else
                return moduleLocator.GetModule(actualModuleType);
        }
        protected IDocument RegisterDetailFormDocumentForModule(object viewModel, object parentViewModel, object parameter, ModuleType actualModuleType) {
            var waitingService = GetService<Services.IWaitingService>(parentViewModel);
            using(waitingService.Enter(actualModuleType)) {
                var moduleLocator = GetService<Services.IModuleLocator>(parentViewModel);
                object view = CreateView(parameter, actualModuleType, moduleLocator);
                viewModel = EnsureViewModel(viewModel, parameter, parentViewModel, view);
                return RegisterDocument(view, (container) => new DetailFormDocument(this, container, viewModel), () => new DetailForm(), parameter);
            }
        }
    }
    class DetailFormDocumentManagerService : DetailFormDocumentManagerServiceBase, IDocumentManagerService {
        public DetailFormDocumentManagerService(ModuleType viewModuleType)
            : base(viewModuleType) {
        }
        protected override IDocument CreateDocumentCore(string documentType, object viewModel, object parentViewModel, object parameter) {
            var actualModuleType = GetActualViewModuleType(documentType, parentViewModel);
            return RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType);
        }
    }
    class NotImplementedDetailFormDocumentManagerService : DetailFormDocumentManagerServiceBase, IDocumentManagerService {
        public NotImplementedDetailFormDocumentManagerService(ModuleType viewModuleType)
            : base(viewModuleType) {
        }
        protected override IDocument CreateDocumentCore(string documentType, object viewModel, object parentViewModel, object parameter) {
            var actualModuleType = GetActualViewModuleType(documentType, parentViewModel);
            return IsDefaultViewModuleType(actualModuleType) ? new DXOverviewDocument() :
                RegisterDetailFormDocumentForModule(viewModel, parentViewModel, parameter, actualModuleType);
        }
        #region DXAbout
        protected class DXOverviewDocument : IDocument, IDocumentInfo {
            Form form = new DevExpress.XtraEditors.XtraForm();
            DocumentState state = DocumentState.Hidden;
            const string captionText =
                "DevExpress";
            const string descriptionText =
                "You can easily create custom edit forms using the 40+ controls that ship as part of the DevExpress Data Editors Library.<br>" +
                "To see what you can build, <href=Employees>activate the Employees module.</href>";
            #region IDocument Members
            void IDocument.Show() {
                OverviewControl overview = new OverviewControl();
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.Text = captionText;
                form.ClientSize = overview.Size;
                form.MinimumSize = form.Size;
                overview.SetDescription(descriptionText);
                overview.Dock = DockStyle.Fill;
                overview.Parent = form;
                form.StartPosition = FormStartPosition.CenterParent;
                form.Icon = AppHelper.AppIcon;
                using(form) {
                    form.ShowDialog(AppHelper.MainForm);
                }
                state = DocumentState.Visible;
            }
            object IDocument.Content { get { return null; } }
            bool IDocument.DestroyOnClose { get; set; }
            void IDocument.Hide() {
                form.Close();
                state = DocumentState.Hidden;
            }
            void IDocument.Close(bool force) {
                form.Close();
                state = DocumentState.Hidden;
            }
            object IDocument.Title { get; set; }
            object IDocument.Id { get; set; }
            #endregion

            DocumentState IDocumentInfo.State {
                get { return state; }
            }
            string IDocumentInfo.DocumentType {
                get { return null; }
            }
        }
        #endregion
    }
}