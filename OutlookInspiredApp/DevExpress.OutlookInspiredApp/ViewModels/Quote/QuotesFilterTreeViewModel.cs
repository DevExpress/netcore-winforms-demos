namespace DevExpress.DevAV.ViewModels {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.DevAVDbDataModel;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.DevAV.Properties;
    using DevExpress.Mvvm.POCO;

    public class QuotesFilterTreeViewModel : FilterTreeViewModel<Quote, long, IDevAVDbUnitOfWork> {
        public static QuotesFilterTreeViewModel Create(QuoteCollectionViewModel collectionViewModel) {
            return ViewModelSource.Create(() => new QuotesFilterTreeViewModel(collectionViewModel));
        }
        protected QuotesFilterTreeViewModel(QuoteCollectionViewModel collectionViewModel)
            : base(collectionViewModel, new FilterTreeModelPageSpecificSettings<Settings>(Settings.Default, StaticFiltersName, x => x.QuotesStaticFilters, x => x.QuotesCustomFilters, x => x.QuotesGroupFilters)) {
        }
        protected new QuoteCollectionViewModel CollectionViewModel {
            get { return base.CollectionViewModel as QuoteCollectionViewModel; }
        }
        protected override bool EnableGroups {
            get { return false; }
        }
    }
}