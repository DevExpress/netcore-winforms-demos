namespace DevExpress.DevAV.ViewModels {
    using System;
    using System.Drawing;
    using DevExpress.DevAV;
    using DevExpress.Mvvm.DataAnnotations;
    using DevExpress.Mvvm.POCO;
    using DevExpress.XtraMap;

    public class EmployeeMapViewModel : EmployeeViewModel, IRouteMapViewModel {
        public virtual BingTravelMode TravelMode { get; set; }
        [Command]
        public void SetDrivingTravelMode() {
            TravelMode = BingTravelMode.Driving;
        }
        public bool CanSetDrivingTravelMode() {
            return TravelMode != BingTravelMode.Driving;
        }
        [Command]
        public void SetWalkingTravelMode() {
            TravelMode = BingTravelMode.Walking;
        }
        public bool CanSetWalkingTravelMode() {
            return TravelMode != BingTravelMode.Walking;
        }
        protected virtual void OnTravelModeChanged() {
            this.RaiseCanExecuteChanged(x => x.SetDrivingTravelMode());
            this.RaiseCanExecuteChanged(x => x.SetWalkingTravelMode());
            RaiseTravelModeChanged();
        }
        public event EventHandler TravelModeChanged;
        void RaiseTravelModeChanged() {
            EventHandler handler = TravelModeChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        [Command]
        public void SwapRoutePoints() {
            Address a = PointA;
            PointA = PointB;
            PointB = a;
            RaiseUpdateRoute();
        }
        public string FullName {
            get { return (Entity != null) ? Entity.FullNameBindable : null; }
        }
        public string AddressLine1 {
            get { return (Entity != null) ? Entity.Address.Line : null; }
        }
        public string AddressLine2 {
            get { return (Entity != null) ? Entity.Address.CityLine : null; }
        }
        public Image Picture {
            get { return (Entity != null) ? Entity.Photo : null; }
        }
        public string PointAAddress {
            get { return (PointA != null) ? PointA.ToString() : null; }
        }
        public string PointBAddress {
            get { return (PointB != null) ? PointB.ToString() : null; }
        }
        public virtual string RouteResult {
            get {
                return string.Format("{0:F1} mi, {1:hh\\:mm} min ", RouteDistance, RouteTime) +
                    ((TravelMode == BingTravelMode.Walking) ? "walking" : "driving");
            }
        }
        public virtual double RouteDistance { get; set; }
        protected virtual void OnRouteDistanceChanged() {
            this.RaisePropertyChanged(x => x.RouteResult);
        }
        public virtual TimeSpan RouteTime { get; set; }
        protected virtual void OnRouteTimeChanged() {
            this.RaisePropertyChanged(x => x.RouteResult);
        }
        protected override void OnEntityChanged() {
            PointA = AddressHelper.DevAVHomeOffice;
            PointB = (Entity != null) ? Entity.Address : AddressHelper.DevAVHomeOffice;
            this.RaisePropertyChanged(x => x.FullName);
            this.RaisePropertyChanged(x => x.Title);
            this.RaisePropertyChanged(x => x.PointA);
            this.RaisePropertyChanged(x => x.PointB);
            this.RaisePropertyChanged(x => x.AddressLine1);
            this.RaisePropertyChanged(x => x.AddressLine2);
            base.OnEntityChanged();
        }
        public virtual Address PointA { get; set; }
        protected virtual void OnPointAChanged() {
            this.RaisePropertyChanged(x => x.PointAAddress);
            RaisePointAChanged();
        }
        public virtual Address PointB { get; set; }
        protected virtual void OnPointBChanged() {
            this.RaisePropertyChanged(x => x.PointBAddress);
            RaisePointBChanged();
        }
        public event EventHandler PointAChanged;
        void RaisePointAChanged() {
            EventHandler handler = PointAChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        public event EventHandler PointBChanged;
        void RaisePointBChanged() {
            EventHandler handler = PointBChanged;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
        public event EventHandler UpdateRoute;
        void RaiseUpdateRoute() {
            EventHandler handler = UpdateRoute;
            if(handler != null)
                handler(this, EventArgs.Empty);
        }
    }
}