namespace DevExpress.DevAV {
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.Mvvm;
    using DevExpress.DevAV.Modules;

    public abstract class DocumentManagerServiceBase : IDocumentManagerService, IDocumentOwner {
        IList<IDocument> documentsCore;
        public DocumentManagerServiceBase() {
            this.documentsCore = new List<IDocument>();
        }
        protected IDocument RegisterDocument(object view, Func<Form, IDocument> createDocument, Func<Form> createContainer, object id = null) {
            Form container = null;
            if(createContainer != null) {
                container = createContainer();
                if(container != null)
                    container.Owner = AppHelper.MainForm;
            }
            IDocument document = createDocument(container);
            document.Id = id;
            documentsCore.Add(document);
            if(view != null) {
                container.ClientSize = ((Control)view).Size;
                ((Control)view).Dock = DockStyle.Fill;
                ((Control)view).Parent = container;
                ((Control)view).BringToFront();
            }
            return document;
        }
        protected object EnsureViewModel(object viewModel, object parameter, object parentViewModel, object view) {
            if(viewModel == null) {
                if(view is ISupportViewModel)
                    viewModel = ((ISupportViewModel)view).ViewModel;
                ViewModelHelper.EnsureModuleViewModel(view, parentViewModel, parameter);
            }
            IDocumentContent documentContent = viewModel as IDocumentContent;
            if(documentContent != null)
                documentContent.DocumentOwner = this;
            return viewModel;
        }
        protected internal void RemoveDocument(IDocument document) {
            documentsCore.Remove(document);
        }
        protected TService GetService<TService>(object viewModel) where TService : class {
            return ((ISupportServices)viewModel).ServiceContainer.GetService<TService>();
        }
        #region IDocumentManagerService
        IDocument IDocumentManagerService.CreateDocument(string documentType, object viewModel, object parameter, object parentViewModel) {
            return CreateDocumentCore(documentType, viewModel, parentViewModel, parameter);
        }
        IEnumerable<IDocument> IDocumentManagerService.Documents {
            get { return documentsCore; }
        }
        IDocument IDocumentManagerService.ActiveDocument {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        event ActiveDocumentChangedEventHandler IDocumentManagerService.ActiveDocumentChanged {
            add { }
            remove { }
        }
        #endregion IDocumentManagerService
        void IDocumentOwner.Close(IDocumentContent documentContent, bool force) {
            var document = documentsCore.FirstOrDefault((d) => object.Equals(d.Content, documentContent));
            if(document != null)
                document.Close(force);
        }
        protected abstract IDocument CreateDocumentCore(string documentType, object viewModel, object parentViewModel, object parameter);
    }
    public abstract class DialogDocumentManagerService : DocumentManagerServiceBase {
        #region Document
        protected class DialogDocument : IDocument, IDocumentInfo {
            readonly object contentCore;
            readonly Form formCore;
            readonly DialogDocumentManagerService owner;
            DocumentState state = DocumentState.Hidden;
            public DialogDocument(DialogDocumentManagerService owner, Form form, object content) {
                this.owner = owner;
                this.formCore = form;
                this.contentCore = content;
                form.AutoValidate = AutoValidate.EnableAllowFocusChange;
                form.Closed += form_Closed;
            }
            void form_Closed(object sender, EventArgs e) {
                owner.RemoveDocument(this);
                formCore.Closed -= form_Closed;
            }
            void IDocument.Show() {
                using(formCore) {
                    formCore.ShowDialog();
                }
                state = DocumentState.Visible;
            }
            void IDocument.Hide() {
                formCore.Close();
                state = DocumentState.Hidden;
            }
            void IDocument.Close(bool force) {
                formCore.Close();
                state = DocumentState.Hidden;
            }
            bool IDocument.DestroyOnClose {
                get { return true; }
                set { }
            }
            object IDocument.Id { get; set; }
            object IDocument.Title {
                get { return formCore.Text; }
                set { formCore.Text = Convert.ToString(value); }
            }
            object IDocument.Content {
                get { return contentCore; }
            }
            DocumentState IDocumentInfo.State {
                get { return state; }
            }
            string IDocumentInfo.DocumentType {
                get { return null; }
            }
        }
        #endregion Document
    }
}