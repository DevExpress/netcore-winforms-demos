namespace DevExpress.DevAV.Presenters {
    using System.Windows.Forms;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.DevAV.Modules;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraTreeList;

    public abstract class FilterTreeListPresenter<TEntity, TID, TUnitOfWork> :
        BasePresenter<FilterTreeViewModel<TEntity, TID, TUnitOfWork>>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        public FilterTreeListPresenter(TreeList treeList, FilterTreeViewModel<TEntity, TID, TUnitOfWork> viewModel)
            : base(viewModel) {
            this.treeListCore = treeList;
            if(CollectionViewModel != null)
                SubscribeCollectionViewModelEvents();
            if(treeListCore != null) {
                InitTreeListFocusedNodeSynchronization();
                InitTreeListNodeMenu();
                InitTreeListNodesDragDrop();
                BindTreeList();
            }
        }
        protected override void OnDisposing() {
            if(CollectionViewModel != null)
                UnsubscribeCollectionViewModelEvents();
            if(treeListCore != null) {
                UnbindTreeList();
                ReleaseTreeListNodesDragDrop();
                ReleaseTreeListNodeMenu();
                ReleaseTreeListFocusedNodeSynchronization();
            }
            this.treeListCore = null;
            base.OnDisposing();
        }
        TreeList treeListCore;
        protected TreeList TreeList {
            get { return treeListCore; }
        }
        public CollectionViewModel<TEntity, TID, TUnitOfWork> CollectionViewModel {
            get { return ViewModel.CollectionViewModel; }
        }
        protected virtual void SubscribeCollectionViewModelEvents() {
            CollectionViewModel.EntitiesCountChanged += CollectionViewModel_EntitiesCountChanged;
        }
        protected virtual void UnsubscribeCollectionViewModelEvents() {
            CollectionViewModel.EntitiesCountChanged -= CollectionViewModel_EntitiesCountChanged;
        }
        void CollectionViewModel_EntitiesCountChanged(object sender, System.EventArgs e) {
            TreeList.RefreshDataSource();
        }
        protected void CollectionViewModel_CustomFilter(object sender, System.EventArgs e) {
            ViewModel.New();
        }
        protected void CollectionViewModel_CustomGroup(object sender, System.EventArgs e) {
            ViewModel.NewGroup();
        }
        protected void CollectionViewModel_CustomGroupFromSelection(object sender, GroupEventArgs<TEntity> e) {
            ViewModel.NewGroupFromSelection(e.Entities);
        }
        #region TreeList Binding
        void BindTreeList() {
            TreeList.VirtualTreeGetChildNodes += treeList_VirtualTreeGetChildNodes;
            TreeList.VirtualTreeGetCellValue += treeList_VirtualTreeGetCellValue;
            TreeList.Columns.AddField("Name").Visible = true;
            TreeList.DataSource = ViewModel;
            TreeList.ExpandAll();
            var helper = new FilterTreeListHelper<TEntity, TID, TUnitOfWork>(TreeList);
            TreeList.FocusedNode = helper.FindNode(ViewModel.SelectedItem);
        }
        void UnbindTreeList() {
            TreeList.VirtualTreeGetChildNodes -= treeList_VirtualTreeGetChildNodes;
            TreeList.VirtualTreeGetCellValue -= treeList_VirtualTreeGetCellValue;
        }
        void treeList_VirtualTreeGetChildNodes(object sender, VirtualTreeGetChildNodesInfo e) {
            e.Children = ViewModel.GetСhildren(e.Node);
        }
        void treeList_VirtualTreeGetCellValue(object sender, VirtualTreeGetCellValueInfo e) {
            e.CellData = ViewModel.GetFilterName(e.Node, e.Node as FilterItemBase);
        }
        #endregion
        #region TreeList Node Menu
        void InitTreeListNodeMenu() {
            TreeList.PopupMenuShowing += treeList_PopupMenuShowing;
            TreeList.MouseDoubleClick += treeList_MouseDoubleClick;
        }
        void ReleaseTreeListNodeMenu() {
            TreeList.PopupMenuShowing -= treeList_PopupMenuShowing;
            TreeList.MouseDoubleClick -= treeList_MouseDoubleClick;
        }
        void treeList_MouseDoubleClick(object sender, MouseEventArgs e) {
            var hi = TreeList.CalcHitInfo(e.Location);
            var helper = new FilterTreeListHelper<TEntity, TID, TUnitOfWork>(TreeList);
            helper.ModifyFilter(hi.Node, ViewModel);
        }
        void treeList_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if(e.Menu.MenuType == XtraTreeList.Menu.TreeListMenuType.Node) {
                var hi = TreeList.CalcHitInfo(e.Point);
                var helper = new FilterTreeListHelper<TEntity, TID, TUnitOfWork>(TreeList);
                if(!helper.PopulateFiltersMenu(e.Menu, hi.Node, ViewModel))
                    e.Allow = false;
            }
        }
        #endregion
        #region Nodes Drag&Drop
        void InitTreeListNodesDragDrop() {
            TreeList.BeforeDragNode += treeList_BeforeDragNode;
            TreeList.DragOver += treeList_DragOver;
            TreeList.DragDrop += treeList_DragDrop;
            TreeList.CalcNodeDragImageIndex += treeList_CalcNodeDragImageIndex;
        }
        void ReleaseTreeListNodesDragDrop() {
            TreeList.BeforeDragNode -= treeList_BeforeDragNode;
            TreeList.DragOver -= treeList_DragOver;
            TreeList.DragDrop -= treeList_DragDrop;
            TreeList.CalcNodeDragImageIndex -= treeList_CalcNodeDragImageIndex;
        }
        void treeList_BeforeDragNode(object sender, BeforeDragNodeEventArgs e) {
            if(e.Node.ParentNode == null)
                e.CanDrag = false;
        }
        void treeList_DragOver(object sender, DragEventArgs e) {
            DXDragEventArgs ea = TreeList.GetDXDragEventArgs(e);
            if(!object.Equals(ea.RootNode, ea.TargetRootNode))
                e.Effect = DragDropEffects.None;
            else
                e.Effect = DragDropEffects.Move;
        }
        void treeList_DragDrop(object sender, DragEventArgs e) {
            DXDragEventArgs ea = TreeList.GetDXDragEventArgs(e);
            if(ea.TargetNode != null) {
                TreeList.SetNodeIndex(ea.Node, TreeList.GetNodeIndex(ea.TargetNode));
                e.Effect = DragDropEffects.None;
            }
        }
        void treeList_CalcNodeDragImageIndex(object sender, CalcNodeDragImageIndexEventArgs e) {
            DXDragEventArgs ea = TreeList.GetDXDragEventArgs(e.DragArgs);
            if(!object.Equals(ea.RootNode, ea.TargetRootNode))
                e.ImageIndex = -1;
            else
                e.ImageIndex = 1;
        }
        #endregion
        #region Focused Node Synchronization
        void InitTreeListFocusedNodeSynchronization() {
            ViewModel.SelectedItemChanged += ViewModel_SelectedItemChanged;
            ViewModel.FilterTreeChanged += ViewModel_FilterTreeChanged;
            TreeList.FocusedNodeChanged += treeList_FocusedNodeChanged;
            TreeList.BeforeFocusNode += treeList_BeforeFocusNode;
        }
        void ReleaseTreeListFocusedNodeSynchronization() {
            ViewModel.SelectedItemChanged -= ViewModel_SelectedItemChanged;
            ViewModel.FilterTreeChanged -= ViewModel_FilterTreeChanged;
            TreeList.FocusedNodeChanged -= treeList_FocusedNodeChanged;
            TreeList.BeforeFocusNode -= treeList_BeforeFocusNode;
        }
        void treeList_BeforeFocusNode(object sender, BeforeFocusNodeEventArgs e) {
            e.CanFocus = (TreeList.GetDataRecordByNode(e.Node) is FilterItemBase);
        }
        void ViewModel_FilterTreeChanged(object sender, System.EventArgs e) {
            TreeList.RefreshDataSource();
            TreeList.ExpandAll();
        }
        int lockFocusedNodeChanged = 0;
        void treeList_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            lockFocusedNodeChanged++;
            try {
                var filterItem = TreeList.GetDataRecordByNode(e.Node) as FilterItemBase;
                ViewModel.SelectedItem = filterItem;
                TreeList.RefreshNode(e.Node);
                TreeList.RefreshNode(e.OldNode);
            }
            finally { lockFocusedNodeChanged--; }
        }
        void ViewModel_SelectedItemChanged(object sender, System.EventArgs e) {
            if(lockFocusedNodeChanged == 0) {
                var helper = new FilterTreeListHelper<TEntity, TID, TUnitOfWork>(TreeList);
                TreeList.FocusedNode = helper.FindNode(ViewModel.SelectedItem);
            }
        }
        #endregion
    }
}