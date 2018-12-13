namespace DevExpress.DevAV.Modules {
    using System.Collections.Generic;
    using DevExpress.DevAV.ViewModels;

    public partial class QuoteView : BaseModuleControl {
        public QuoteView()
            : base(typeof(SynchronizedQuoteViewModel)) {
            InitializeComponent();
        }
        public QuoteViewModel ViewModel {
            get { return GetViewModel<QuoteViewModel>(); }
        }
        public IList<QuoteMapItem> DataSource {
            get { return chartControl.DataSource as IList<QuoteMapItem>; }
            set {
                chartControl.DataSource = value;
                if(value != null) {
                    chartControl.Series[0].ArgumentDataMember = "Name";
                    chartControl.Series[0].ValueDataMembers.AddRange(new string[] { "Value" });
                }
            }
        }
        protected internal System.Drawing.Color GetStageColor(Stage stage) {
            var values = System.Enum.GetValues(typeof(Stage));
            var entries = chartControl.GetPaletteEntries(values.Length);
            return entries[System.Array.IndexOf(values, stage)].Color;
        }
    }
}