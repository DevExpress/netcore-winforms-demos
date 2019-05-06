namespace DevExpress.DevAV.Modules {
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.Utils.Menu;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Nodes;

    class FilterTreeListHelper<TEntity, TID, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        TreeList treeList;
        public FilterTreeListHelper(XtraTreeList.TreeList treeList) {
            this.treeList = treeList;
        }
        public void ModifyFilter(TreeListNode node, FilterTreeViewModel<TEntity, TID, TUnitOfWork> viewModel) {
            if(node != null && node.ParentNode != null) {
                if(MatchHierarchy(node, viewModel.CustomFilters))
                    viewModel.Modify(GetRow<FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem>(node));
                if(MatchHierarchy(node, viewModel.Groups))
                    viewModel.ModifyGroup(GetRow<FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem>(node));
            }
        }
        public bool PopulateFiltersMenu(DXPopupMenu nodeMenu, TreeListNode node, FilterTreeViewModel<TEntity, TID, TUnitOfWork> viewModel) {
            if(MatchHierarchy(node, viewModel.CustomFilters)) {
                var newItem = new DXMenuItem();
                newItem.Caption = "New...";
                newItem.BindCommand(() => viewModel.New(), viewModel);
                nodeMenu.Items.Add(newItem);
                if(node.ParentNode != null) {
                    var filterItem = GetRow<FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem>(node);
                    var editItem = new DXMenuItem();
                    editItem.Caption = "Modify...";
                    editItem.BindCommand((f) => viewModel.Modify(f), viewModel, () => filterItem);
                    nodeMenu.Items.Add(editItem);
                    var deleteItem = new DXMenuItem();
                    deleteItem.Caption = "Delete";
                    deleteItem.BindCommand((f) => viewModel.Delete(f), viewModel, () => filterItem);
                    nodeMenu.Items.Add(deleteItem);
                }
                return true;
            }
            if(MatchHierarchy(node, viewModel.Groups)) {
                var newItem = new DXMenuItem();
                newItem.Caption = "New Group...";
                newItem.BindCommand(() => viewModel.NewGroup(), viewModel);
                nodeMenu.Items.Add(newItem);
                if(node.ParentNode != null) {
                    var filterItem = GetRow<FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem>(node);
                    var editItem = new DXMenuItem();
                    editItem.Caption = "Modify Group...";
                    editItem.BindCommand((f) => viewModel.ModifyGroup(f), viewModel, () => filterItem);
                    nodeMenu.Items.Add(editItem);
                    var deleteItem = new DXMenuItem();
                    deleteItem.Caption = "Delete Group";
                    deleteItem.BindCommand((f) => viewModel.DeleteGroup(f), viewModel, () => filterItem);
                    nodeMenu.Items.Add(deleteItem);
                }
                return true;
            }
            return false;
        }
        public TreeListNode FindNode(object dataItem) {
            return treeList.FindNode((node) => Match(node, dataItem));
        }
        public bool Match(TreeListNode node, object dataItem) {
            return treeList.GetDataRecordByNode(node) == dataItem;
        }
        public bool MatchHierarchy(TreeListNode node, object dataItem) {
            while(node != null) {
                if(Match(node, dataItem))
                    return true;
                node = node.ParentNode;
            }
            return false;
        }
        public T GetRow<T>(TreeListNode node) where T : class {
            return treeList.GetDataRecordByNode(node) as T;
        }
    }
}