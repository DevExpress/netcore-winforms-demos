namespace DevExpress.DevAV.ViewModels {
    partial class QuoteViewModel {
    }
    public partial class SynchronizedQuoteViewModel : QuoteViewModel {
        protected override bool EnableSelectedItemSynchronization {
            get { return true; }
        }
        protected override bool EnableEntityChangedSynchronization {
            get { return true; }
        }
    }
}