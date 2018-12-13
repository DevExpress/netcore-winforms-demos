namespace DevExpress.DevAV.Modules {
    using System;
    using System.Linq;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraMap;
    using DevExpress.XtraMap.Services;

    public partial class QuoteMapView : BaseModuleControl, IRibbonModule {
        public QuoteMapView()
            : base(typeof(QuoteMapViewModel)) {
            InitializeComponent();
            ViewModel.StageChanged += ViewModel_StageChanged;
            BindCommands();
            BindMap();
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.StageChanged -= ViewModel_StageChanged;
        }
        protected override void OnDisposing() {
            LookAndFeel.StyleChanged -= LookAndFeel_StyleChanged;
            ItemsLayer.DataLoaded -= ItemsLayer_DataLoaded;
            base.OnDisposing();
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            UpdateColors();
        }
        public QuoteMapViewModel ViewModel {
            get { return GetViewModel<QuoteMapViewModel>(); }
        }
        public QuoteCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<QuoteCollectionViewModel>(); }
        }
        void BindCommands() {
            //Save & Close
            biSave.BindCommand(() => ViewModel.Save(), ViewModel);
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
            biSaveAndClose.BindCommand(() => ViewModel.SaveAndClose(), ViewModel);
            //Delete
            biDelete.BindCommand(() => ViewModel.Delete(), ViewModel);
            //
            biHigh.BindCommand(() => ViewModel.SetHighStage(), ViewModel);
            biMedium.BindCommand(() => ViewModel.SetMediumStage(), ViewModel);
            biLow.BindCommand(() => ViewModel.SetLowStage(), ViewModel);
            biUnlikely.BindCommand(() => ViewModel.SetUnlikelyStage(), ViewModel);
            //
            biPrint.ItemClick += (s, e) => mapControl.Print();
            biPrintPreview.ItemClick += (s, e) => mapControl.ShowRibbonPrintPreview();
            barExportItem.ItemClick += (s, e) => mapControl.Export("Opportunities.Map.png");
        }
        void UpdateColors() {
            var moduleLocator = GetService<Services.IModuleLocator>();
            if(moduleLocator == null || !moduleLocator.IsModuleLoaded(ModuleType.QuoteView))
                return;
            QuoteView quoteView = moduleLocator.GetModule(ModuleType.QuoteView) as QuoteView;
            if(ViewModel != null)
                ItemsLayer.ItemStyle.Fill = quoteView.GetStageColor(ViewModel.Stage);
        }
        protected override void OnParentViewModelAttached() {
            UpdateColors();
            UpdateOpportunities();
        }
        IZoomToRegionService zoomService;
        void BindMap() {
            TilesProvider.BingKey = MapViewModelBase.WinBingKey;
            this.zoomService = ((IServiceProvider)mapControl).GetService(typeof(IZoomToRegionService)) as IZoomToRegionService;
            mapControl.SelectionMode = ElementSelectionMode.Single;
            mapControl.SelectionChanged += mapControl_SelectionChanged;
        }
        ImageLayer TilesLayer { get { return (ImageLayer)(mapControl.Layers[0]); } }
        VectorItemsLayer ItemsLayer { get { return (VectorItemsLayer)(mapControl.Layers[1]); } }
        VectorItemsLayer CalloutLayer { get { return (VectorItemsLayer)(mapControl.Layers[2]); } }
        BingMapDataProvider TilesProvider { get { return (BingMapDataProvider)TilesLayer.DataProvider; } }
        BubbleChartDataAdapter BubbleChartDataAdapter { get { return (BubbleChartDataAdapter)ItemsLayer.Data; } }
        MapCallout Callout { get { return ((MapCallout)CalloutLayer.Data.GetItem(0)); } }
        void ViewModel_StageChanged(object sender, EventArgs e) {
            UpdateColors();
            UpdateOpportunities();
        }
        void UpdateOpportunities() {
            ribbonControl.ApplicationDocumentCaption = "Opportunities";
            if(CollectionViewModel != null) {
                BubbleChartDataAdapter.DataSource = CollectionViewModel.GetOpportunities(ViewModel.Stage);
                zoomService.ZoomTo(CollectionViewModel.GetAddresses(ViewModel.Stage));
            }
        }
        void mapControl_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            var dataItem = e.Selection.FirstOrDefault() as QuoteMapItem;
            if(dataItem != null) {
                Callout.Location = dataItem.Address.ToGeoPoint();
                var total = CollectionViewModel.GetOpportunity(ViewModel.Stage, dataItem.Address.City);
                Callout.Text = string.Format("TOTAL<br><color=206,113,0><b><size=+4>{0:c}</color></size></b><br>{1}", total, dataItem.Address.City);
            }
        }
        void ItemsLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            var mapItem = ItemsLayer.Data.Items.FirstOrDefault();
            ItemsLayer.SelectedItem = (mapItem != null) ? ItemsLayer.Data.GetItemSourceObject(mapItem) : null;
        }
        #region
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
    }
}