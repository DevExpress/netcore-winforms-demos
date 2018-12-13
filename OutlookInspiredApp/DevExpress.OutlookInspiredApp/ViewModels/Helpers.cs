namespace DevExpress.DevAV {
    using System;
    using System.Collections.Generic;
    using DevExpress.DevAV;
    using DevExpress.Map;
    using DevExpress.Mvvm;
    using DevExpress.DevAV.Modules;
    using DevExpress.XtraMap;

    public static class ViewModelHelper {
        public static TViewModel GetParentViewModel<TViewModel>(object viewModel) {
            ISupportParentViewModel parentViewModelSupport = viewModel as ISupportParentViewModel;
            if(parentViewModelSupport != null)
                return (TViewModel)parentViewModelSupport.ParentViewModel;
            return default(TViewModel);
        }
        public static void EnsureModuleViewModel(object module, object parentViewModel, object parameter = null) {
            ISupportViewModel vm = module as ISupportViewModel;
            if(vm != null) {
                object oldParentViewModel = null;
                ISupportParentViewModel parentViewModelSupport = vm.ViewModel as ISupportParentViewModel;
                if(parentViewModelSupport != null)
                    oldParentViewModel = parentViewModelSupport.ParentViewModel;
                EnsureViewModel(vm.ViewModel, parentViewModel, parameter);
                if(oldParentViewModel != parentViewModel)
                    vm.ParentViewModelAttached();
            }
        }
        public static void EnsureViewModel(object viewModel, object parentViewModel, object parameter = null) {
            ISupportParentViewModel parentViewModelSupport = viewModel as ISupportParentViewModel;
            if(parentViewModelSupport != null)
                parentViewModelSupport.ParentViewModel = parentViewModel;
            ISupportParameter parameterSupport = viewModel as ISupportParameter;
            if(parameterSupport != null && parameter != null)
                parameterSupport.Parameter = parameter;
        }
    }
    public static class AddressExtension {
        public static GeoPoint ToGeoPoint(this Address address) {
            return (address != null) ? new GeoPoint(address.Latitude, address.Longitude) : null;
        }
        public static void ZoomTo(this DevExpress.XtraMap.Services.IZoomToRegionService zoomService, IEnumerable<Address> addresses, double margin = 0.25) {
            GeoPoint ptA = null;
            GeoPoint ptB = null;
            foreach(var address in addresses) {
                if(ptA == null) {
                    ptA = address.ToGeoPoint();
                    ptB = address.ToGeoPoint();
                    continue;
                }
                GeoPoint pt = address.ToGeoPoint();
                if(pt == null || object.Equals(pt, new GeoPoint(0,0)))
                    continue;
                ptA.Latitude = Math.Min(ptA.Latitude, pt.Latitude);
                ptA.Longitude = Math.Min(ptA.Longitude, pt.Longitude);
                ptB.Latitude = Math.Max(ptB.Latitude, pt.Latitude);
                ptB.Longitude = Math.Max(ptB.Longitude, pt.Longitude);
            }
            ZoomCore(zoomService, ptA, ptB, margin);
        }
        public static void ZoomTo(this DevExpress.XtraMap.Services.IZoomToRegionService zoomService, Address pointA, Address pointB, double margin = 0.2) {
            ZoomCore(zoomService, pointA.ToGeoPoint(), pointB.ToGeoPoint(), margin);
        }
        static void ZoomCore(DevExpress.XtraMap.Services.IZoomToRegionService zoomService, GeoPoint ptA, GeoPoint ptB, double margin) {
            if(ptA == null || ptB == null || zoomService == null) return;
            double latPadding = CalculatePadding(ptB.Latitude - ptA.Latitude, margin);
            double longPadding = CalculatePadding(ptB.Longitude - ptA.Longitude, margin);
            zoomService.ZoomToRegion(
                  new GeoPoint(ptA.Latitude - latPadding, ptA.Longitude - longPadding),
                  new GeoPoint(ptB.Latitude + latPadding, ptB.Longitude + longPadding),
                  new GeoPoint(0.5 * (ptA.Latitude + ptB.Latitude), 0.5 * (ptA.Longitude + ptB.Longitude)));
        }
        static double CalculatePadding(double delta, double margin) {
            if(delta > 0)
                return Math.Max(0.1, delta * margin);
            if(delta < 0)
                return Math.Min(-0.1, delta * margin);
            return 0;
        }
    }
    public static class MapControlExtension {
        public static void Export(this MapControl mapControl, string path) {
            mapControl.ExportToImage(path, System.Drawing.Imaging.ImageFormat.Png);
            AppHelper.ProcessStart(path);
        }
    }
}