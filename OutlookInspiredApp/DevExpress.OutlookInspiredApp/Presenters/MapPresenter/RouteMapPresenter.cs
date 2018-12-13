namespace DevExpress.DevAV.Presenters {
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraMap;
    using DevExpress.XtraMap.Services;

    public abstract class RouteMapPresenter<TEntity, TViewModel> : BasePresenter<TViewModel>
        where TEntity : class
        where TViewModel : class, IRouteMapViewModel {
        MapControl mapControlCore;
        Action<TEntity> updateUIActionCore;
        Action<List<RoutePoint>> updateRouteListActionCore;
        public RouteMapPresenter(MapControl mapControl, TViewModel viewModel, Action<TEntity> updateUIAction, Action<List<RoutePoint>> updateRouteList)
            : base(viewModel) {
            this.mapControlCore = mapControl;
            this.updateUIActionCore = updateUIAction;
            this.updateRouteListActionCore = updateRouteList;
            if(MapControl != null) {
                BindMap();
                SubscribeRouteProviderEvents();
            }
            SubscribeViewModelEvents();
        }
        protected override void OnDisposing() {
            if(MapControl != null)
                UnsubscribeRouteProviderEvents();
            UnsubscribeViewModelEvents();
            this.updateUIActionCore = null;
            this.updateRouteListActionCore = null;
            this.mapControlCore = null;
            base.OnDisposing();
        }
        public MapControl MapControl {
            get { return mapControlCore; }
        }
        protected ImageLayer TilesLayer {
            get { return (ImageLayer)(MapControl.Layers[0]); }
        }
        protected InformationLayer GeoCodeLayer {
            get { return (InformationLayer)(MapControl.Layers[1]); }
        }
        protected InformationLayer RouteLayer {
            get { return (InformationLayer)(MapControl.Layers[3]); }
        }
        protected BingMapDataProvider TilesProvider {
            get { return (BingMapDataProvider)TilesLayer.DataProvider; }
        }
        protected BingGeocodeDataProvider GeoCodeProvider {
            get { return (BingGeocodeDataProvider)GeoCodeLayer.DataProvider; }
        }
        protected BingRouteDataProvider RouteProvider {
            get { return (BingRouteDataProvider)RouteLayer.DataProvider; }
        }
        IZoomToRegionService zoomService;
        void BindMap() {
            TilesProvider.BingKey = MapViewModelBase.WinBingKey;
            RouteProvider.BingKey = MapViewModelBase.WinBingKey;
            GeoCodeProvider.BingKey = MapViewModelBase.WinBingKey;
            //
            this.zoomService = ((IServiceProvider)MapControl).GetService(typeof(IZoomToRegionService)) as IZoomToRegionService;
        }
        protected virtual void SubscribeRouteProviderEvents() {
            GeoCodeProvider.LocationInformationReceived += GeoCodeProvider_LocationInformationReceived;
            RouteProvider.RouteCalculated += RouteProvider_RouteCalculated;
            RouteProvider.LayerItemsGenerating += RouteProvider_LayerItemsGenerating;
        }
        protected virtual void SubscribeViewModelEvents() {
            ViewModel.UpdateRoute += ViewModel_UpdateRoute;
            ViewModel.PointAChanged += ViewModel_PointAChanged;
            ViewModel.PointBChanged += ViewModel_PointBChanged;
            ViewModel.TravelModeChanged += ViewModel_TravelModeChanged;
        }
        protected virtual void UnsubscribeRouteProviderEvents() {
            GeoCodeProvider.LocationInformationReceived -= GeoCodeProvider_LocationInformationReceived;
            RouteProvider.RouteCalculated -= RouteProvider_RouteCalculated;
            RouteProvider.LayerItemsGenerating -= RouteProvider_LayerItemsGenerating;
        }
        protected virtual void UnsubscribeViewModelEvents() {
            ViewModel.UpdateRoute -= ViewModel_UpdateRoute;
            ViewModel.PointAChanged -= ViewModel_PointAChanged;
            ViewModel.PointBChanged -= ViewModel_PointBChanged;
            ViewModel.TravelModeChanged -= ViewModel_TravelModeChanged;
        }
        void ViewModel_UpdateRoute(object sender, EventArgs e) {
            UpdateUI(GetViewModelEntity());
        }
        protected void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            UpdateUI(GetViewModelEntity());
        }
        protected abstract TEntity GetViewModelEntity();
        void ViewModel_TravelModeChanged(object sender, System.EventArgs e) {
            RouteProvider.RouteOptions.Mode = ViewModel.TravelMode;
            UpdateRoute();
        }
        MapPushpin PointAPin { get; set; }
        void ViewModel_PointAChanged(object sender, System.EventArgs e) {
            if(PointAPin == null)
                PointAPin = new MapPushpin() { Text = "A" };
            PointAPin.Location = ViewModel.PointA.ToGeoPoint();
        }
        MapPushpin PointBPin { get; set; }
        void ViewModel_PointBChanged(object sender, System.EventArgs e) {
            if(PointBPin == null)
                PointBPin = new MapPushpin() { Text = "B" };
            PointBPin.Location = ViewModel.PointB.ToGeoPoint();
        }
        void RouteProvider_RouteCalculated(object sender, BingRouteCalculatedEventArgs e) {
            if(e.Error != null || e.Cancelled || e.CalculationResult == null || e.CalculationResult.ResultCode != RequestResultCode.Success)
                return;
            ProcessRouteResult(e.CalculationResult.RouteResults[0]);
        }
        void GeoCodeProvider_LocationInformationReceived(object sender, LocationInformationReceivedEventArgs e) {
            if(e.Error != null || e.Cancelled || e.Result == null || e.Result.ResultCode != RequestResultCode.Success)
                return;
            LocationInformation[] locations = e.Result.Locations;
            if(locations.Length > 0) {
                LocationInformation loc = locations[0];
                ViewModel.PointB = new Address()
                {
                    Line = loc.Address.FormattedAddress,
                    Latitude = loc.Location.Latitude,
                    Longitude = loc.Location.Longitude,
                };
            }
        }
        void RouteProvider_LayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            var items = args.Items;
            for(int i = 0; i < items.Length; i++) {
                MapPushpin pushpin = items[i] as MapPushpin;
                if(pushpin != null)
                    pushpin.Visible = false;
            }
            AddRoutePoints();
        }
        void AddRoutePoints() {
            RouteLayer.Data.Items.Clear();
            RouteLayer.Data.Items.Add(PointAPin);
            RouteLayer.Data.Items.Add(PointBPin);
        }
        void ProcessRouteResult(BingRouteResult routeResult) {
            ViewModel.RouteDistance = routeResult.Distance;
            ViewModel.RouteTime = routeResult.Time;
            List<RoutePoint> routePoints = new List<RoutePoint>();
            foreach(BingRouteLeg leg in routeResult.Legs)
                foreach(BingItineraryItem item in leg.Itinerary)
                    routePoints.Add(new RoutePoint(item));
            UpdateRouteList(routePoints);
            zoomService.ZoomTo(ViewModel.PointA, ViewModel.PointB);
        }
        void UpdateRouteList(List<RoutePoint> routePoints) {
            if(updateRouteListActionCore != null)
                updateRouteListActionCore(routePoints);
        }
        void UpdateRoute() {
            List<RouteWaypoint> points = new List<RouteWaypoint>();
            points.Add(new RouteWaypoint("Point A", ViewModel.PointA.ToGeoPoint()));
            points.Add(new RouteWaypoint("Point B", ViewModel.PointB.ToGeoPoint()));
            RouteProvider.CalculateRoute(points);
        }
        void UpdateUI(TEntity entity) {
            if(entity == null) return;
            if(updateUIActionCore != null)
                updateUIActionCore(entity);
            MapControl.CenterPoint = ViewModel.PointA.ToGeoPoint();
            AddRoutePoints();
            UpdateRoute();
        }
    }
    public sealed class RoutePoint {
        static Regex removeTagRegex = new Regex(@"<[^>]*>", RegexOptions.Compiled);
        BingItineraryItem item;
        public RoutePoint(BingItineraryItem item) {
            this.item = item;
            ManeuverInstruction = removeTagRegex.Replace(item.ManeuverInstruction, string.Empty);
            double itemDistance = item.Distance;
            Distance = (itemDistance > 0.9) ?
                String.Format("{0:0} mi", Math.Ceiling(itemDistance)) :
                String.Format("{0:0} ft", Math.Ceiling(itemDistance * 52.8) * 100);
        }
        public BingManeuverType Maneuver {
            get { return item.Maneuver; }
        }
        public string ManeuverInstruction {
            get;
            private set;
        }
        public string Distance {
            get;
            private set;
        }
    }
}