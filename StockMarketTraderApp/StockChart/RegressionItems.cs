using DevExpress.XtraCharts;

namespace DevExpress.StockMarketTrader {
    public abstract class RegressionItem : CheckedIndicatorItem {
        protected override string Name { get { return IndicatorName + " Regression"; } }
    }

    public class LinearRegressionItem : RegressionItem {
        protected override string IndicatorName { get { return "Linear"; } }

        protected override Indicator CreateIndicator() {
            return new RegressionLine();
        }
    }
}
