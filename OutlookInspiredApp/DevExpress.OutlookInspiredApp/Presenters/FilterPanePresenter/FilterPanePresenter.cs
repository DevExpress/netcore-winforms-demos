namespace DevExpress.DevAV.Presenters {
    using System.Linq;
    using DevExpress.Mvvm.DataModel;
    using DevExpress.DevAV.Common.ViewModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraBars.Navigation;

    public abstract class FilterPanePresenter<TEntity, TID, TUnitOfWork> :
        BasePresenter<FilterTreeViewModel<TEntity, TID, TUnitOfWork>>
        where TEntity : class
        where TUnitOfWork : class, IUnitOfWork {
        public FilterPanePresenter(OfficeNavigationBar navigationBar, FilterTreeViewModel<TEntity, TID, TUnitOfWork> viewModel)
            : base(viewModel) {
            this.navigationBarCore = navigationBar;
            //
            if(CollectionViewModel != null)
                SubscribeCollectionViewModelEvents();
            if(OfficeNavigationBar != null) {
                BindItems();
                OfficeNavigationBar.SelectedItemChanging += navigationBar_SelectedItemChanging;
            }
        }
        protected override void OnDisposing() {
            if(CollectionViewModel != null)
                UnsubscribeCollectionViewModelEvents();
            if(OfficeNavigationBar != null)
                OfficeNavigationBar.SelectedItemChanging -= navigationBar_SelectedItemChanging;
            this.navigationBarCore = null;
            base.OnDisposing();
        }
        OfficeNavigationBar navigationBarCore;
        protected OfficeNavigationBar OfficeNavigationBar {
            get { return navigationBarCore; }
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
            foreach(NavigationBarItem navItem in OfficeNavigationBar.Items)
                navItem.Text = ViewModel.GetFilterName(ViewModel.StaticFilters, (FilterItemBase)navItem.Tag);
        }
        void navigationBar_SelectedItemChanging(object sender, SelectedItemChangingEventArgs e) {
            e.Cancel = (e.Item == allFoldersItem);
        }
        void BindItems() {
            foreach(FilterItemBase item in ViewModel.StaticFilters)
                RegisterFilterItem(OfficeNavigationBar, item);
            RegisterAllFoldersItem(OfficeNavigationBar);
        }
        void UpdateSelectedItemByFilter(FilterItemBase item) {
            var result = OfficeNavigationBar.Items.FirstOrDefault(navItem => object.Equals(navItem.Tag, item));
            if(result != null)
                OfficeNavigationBar.SelectedItem = result;
        }
        void RegisterFilterItem(OfficeNavigationBar navigationBar, FilterItemBase item) {
            NavigationBarItem navItem = new NavigationBarItem();
            navItem.Tag = item;
            navItem.Text = ViewModel.GetFilterName(ViewModel.StaticFilters, item);
            navItem.Name = "filterItem" + item.Name.Replace(" ", string.Empty);
            navigationBar.Items.Add(navItem);
            navItem.BindCommand((f) => ViewModel.Select(f), ViewModel, () => (item as FilterTreeViewModel<TEntity, TID, TUnitOfWork>.FilterItem));
        }
        NavigationBarItem allFoldersItem;
        void RegisterAllFoldersItem(OfficeNavigationBar navigationBar) {
            allFoldersItem = new NavigationBarItem();
            allFoldersItem.Text = "All Folders";
            allFoldersItem.Name = "itemAllFolders";
            navigationBar.Items.Add(allFoldersItem);
            BindAllFoldersItem(allFoldersItem);
        }
        protected abstract void BindAllFoldersItem(NavigationBarItem allFoldersItem);
    }
}