namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.Mvvm;

    public abstract class ReportViewModelBase {
        protected internal abstract bool IsLoaded { get; }
        protected internal abstract void OnReload();
    }
    public abstract class ReportViewModelBase<TReportType> : ReportViewModelBase, ISupportParameter
        where TReportType : struct {
        public virtual TReportType ReportType { get; set; }
        protected virtual void OnReportTypeChanged() {
            if(IsLoaded) RaiseReportTypeChanged();
        }
        public event EventHandler ReportTypeChanged;
        void RaiseReportTypeChanged() {
            EventHandler handler = ReportTypeChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        #region ISupportParameter
        object ISupportParameter.Parameter {
            get { return ReportType; }
            set {
                ReportType = (TReportType)value;
                OnParameterChanged();
            }
        }
        protected virtual void OnParameterChanged() { }
        #endregion
    }
    //
    public class ReportViewModelBase<TReportType, TEntity, TPrimaryKey, TUnitOfWork> : ReportViewModelBase<TReportType>
        where TReportType : struct
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        protected override void OnParameterChanged() {
            base.OnParameterChanged();
            CheckReportEntityKey();
        }
        public virtual object ReportEntityKey { get; set; }
        protected virtual void OnReportEntityKeyChanged() {
            RaiseReportEntityKeyChanged();
        }
        public event EventHandler ReportEntityKeyChanged;
        protected internal override void OnReload() {
            if(!IsLoaded) return;
            CheckReportEntityKey();
            RaiseReload();
        }
        public event EventHandler Reload;
        bool isLoadedCore;
        protected internal override bool IsLoaded {
            get { return isLoadedCore; }
        }
        public void OnLoad() {
            CheckReportEntityKey();
            isLoadedCore = true;
        }
        void CheckReportEntityKey() {
            var collectionViewModel = GetCollectionViewModel();
            if(collectionViewModel != null)
                ReportEntityKey = collectionViewModel.SelectedEntityKey;
        }
        protected CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork> GetCollectionViewModel() {
            ISupportParentViewModel supportParent = this as ISupportParentViewModel;
            if(supportParent != null)
                return supportParent.ParentViewModel as CollectionViewModel<TEntity, TPrimaryKey, TUnitOfWork>;
            return null;
        }
        void RaiseReportEntityKeyChanged() {
            EventHandler handler = ReportEntityKeyChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseReload() {
            EventHandler handler = Reload;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}