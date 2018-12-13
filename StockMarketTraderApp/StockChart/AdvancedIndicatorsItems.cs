using DevExpress.XtraCharts;

namespace DevExpress.StockMarketTrader {
    public class MedianPriceItem : CheckedIndicatorItem {
        protected override string Name { get { return "Median Price"; } }

        protected override Indicator CreateIndicator() {
            return new MedianPrice();
        }
    }

    public class TypicalPriceItem : CheckedIndicatorItem {
        protected override string Name { get { return "Typical Price"; } }

        protected override Indicator CreateIndicator() {
            return new TypicalPrice();
        }
    }

    public class WeightedCloseItem : CheckedIndicatorItem {
        protected override string Name { get { return "Weighted Close"; } }

        protected override Indicator CreateIndicator() {
            return new WeightedClose();
        }
    }

    public class AverageTrueRangeItem : CheckedIndicatorItem {
        protected override string Name { get { return "Average True Range"; } }

        protected override Indicator CreateIndicator() {
            return new AverageTrueRange();
        }
    }

    public class CommodityChannelIndexItem : CheckedIndicatorItem {
        protected override string Name { get { return "Commodity Channel Index"; } }

        protected override Indicator CreateIndicator() {
            return new CommodityChannelIndex();
        }
    }

    public class DetrendedPriceOscillatorItem : CheckedIndicatorItem {
        protected override string Name { get { return "Detrended Price Oscillator"; } }

        protected override Indicator CreateIndicator() {
            return new DetrendedPriceOscillator();
        }
    }

    public class MassIndexItem : CheckedIndicatorItem {
        protected override string Name { get { return "Mass Index"; } }

        protected override Indicator CreateIndicator() {
            return new MassIndex();
        }
    }

    public class MovingAverageConvergenceDivergenceItem : CheckedIndicatorItem {
        protected override string Name { get { return "Moving Average Convergence Divergence"; } }

        protected override Indicator CreateIndicator() {
            return new MovingAverageConvergenceDivergence();
        }
    }

    public class RateOfChangeItem : CheckedIndicatorItem {
        protected override string Name { get { return "Rate Of Change"; } }

        protected override Indicator CreateIndicator() {
            return new RateOfChange();
        }
    }

    public class RelativeStrengthIndexItem : CheckedIndicatorItem {
        protected override string Name { get { return "Relative Strength Index"; } }

        protected override Indicator CreateIndicator() {
            return new RelativeStrengthIndex();
        }
    }

    public class StandardDeviationItem : CheckedIndicatorItem {
        protected override string Name { get { return "Standard Deviation"; } }

        protected override Indicator CreateIndicator() {
            return new StandardDeviation();
        }
    }

    public class ChaikinsVolatilityItem : CheckedIndicatorItem {
        protected override string Name { get { return "Chaikins Volatility"; } }

        protected override Indicator CreateIndicator() {
            return new ChaikinsVolatility();
        }
    }

    public class WilliamsRItem : CheckedIndicatorItem {
        protected override string Name { get { return "Williams %R"; } }

        protected override Indicator CreateIndicator() {
            return new WilliamsR();
        }
    }
}
