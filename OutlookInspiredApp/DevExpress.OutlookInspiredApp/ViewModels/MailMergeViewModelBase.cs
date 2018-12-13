namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.ComponentModel;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;

    public abstract class MailMergeViewModelBase<TMailTemplate> : ISupportParameter, IDocumentContent
        where TMailTemplate : struct {
        public virtual TMailTemplate? MailTemplate { get; set; }
        protected virtual void OnMailTemplateChanged() {
            RaiseMailTemplateChanged();
        }
        public virtual bool IsMailTemplateSelected { get; set; }
        protected virtual void OnIsMailTemplateSelectedChanged() {
            RaiseMailTemplateSelectedChanged();
        }
        object ISupportParameter.Parameter {
            get { return MailTemplate; }
            set {
                IsMailTemplateSelected = value is TMailTemplate;
                if(IsMailTemplateSelected)
                    MailTemplate = (TMailTemplate)value;
                else MailTemplate = null;
            }
        }
        public event EventHandler MailTemplateChanged;
        public event EventHandler MailTemplateSelectedChanged;
        void RaiseMailTemplateChanged() {
            EventHandler handler = MailTemplateChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseMailTemplateSelectedChanged() {
            EventHandler handler = MailTemplateSelectedChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        protected IMessageBoxService MessageBoxService { get { return this.GetService<IMessageBoxService>(); } }
        public bool Modified { get; set; }
        [DevExpress.Mvvm.DataAnnotations.Command]
        public bool Close() {
            MessageResult result = MessageResult.Yes;
            if(Modified) {
                if(MessageBoxService != null) {
                    result = MessageBoxService.Show("Do you want to save changes?", "Mail Merge",
                        MessageButton.YesNoCancel,
                        MessageIcon.Question,
                        MessageResult.Yes);
                    if(result == MessageResult.Yes)
                        RaiseSave();
                }
            }
            if(result != MessageResult.Cancel && DocumentOwner != null)
                DocumentOwner.Close(this);
            return result != MessageResult.Cancel;
        }
        public event EventHandler Save;
        void RaiseSave() {
            EventHandler handler = Save;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        protected IDocumentOwner DocumentOwner { get; private set; }
        #region IDocumentContent
        object IDocumentContent.Title {
            get { return "Mail Merge"; }
        }
        void IDocumentContent.OnClose(CancelEventArgs e) {
            e.Cancel = !Close();
        }
        void IDocumentContent.OnDestroy() { }
        IDocumentOwner IDocumentContent.DocumentOwner {
            get { return DocumentOwner; }
            set { DocumentOwner = value; }
        }
        #endregion
    }
}