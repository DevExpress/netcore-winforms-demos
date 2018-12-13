namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.DevAV.Properties;
    using DevExpress.Mvvm.POCO;

    public class CustomersFilterTreeViewModel : FilterTreeViewModel<Customer, long, IDevAVDbUnitOfWork> {
        public static CustomersFilterTreeViewModel Create(CustomerCollectionViewModel collectionViewModel) {
            return ViewModelSource.Create(() => new CustomersFilterTreeViewModel(collectionViewModel));
        }
        protected CustomersFilterTreeViewModel(CustomerCollectionViewModel collectionViewModel)
            : base(collectionViewModel, new FilterTreeModelPageSpecificSettings<Settings>(Settings.Default, StaticFiltersName, x => x.CustomersStaticFilters, x => x.CustomersCustomFilters, x => x.CustomersGroupFilters)) {
        }
        protected new CustomerCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as CustomerCollectionViewModel; }
        }
    }
}