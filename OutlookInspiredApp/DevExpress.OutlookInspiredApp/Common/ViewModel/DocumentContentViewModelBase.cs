namespace DevExpress.DevAV {
    using System.ComponentModel;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.DataAnnotations;

    public abstract class DocumentContentViewModelBase : IDocumentContent {
        protected DocumentContentViewModelBase() { }
        [Command]
        public void Close() {
            ((IDocumentContent)this).DocumentOwner.Close(this);
        }
        #region IDocumentContent
        void IDocumentContent.OnClose(CancelEventArgs e) { }
        void IDocumentContent.OnDestroy() { }
        IDocumentOwner IDocumentContent.DocumentOwner { get; set; }
        object IDocumentContent.Title {
            get { return GetTitle(); }
        }
        protected virtual string GetTitle() {
            return null;
        }
        #endregion
    }
}