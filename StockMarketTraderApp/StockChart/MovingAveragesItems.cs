using DevExpress.XtraCharts;

namespace DevExpress.StockMarketTrader {
    public abstract class MovingAverageItem : CheckedIndicatorItem {
        protected override string Name { get { return IndicatorName + " Moving Average"; } }

        protected abstract MovingAverage CreateMovingAverage();
        protected override Indicator CreateIndicator() {
            MovingAverage movingAverage = CreateMovingAverage();
            movingAverage.ValueLevel = ValueLevel.Close;
            return movingAverage;
        }
    }

    public class SimpleMovingAverageItem : MovingAverageItem {
        protected override string IndicatorName { get { return "Simple"; } }

        protected override MovingAverage CreateMovingAverage() {
            return new SimpleMovingAverage();
        }
    }

    public class ExponentialMovingAverageItem : MovingAverageItem {
        protected override string IndicatorName { get { return "Exponential"; } }

        protected override MovingAverage CreateMovingAverage() {
            return new ExponentialMovingAverage();
        }
    }

    public class TripleExponentialMovingAverageItem : MovingAverageItem {
        protected override string IndicatorName { get { return "Triple Exponential"; } }

        protected override MovingAverage CreateMovingAverage() {
            return new TripleExponentialMovingAverageTema();
        }
    }

    public class TriangularMovingAverageItem : MovingAverageItem {
        protected override string IndicatorName { get { return "Triangular"; } }

        protected override MovingAverage CreateMovingAverage() {
            return new TriangularMovingAverage();
        }
    }

    public class WeightedMovingAverageItem : MovingAverageItem {
        protected override string IndicatorName { get { return "Weighted"; } }

        protected override MovingAverage CreateMovingAverage() {
            return new WeightedMovingAverage();
        }
    }
}
