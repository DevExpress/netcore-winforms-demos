namespace DevExpress.DevAV.Presenters {
    using System;
    using System.Linq;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraMap;
    using DevExpress.XtraMap.Services;

    public abstract class SalesMapPresenter<TEntity, TViewModel> : BasePresenter<TViewModel>
        where TEntity : class
        where TViewModel : class, ISalesMapViewModel {
        MapControl mapControlCore;
        Action<TEntity> updateUIActionCore;
        Action<DevAV.MapItem> updateChartActionCore;
        public SalesMapPresenter(MapControl mapControl, TViewModel viewModel, Action<TEntity> updateUIAction, Action<DevAV.MapItem> updateChartAction)
            : base(viewModel) {
            this.mapControlCore = mapControl;
            this.updateUIActionCore = updateUIAction;
            this.updateChartActionCore = updateChartAction;
            if(MapControl != null) {
                BindMap();
                SubscribeMapEvents();
            }
            SubscribeViewModelEvents();
        }
        protected override void OnDisposing() {
            if(MapControl != null)
                UnsubscribeMapEvents();
            UnsubscribeViewModelEvents();
            this.updateUIActionCore = null;
            this.mapControlCore = null;
            base.OnDisposing();
        }
        public MapControl MapControl {
            get { return mapControlCore; }
        }
        protected ImageLayer TilesLayer {
            get { return (ImageLayer)(MapControl.Layers[0]); }
        }
        protected VectorItemsLayer ItemsLayer {
            get { return (VectorItemsLayer)(MapControl.Layers[1]); }
        }
        protected BingMapDataProvider TilesProvider {
            get { return (BingMapDataProvider)TilesLayer.DataProvider; }
        }
        protected PieChartDataAdapter PieChartDataAdapter {
            get { return (PieChartDataAdapter)ItemsLayer.Data; }
        }
        public KeyColorColorizer PieChartColorizer {
            get { return (KeyColorColorizer)ItemsLayer.Colorizer; }
        }
        IZoomToRegionService zoomServiceCore;
        protected IZoomToRegionService ZoomService {
            get { return zoomServiceCore; }
        }
        void BindMap() {
            TilesProvider.BingKey = MapViewModelBase.WinBingKey;
            this.zoomServiceCore = ((IServiceProvider)MapControl).GetService(typeof(IZoomToRegionService)) as IZoomToRegionService;
        }
        protected virtual void SubscribeMapEvents() {
            MapControl.SelectionChanged += MapControl_SelectionChanged;
            ItemsLayer.DataLoaded += ItemsLayer_DataLoaded;
        }
        protected virtual void UnsubscribeMapEvents() {
            MapControl.SelectionChanged -= MapControl_SelectionChanged;
            ItemsLayer.DataLoaded -= ItemsLayer_DataLoaded;
        }
        protected virtual void SubscribeViewModelEvents() {
            ViewModel.PeriodChanged += ViewModel_PeriodChanged;
        }
        protected virtual void UnsubscribeViewModelEvents() {
            ViewModel.PeriodChanged -= ViewModel_PeriodChanged;
        }
        void MapControl_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            DevAV.MapItem salesItem = ItemsLayer.SelectedItem as DevAV.MapItem;
            if(salesItem == null)
                return;
            if(updateChartActionCore != null)
                updateChartActionCore(salesItem);
        }
        void ItemsLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            var mapItem = ItemsLayer.Data.Items.FirstOrDefault();
            ItemsLayer.SelectedItem = (mapItem != null) ? ItemsLayer.Data.GetItemSourceObject(mapItem) : null;
        }
        protected void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            UpdateUI(GetViewModelEntity());
        }
        void ViewModel_PeriodChanged(object sender, EventArgs e) {
            UpdateSales();
        }
        void UpdateUI(TEntity entity) {
            if(updateUIActionCore != null)
                updateUIActionCore(entity);
            UpdateSales();
        }
        protected abstract TEntity GetViewModelEntity();
        protected abstract void UpdateSales();
    }
}