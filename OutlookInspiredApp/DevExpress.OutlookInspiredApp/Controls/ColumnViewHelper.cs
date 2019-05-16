namespace DevExpress.DevAV {
    using System.Collections.Generic;
    using System.Drawing;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.XtraGrid.Views.Base;

    class ColumnViewHelper<TEntity, TID, TUnitOfWork>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        CollectionViewModel<TEntity, TID, TUnitOfWork> viewModel;
        ColumnView view;
        public ColumnViewHelper(ColumnView view, CollectionViewModel<TEntity, TID, TUnitOfWork> viewModel) {
            this.view = view;
            this.viewModel = viewModel;
        }
        public IEnumerable<TEntity> GetSelection() {
            int[] rowHandles = view.GetSelectedRows();
            TEntity[] entities = new TEntity[rowHandles.Length];
            for(int i = 0; i < entities.Length; i++)
                entities[i] = view.GetRow(rowHandles[i]) as TEntity;
            return entities;
        }
        public void PopulateEntityMenu(DevExpress.Utils.Menu.DXPopupMenu menu, int rowHandle) {
            if(!view.IsDataRow(rowHandle)) return;
            TEntity entity = view.GetRow(rowHandle) as TEntity;
            if(entity != null)
                CreateEntityMenu(menu, entity);
        }
        public bool ShowEntityMenu(Point pt, int rowHandle) {
            TEntity entity = view.GetRow(rowHandle) as TEntity;
            if(entity != null) {
                var rowMenu = new Utils.Menu.DXPopupMenu();
                CreateEntityMenu(rowMenu, entity);
                DevExpress.Utils.Menu.MenuManagerHelper.ShowMenu(rowMenu, view.GridControl.LookAndFeel,
                    view.GridControl.MenuManager, view.GridControl, pt);
                return true;
            }
            return false;
        }
        public bool EditEntity(int rowHandle) {
            if(!view.IsDataRow(rowHandle)) return false;
            TEntity entity = view.GetRow(rowHandle) as TEntity;
            if(entity != null && viewModel.CanEdit(entity)) {
                viewModel.Edit(entity);
                return true;
            }
            return false;
        }
        public bool IsEntity(int rowHandle) {
            if(!view.IsValidRowHandle(rowHandle)) return false;
            return view.IsDataRow(rowHandle);
        }
        public bool SelectEntity(int rowHandle) {
            if(!view.IsValidRowHandle(rowHandle)) return false;
            if(view.IsDataRow(rowHandle))
                viewModel.SelectedEntity = view.GetRow(rowHandle) as TEntity;
            else
                viewModel.SelectedEntity = null;
            return true;
        }
        protected void CreateEntityMenu(DevExpress.Utils.Menu.DXPopupMenu rowMenu, TEntity entity) {
            var newItem = new Utils.Menu.DXMenuItem();
            newItem.Caption = "New";
            newItem.BindCommand(() => viewModel.New(), viewModel);

            var editItem = new Utils.Menu.DXMenuItem();
            editItem.Caption = "Edit...";
            editItem.BindCommand((ee) => viewModel.Edit(ee), viewModel, () => entity);

            var deleteItem = new Utils.Menu.DXMenuItem();
            deleteItem.Caption = "Delete";
            deleteItem.BindCommand((ee) => viewModel.Delete(ee), viewModel, () => entity);

            rowMenu.Items.Add(newItem);
            rowMenu.Items.Add(editItem);
            rowMenu.Items.Add(deleteItem);
        }
    }
}