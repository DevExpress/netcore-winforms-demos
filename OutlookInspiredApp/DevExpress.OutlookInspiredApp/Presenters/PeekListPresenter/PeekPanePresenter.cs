namespace DevExpress.DevAV.Presenters {
    using DevExpress.Mvvm.DataModel;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraGrid.Views.Grid;

    public abstract class PeekListPresenter<TEntity, TID, TUnitOfWork> :
        BasePresenter<CollectionViewModel<TEntity, TID, TUnitOfWork>>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        public PeekListPresenter(GridView gridView, CollectionViewModel<TEntity, TID, TUnitOfWork> viewModel)
            : base(viewModel) {
            this.gridViewCore = gridView;
            if(GridView != null)
                InitRowActivationBehavior();
        }
        protected override void OnDisposing() {
            if(GridView != null)
                ReleaseRowActivationBehavior();
            this.gridViewCore = null;
            base.OnDisposing();
        }
        GridView gridViewCore;
        protected GridView GridView {
            get { return gridViewCore; }
        }
        protected MainViewModel MainViewModel {
            get { return GetParentViewModel<MainViewModel>(); }
        }
        #region Row Activation Behavior
        void InitRowActivationBehavior() {
            GridView.RowClick += GridView_RowClick;
            GridView.KeyDown += GridView_KeyDown;
        }
        void ReleaseRowActivationBehavior() {
            GridView.RowClick -= GridView_RowClick;
            GridView.KeyDown -= GridView_KeyDown;
        }
        void GridView_RowClick(object sender, RowClickEventArgs e) {
            if(e.Clicks == 2 && e.Button == System.Windows.Forms.MouseButtons.Left)
                e.Handled = TrySelectEntity(e.RowHandle);
        }
        void GridView_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == System.Windows.Forms.Keys.Enter)
                e.Handled = TrySelectEntity(GridView.FocusedRowHandle);
        }
        bool TrySelectEntity(int rowHandle) {
            var helper = new ColumnViewHelper<TEntity, TID, TUnitOfWork>(GridView, ViewModel);
            if(helper.IsEntity(rowHandle))
                MainViewModel.SelectedModuleType = GetMainModuleType();
            return helper.SelectEntity(rowHandle);
        }
        #endregion
        protected abstract ModuleType GetMainModuleType();
    }
}