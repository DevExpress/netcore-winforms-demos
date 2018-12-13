namespace DevExpress.DevAV.Presenters {
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.Data.Filtering;
    using DevExpress.Data.Utils;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraGrid.Views.WinExplorer;

    public abstract class GroupFilterPresenter<TEntity, TID, TUnitOfWork> : BasePresenter<GroupFilterViewModel>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        WinExplorerView winExplorerView;
        public GroupFilterPresenter(WinExplorerView winExplorerView, GroupFilterViewModel viewModel)
            : base(viewModel) {
            this.winExplorerView = winExplorerView;
            if(winExplorerView != null) {
                winExplorerView.ItemClick += winExplorerView_ItemClick;
                winExplorerView.CustomUnboundColumnData += winExplorerView_CustomUnboundColumnData;
                winExplorerView.GridControl.Load += (s, e) => GridHelper.SetFindControlImages(winExplorerView.GridControl, false);
            }
            ViewModel.QueryFilterCriteria += ViewModel_QueryFilterCriteria;
        }
        protected override void OnDisposing() {
            ViewModel.QueryFilterCriteria -= ViewModel_QueryFilterCriteria;
            if(winExplorerView != null) {
                winExplorerView.ItemClick -= winExplorerView_ItemClick;
                winExplorerView.CustomUnboundColumnData -= winExplorerView_CustomUnboundColumnData;
                winExplorerView = null;
            }
            base.OnDisposing();
        }
        public void Load() {
            var expression = FilterTreeViewModel<TEntity, TID, TUnitOfWork>.GetFilterExpression(ViewModel.FilterCriteria);
            var collectionViewModel = GetParentViewModel<CollectionViewModel<TEntity, TID, TUnitOfWork>>();
            if(expression != null) {
                foreach(TEntity entity in collectionViewModel.GetEntities(expression))
                    selection.Add(GetEntityKey(entity));
            }
            winExplorerView.GridControl.DataSource = collectionViewModel.GetEntities().ToList();
        }
        HashSet<TID> selection = new HashSet<TID>();
        protected abstract TID GetEntityKey(TEntity entity);
        bool GetIsSelected(TEntity entity) {
            return selection.Contains(GetEntityKey(entity));
        }
        void ViewModel_QueryFilterCriteria(object sender, QueryFilterCriteriaEventArgs e) {
            e.FilterCriteria = new InOperator("Id", selection);
        }
        void SetIsSelected(TEntity entity, bool selected) {
            if(selected)
                selection.Add(GetEntityKey(entity));
            else
                selection.Remove(GetEntityKey(entity));
        }
        void winExplorerView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            if(e.IsSetData) SetIsSelected((TEntity)e.Row, (bool)e.Value);
            if(e.IsGetData) e.Value = GetIsSelected((TEntity)e.Row);
        }
        void winExplorerView_ItemClick(object sender, WinExplorerViewItemClickEventArgs e) {
            TEntity entity = e.ItemInfo.Row.RowKey as TEntity;
            if(entity != null) {
                SetIsSelected(entity, !e.ItemInfo.IsChecked);
                winExplorerView.RefreshData();
            }
        }
    }
}