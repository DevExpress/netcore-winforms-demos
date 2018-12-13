using DevExpress.XtraCharts;

namespace DevExpress.StockMarketTrader {
    public abstract class IndicatorItem {
        protected abstract string Name { get; }

        protected abstract Indicator CreateIndicator();
        public override string ToString() {
            return Name;
        }
    }

    public abstract class CheckedIndicatorItem : IndicatorItem {
        bool indicatorVisible;

        protected virtual string IndicatorName { get { return Name; } }

        public void UpdateIndicator(ChartControl chart, XYDiagramSeriesViewBase seriesView, bool indicatorVisible) {
            if (this.indicatorVisible != indicatorVisible) {
                if (indicatorVisible) {
                    Indicator indicator = CreateIndicator();
                    if (indicator != null) {
                        indicator.Tag = GetHashCode();
                        indicator.Name = IndicatorName;
                        indicator.ShowInLegend = true;
                        seriesView.Indicators.Add(indicator);
                        if (indicator is SeparatePaneIndicator)
                            ChartHelper.InitializeSeparatePaneIndicator(chart, (SeparatePaneIndicator)indicator);
                    }
                }
                else {
                    int tag = GetHashCode();
                    foreach (Indicator indicator in seriesView.Indicators) {
                        if (indicator.Tag is int && (int)indicator.Tag == tag) {
                            ChartHelper.RemoveIndicator(chart, seriesView, indicator);
                            break;
                        }
                    }
                }
                this.indicatorVisible = indicatorVisible;
            }
        }
    }
}
