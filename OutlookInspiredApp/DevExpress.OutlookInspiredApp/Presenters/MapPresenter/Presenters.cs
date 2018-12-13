namespace DevExpress.DevAV.Presenters {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraMap;

    public class EmployeeRouteMapPresenter : RouteMapPresenter<Employee, EmployeeMapViewModel> {
        public EmployeeRouteMapPresenter(MapControl mapControl, EmployeeMapViewModel viewModel, Action<Employee> updateUIAction, Action<List<RoutePoint>> updateRouteList) :
            base(mapControl, viewModel, updateUIAction, updateRouteList) {
        }
        protected override void SubscribeViewModelEvents() {
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            base.SubscribeViewModelEvents();
        }
        protected override void UnsubscribeViewModelEvents() {
            base.UnsubscribeViewModelEvents();
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override Employee GetViewModelEntity() {
            return ViewModel.Entity;
        }
    }
    public class OrderRouteMapPresenter : RouteMapPresenter<Order, OrderMapViewModel> {
        public OrderRouteMapPresenter(MapControl mapControl, OrderMapViewModel viewModel, Action<Order> updateUIAction) :
            base(mapControl, viewModel, updateUIAction, null) {
        }
        protected override void SubscribeViewModelEvents() {
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            base.SubscribeViewModelEvents();
        }
        protected override void UnsubscribeViewModelEvents() {
            base.UnsubscribeViewModelEvents();
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override Order GetViewModelEntity() {
            return ViewModel.Entity;
        }
    }
    //
    public class CustomerSalesMapPresenter : SalesMapPresenter<Customer, CustomerMapViewModel> {
        public CustomerSalesMapPresenter(MapControl mapControl, CustomerMapViewModel viewModel, Action<Customer> updateUIAction, Action<DevAV.MapItem> updateChartAction) :
            base(mapControl, viewModel, updateUIAction, updateChartAction) {
        }
        protected override void SubscribeViewModelEvents() {
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            base.SubscribeViewModelEvents();
        }
        protected override void UnsubscribeViewModelEvents() {
            base.UnsubscribeViewModelEvents();
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override Customer GetViewModelEntity() {
            return ViewModel.Entity;
        }
        protected override void UpdateSales() {
            ZoomService.ZoomTo(ViewModel.GetSalesStores(ViewModel.Period).Select(s => s.Address));
            PieChartDataAdapter.DataSource = ViewModel.GetSales(ViewModel.Period).ToList();
        }
    }
    public class ProductSalesMapPresenter : SalesMapPresenter<Product, ProductMapViewModel> {
        public ProductSalesMapPresenter(MapControl mapControl, ProductMapViewModel viewModel, Action<Product> updateUIAction, Action<DevAV.MapItem> updateChartAction) :
            base(mapControl, viewModel, updateUIAction, updateChartAction) {
        }
        protected override void SubscribeViewModelEvents() {
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            base.SubscribeViewModelEvents();
        }
        protected override void UnsubscribeViewModelEvents() {
            base.UnsubscribeViewModelEvents();
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override Product GetViewModelEntity() {
            return ViewModel.Entity;
        }
        protected override void UpdateSales() {
            ZoomService.ZoomTo(ViewModel.GetSalesStores(ViewModel.Period).Select(s => s.Address));
            PieChartDataAdapter.DataSource = ViewModel.GetSales(ViewModel.Period).ToList();
        }
    }
}