namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.DevAV.Properties;
    using DevExpress.Mvvm.POCO;

    public class OrdersFilterTreeViewModel : FilterTreeViewModel<Order, long, IDevAVDbUnitOfWork> {
        public static OrdersFilterTreeViewModel Create(OrderCollectionViewModel collectionViewModel) {
            return ViewModelSource.Create(() => new OrdersFilterTreeViewModel(collectionViewModel));
        }
        protected OrdersFilterTreeViewModel(OrderCollectionViewModel collectionViewModel)
            : base(collectionViewModel, new FilterTreeModelPageSpecificSettings<Settings>(Settings.Default, StaticFiltersName, x => x.OrdersStaticFilters, x => x.OrdersCustomFilters, x => x.OrdersGroupFilters)) {
        }
        protected new OrderCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as OrderCollectionViewModel; }
        }
        protected override bool EnableGroups {
            get { return false; }
        }
    }
}