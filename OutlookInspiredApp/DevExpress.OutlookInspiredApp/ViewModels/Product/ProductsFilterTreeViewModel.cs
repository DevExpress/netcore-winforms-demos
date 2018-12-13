namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.DevAV.Properties;
    using DevExpress.Mvvm.POCO;

    public class ProductsFilterTreeViewModel : FilterTreeViewModel<Product, long, IDevAVDbUnitOfWork> {
        public static ProductsFilterTreeViewModel Create(ProductCollectionViewModel collectionViewModel) {
            return ViewModelSource.Create(() => new ProductsFilterTreeViewModel(collectionViewModel));
        }
        protected ProductsFilterTreeViewModel(ProductCollectionViewModel collectionViewModel)
            : base(collectionViewModel, new FilterTreeModelPageSpecificSettings<Settings>(Settings.Default, StaticFiltersName, x => x.ProductsStaticFilters, x => x.ProductsCustomFilters, x => x.ProductsGroupFilters)) {
        }
        protected new ProductCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as ProductCollectionViewModel; }
        }
    }
}