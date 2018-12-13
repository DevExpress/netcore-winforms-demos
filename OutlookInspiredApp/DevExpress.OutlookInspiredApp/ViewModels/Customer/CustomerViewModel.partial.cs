namespace DevExpress.DevAV.ViewModels {
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;

    partial class CustomerViewModel {
        public event System.EventHandler EntityChanged;
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            System.EventHandler handler = EntityChanged;
            if(handler != null)
                handler(this, System.EventArgs.Empty);
        }
        public IEnumerable<CustomerStore> GetSalesStores(Period period = Period.Lifetime) {
            return QueriesHelper.GetDistinctStoresForPeriod(UnitOfWork.Orders, Entity.Id, period);
        }
        public IEnumerable<DevAV.MapItem> GetSales(Period period = Period.Lifetime) {
            return QueriesHelper.GetSaleMapItemsByCustomer(UnitOfWork.OrderItems, Entity.Id, period);
        }
        public IEnumerable<DevAV.MapItem> GetSalesByCity(string city, Period period = Period.Lifetime) {
            return QueriesHelper.GetSaleMapItemsByCustomerAndCity(UnitOfWork.OrderItems, Entity.Id, city, period);
        }
        public override void Delete() {
            MessageBoxService.ShowMessage("To ensure data integrity, the Customers module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Customer", MessageButton.OK);
        }
    }
    public partial class SynchronizedCustomerViewModel : CustomerViewModel {
        protected override bool EnableSelectedItemSynchronization {
            get { return true; }
        }
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
    }
}