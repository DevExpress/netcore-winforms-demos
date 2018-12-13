namespace DevExpress.DevAV.ViewModels {
    using System.Collections.Generic;
    using System.Linq;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Mvvm;

    partial class ProductViewModel {
        public event System.EventHandler EntityChanged;
        protected override void OnEntityChanged() {
            base.OnEntityChanged();
            System.EventHandler handler = EntityChanged;
            if(handler != null)
                handler(this, System.EventArgs.Empty);
        }
        public IEnumerable<CustomerStore> GetSalesStores(Period period = Period.Lifetime) {
            return QueriesHelper.GetSalesStoresForPeriod(UnitOfWork.Orders, period);
        }
        public IEnumerable<DevAV.MapItem> GetSales(Period period = Period.Lifetime) {
            return QueriesHelper.GetSaleMapItems(UnitOfWork.OrderItems, Entity.Id, period);
        }
        public IEnumerable<DevAV.MapItem> GetSalesByCity(string city, Period period = Period.Lifetime) {
            return QueriesHelper.GetSaleMapItemsByCity(UnitOfWork.OrderItems, Entity.Id, city, period);
        }
        public override void Delete() {
            MessageBoxService.ShowMessage("To ensure data integrity, the Products module doesn't allow records to be deleted. Record deletion is supported by the Employees module.", "Delete Product", MessageButton.OK);
        }
    }
    public partial class SynchronizedProductViewModel : ProductViewModel {
        protected override bool EnableSelectedItemSynchronization {
            get { return true; }
        }
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
    }
}