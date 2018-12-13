namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;

    public class CollectionUIViewModel {
        #region ViewKind
        public virtual CollectionViewKind ViewKind { get; set; }
        [Command]
        public void ShowCard() {
            ViewKind = CollectionViewKind.CardView;
        }
        public bool CanShowCard() {
            return ViewKind != CollectionViewKind.CardView;
        }
        [Command]
        public void ShowList() {
            ViewKind = CollectionViewKind.ListView;
        }
        public bool CanShowList() {
            return ViewKind != CollectionViewKind.ListView;
        }
        [Command]
        public void ShowCarousel() {
            ViewKind = CollectionViewKind.Carousel;
        }
        public bool CanShowCarousel() {
            return ViewKind != CollectionViewKind.Carousel;
        }
        [Command]
        public void ShowMasterDetail() {
            ViewKind = CollectionViewKind.MasterDetailView;
        }
        public bool CanShowMasterDetail() {
            return ViewKind != CollectionViewKind.MasterDetailView;
        }
        protected virtual void OnViewKindChanged() {
            this.RaiseCanExecuteChanged(x => x.ShowList());
            this.RaiseCanExecuteChanged(x => x.ShowCard());
            this.RaiseCanExecuteChanged(x => x.ShowCarousel());
            this.RaiseCanExecuteChanged(x => x.ShowMasterDetail());
            this.RaiseCanExecuteChanged(x => x.ResetView());
            RaiseViewKindChanged();
        }
        #endregion
        #region ViewLayout
        public virtual CollectionViewMasterDetailLayout ViewLayout { get; set; }
        public bool IsDetailHidden {
            get { return ViewLayout == CollectionViewMasterDetailLayout.DetailHidden; }
        }
        public bool IsHorizontalLayout {
            get { return ViewLayout == CollectionViewMasterDetailLayout.Horizontal; }
        }
        [Command]
        public void ShowHorizontalLayout() {
            ViewLayout = CollectionViewMasterDetailLayout.Horizontal;
        }
        public bool CanShowHorizontalLayout() {
            return ViewLayout != CollectionViewMasterDetailLayout.Horizontal;
        }
        [Command]
        public void ShowVerticalLayout() {
            ViewLayout = CollectionViewMasterDetailLayout.Vertical;
        }
        public bool CanShowVerticalLayout() {
            return ViewLayout != CollectionViewMasterDetailLayout.Vertical;
        }
        [Command]
        public void HideDetail() {
            ViewLayout = CollectionViewMasterDetailLayout.DetailHidden;
        }
        public bool CanHideDetail() {
            return ViewLayout != CollectionViewMasterDetailLayout.DetailHidden;
        }
        protected virtual void OnViewLayoutChanged() {
            this.RaiseCanExecuteChanged(x => x.ShowHorizontalLayout());
            this.RaiseCanExecuteChanged(x => x.ShowVerticalLayout());
            this.RaiseCanExecuteChanged(x => x.HideDetail());
            this.RaiseCanExecuteChanged(x => x.ResetView());
            RaiseViewLayoutChanged();
        }
        #endregion
        #region Reset
        public CollectionViewKind DefaultViewKind { get; set; }
        public CollectionViewMasterDetailLayout DefaultViewLayout { get; set; }
        [Command]
        public void ResetView() {
            ViewKind = DefaultViewKind;
            ViewLayout = DefaultViewLayout;
        }
        public bool CanResetView() {
            return 
                (ViewKind != DefaultViewKind) || 
                (ViewLayout != DefaultViewLayout);
        }
        #endregion
        public event EventHandler ViewKindChanged;
        public event EventHandler ViewLayoutChanged;
        void RaiseViewKindChanged() {
            EventHandler handler = ViewKindChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        void RaiseViewLayoutChanged() {
            EventHandler handler = ViewLayoutChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}