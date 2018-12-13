using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.StockMarketTrader {
    public partial class StockChartUC : UserControl {
        const string PriceSeriesName = "Price";
        const string VolumeSeriesName = "Volume";
        const int MinCandleCount = 20;

        readonly List<PeriodItem> periods = new List<PeriodItem>() { new PeriodItem("1 Week", 5), new PeriodItem("2 Week", 10), new PeriodItem("1 Month", 20) };
        bool isSelection = false;
        bool isDrawing = false;
        int daysCount = 105;
        FinancialIndicator draggingIndicator;
        ConstantLine trendlineBorder;

        XYDiagram Diagram { get { return (XYDiagram)stockChart.Diagram; } }
        Series PriceSeries { get { return stockChart.Series[PriceSeriesName]; } }
        FinancialSeriesViewBase PriceSeriesView { get { return (FinancialSeriesViewBase)PriceSeries.View; } }
        SideBySideBarSeriesView VolumeSeriesView { get { return (SideBySideBarSeriesView)stockChart.Series[VolumeSeriesName].View; } }

        public StockChartUC() {
            InitializeComponent();
            InitializeAdvancedIndicators();
            barStaticItemAdvancedIndicators.LeftIndent = 11;
            barStaticItemPeriod.LeftIndent = 11;
            this.stockChart.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            LookAndFeel_StyleChanged(null, null);
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            XYDiagram xYDiagram = stockChart.Diagram as XYDiagram;
            CustomAxisLabel customAxisLabel = xYDiagram.AxisY.CustomLabels[0];
            customAxisLabel.BackColor = Skins.CommonSkins.GetSkin(stockChart.LookAndFeel).SvgPalettes[ObjectState.Normal].GetColor("Gray");
            customAxisLabel.TextColor = Skins.CommonSkins.GetSkin(stockChart.LookAndFeel).SvgPalettes[ObjectState.Normal].GetColor("White");
        }
        void InitializeAdvancedIndicators() {
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new LinearRegressionItem());

            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new SimpleMovingAverageItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new ExponentialMovingAverageItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new TripleExponentialMovingAverageItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new TriangularMovingAverageItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new WeightedMovingAverageItem());

            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new MedianPriceItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new TypicalPriceItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new WeightedCloseItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new AverageTrueRangeItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new CommodityChannelIndexItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new DetrendedPriceOscillatorItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new MassIndexItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new MovingAverageConvergenceDivergenceItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new RateOfChangeItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new RelativeStrengthIndexItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new StandardDeviationItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new ChaikinsVolatilityItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.Items.Add(new WilliamsRItem());
            repositoryItemCheckedComboBoxEditAdvancedIndicators.CustomDisplayText += Empty_CustomDisplayText;
        }
        void StockChartUC_Load(object sender, EventArgs e) {
            if(StockMarketView.defaultViewModel == null)
                return;
          
            stockBarCheckItem.ImageOptions.SvgImage = SvgResources.GetSvgImage("Stock");
            candleStickBarCheckItem.ImageOptions.SvgImage = SvgResources.GetSvgImage("Candles");
            volumesBarCheckItem.ImageOptions.SvgImage = SvgResources.GetSvgImage("Bars");
            barCheckItem3.ImageOptions.SvgImage = SvgResources.GetSvgImage("6m");
            barCheckItem4.ImageOptions.SvgImage = SvgResources.GetSvgImage("1y");
            barCheckItem5.ImageOptions.SvgImage = SvgResources.GetSvgImage("1-5y");
            barCheckItem6.ImageOptions.SvgImage = SvgResources.GetSvgImage("2y");
            barCheckItem7.ImageOptions.SvgImage = SvgResources.GetSvgImage("4y");
            barCheckItemRemoveIndicator.ImageOptions.SvgImage = SvgResources.GetSvgImage("Remove");
            barCheckItemTrendLine.ImageOptions.SvgImage = SvgResources.GetSvgImage("TrendLine");
            barCheckItemFibonacciArcs.ImageOptions.SvgImage = SvgResources.GetSvgImage("FibonacciArcs");
            barCheckItemFibonacciFans.ImageOptions.SvgImage = SvgResources.GetSvgImage("FibonacciFans");
            barCheckItemFibonacciRetracement.ImageOptions.SvgImage = SvgResources.GetSvgImage("FibonacciRetracement");
            //StockMarketView.defaultViewModel.model.InitServer();
            OnPeriodChanged(barCheckItem7, null);
            for(int i = 0; i < 6; i++)
                repositoryItemCheckedComboBoxEditAdvancedIndicators.Items[i].CheckState = CheckState.Checked;

            barEditItemAdvancedIndicators.EditValue = "Default";
        }
        void OnShowVolumeChartChanged(object sender, ItemClickEventArgs e) {
            Diagram.Panes[0].Visibility = volumesBarCheckItem.Checked ? ChartElementVisibility.Visible : ChartElementVisibility.Hidden;
        }
        void OnPeriodChanged(object sender, ItemClickEventArgs e) {
            BarCheckItem barCheckItem = sender as BarCheckItem;
            if(barCheckItem != null && barCheckItem.Checked != false) {
                daysCount = (int)barCheckItem.Tag;
                repositoryItemComboBoxPeriod.Items.Clear();
                foreach(PeriodItem periodItem in periods) {
                    int numberOfCandles = daysCount / periodItem.Ticks;
                    if(numberOfCandles >= MinCandleCount)
                        repositoryItemComboBoxPeriod.Items.Add(periodItem);
                }
                comboBoxBarEditItem.EditValue = repositoryItemComboBoxPeriod.Items[0];
                OnTicksChanged(comboBoxBarEditItem, null);
            }
        }
        void OnTicksChanged(object sender, EventArgs e) {
            if(!ViewModel.RealTimeDataViewModel.IsReady) return;
            BarEditItem barEditItem = sender as BarEditItem;
            if(barEditItem != null && barEditItem.Name == "comboBoxBarEditItem") {
                var vm = StockMarketView.defaultViewModel;
                if(vm != null) {
                    int numberOfTicks = ((PeriodItem)barEditItem.EditValue).Ticks;
                    int newCandlesCount = daysCount / numberOfTicks;
                    if(vm.Ticks != numberOfTicks || vm.CandlesCount != newCandlesCount) {
                        vm.SetTicks(numberOfTicks);
                        vm.CandlesCount = newCandlesCount;
                        vm.OnCandlesCountChanged();
                    }
                }
            }
            UpdateSeriesView();
        }
        void UpdateSeriesView() {
            if(comboBoxBarEditItem.EditValue != null) {
                switch(comboBoxBarEditItem.EditValue.ToString()) {
                    case "1 week":
                        Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week;
                        PriceSeriesView.LevelLineLength = 0.3;
                        VolumeSeriesView.BarWidth = 0.8D;
                        break;
                    case "2 week":
                        Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week;
                        PriceSeriesView.LevelLineLength = 0.6;
                        VolumeSeriesView.BarWidth = 1.6D;
                        break;
                    case "1 month":
                        Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
                        PriceSeriesView.LevelLineLength = 0.3;
                        VolumeSeriesView.BarWidth = 0.8D;
                        break;
                }
            }
        }
        void ChangeViewToCandleStick(object sender, ItemClickEventArgs e) {
            stockChart.Series[PriceSeriesName].ChangeView(ViewType.CandleStick);
        }
        void ChangeViewToStock(object sender, ItemClickEventArgs e) {
            stockChart.Series[PriceSeriesName].ChangeView(ViewType.Stock);
        }
        void stockChart_MouseMove(object sender, MouseEventArgs e) {
            if(isDrawing) {
                DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
                draggingIndicator.Point2.Argument = coords.DateTimeArgument;
                trendlineBorder.AxisValue = coords.DateTimeArgument;
            }
        }
        void stockChart_MouseUp(object sender, MouseEventArgs e) {
            if(!isSelection) {
                draggingIndicator = null;
                Diagram.AxisX.ConstantLines.Remove(trendlineBorder);
                trendlineBorder = null;
                isDrawing = false;
                stockChart.Capture = false;
            }
        }
        void stockChart_MouseDown(object sender, MouseEventArgs e) {
            if(!isSelection) {
                draggingIndicator = CreateDraggingIndicator();
                if(draggingIndicator == null)
                    return;

                DiagramCoordinates coords = Diagram.PointToDiagram(e.Location);
                draggingIndicator.Point1.Argument = coords.DateTimeArgument;
                draggingIndicator.Point1.ValueLevel = ValueLevel.Close;
                draggingIndicator.Point2.Argument = coords.DateTimeArgument;
                draggingIndicator.Point2.ValueLevel = ValueLevel.Close;

                PriceSeriesView.Indicators.Add(draggingIndicator);

                trendlineBorder = new ConstantLine();
                trendlineBorder.AxisValue = coords.DateTimeArgument;
                trendlineBorder.LineStyle.DashStyle = DashStyle.Dash;
                trendlineBorder.LineStyle.Thickness = 1;
                trendlineBorder.ShowInLegend = false;
                Diagram.AxisX.ConstantLines.Add(trendlineBorder);
                stockChart.Capture = true;

                isDrawing = true;
                stockChart.Capture = true;
            }
        }
        void stockChart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if(!isSelection || !e.HitInfo.InIndicator)
                e.Cancel = true;
            else if(e.HitInfo.InIndicator) {
                Indicator indicator = e.HitInfo.Indicator;
                if(!(indicator is TrendLine) && !(indicator is FibonacciIndicator))
                    e.Cancel = true;
            }
        }
        void stockChart_ObjectSelected(object sender, HotTrackEventArgs e) {
            if(isSelection && e.HitInfo.InIndicator) {
                Indicator indicator = e.HitInfo.Indicator;
                if(indicator is TrendLine || indicator is FibonacciIndicator)
                    ChartHelper.RemoveIndicator(stockChart, PriceSeriesView, indicator);
            }
            e.Cancel = true;
        }
        void barEditItemMovingAverageIndicators_EditValueChanged(object sender, EventArgs e) {
            foreach(CheckedListBoxItem item in repositoryItemCheckedComboBoxEditMovingAverages.Items) {
                CheckedIndicatorItem movingAverage = (CheckedIndicatorItem)item.Value;
                movingAverage.UpdateIndicator(stockChart, PriceSeriesView, item.CheckState == CheckState.Checked);
            }
        }
        void barEditItemAdvancedIndicators_EditValueChanged(object sender, EventArgs e) {
            foreach(CheckedListBoxItem item in repositoryItemCheckedComboBoxEditAdvancedIndicators.Items) {
                CheckedIndicatorItem indicatorItem = (CheckedIndicatorItem)item.Value;
                indicatorItem.UpdateIndicator(stockChart, PriceSeriesView, item.CheckState == CheckState.Checked);
            }
        }
        void Empty_CustomDisplayText(object sender, CustomDisplayTextEventArgs e) {
            if(string.IsNullOrEmpty(e.DisplayText))
                e.DisplayText = "None";
        }
        void UpdateDrawingItemChecked(BarCheckItem item, BarCheckItem changedItem) {
            if(item != changedItem)
                item.Checked = false;
        }
        void UpdateDrawingItems(object sender, ItemClickEventArgs e) {
            BarCheckItem item = (BarCheckItem)sender;
            if(item.Checked) {
                UpdateDrawingItemChecked(barCheckItemTrendLine, item);
                UpdateDrawingItemChecked(barCheckItemFibonacciArcs, item);
                UpdateDrawingItemChecked(barCheckItemFibonacciFans, item);
                UpdateDrawingItemChecked(barCheckItemFibonacciRetracement, item);
                UpdateDrawingItemChecked(barCheckItemRemoveIndicator, item);
            }
            stockChart.CrosshairEnabled = barCheckItemTrendLine.Checked || barCheckItemFibonacciArcs.Checked || barCheckItemFibonacciFans.Checked ||
                barCheckItemFibonacciRetracement.Checked || barCheckItemRemoveIndicator.Checked ? DefaultBoolean.False : DefaultBoolean.True;
        }
        void barCheckItemRemoveIndicator_CheckedChanged(object sender, ItemClickEventArgs e) {
            isSelection = ((BarCheckItem)sender).Checked;
            UpdateDrawingItems(sender, e);
        }
        void stockChart_BoundDataChanged(object sender, EventArgs e) {
            if(PriceSeries.Points.Count > 0) {
                Diagram.AxisY.CustomLabels[0].AxisValue = PriceSeries.Points[PriceSeries.Points.Count - 1].Values[3];
                Diagram.AxisY.CustomLabels[0].Name = String.Format("${0:F1}", Diagram.AxisY.CustomLabels[0].AxisValue);
            }
        }
        FinancialIndicator CreateDraggingIndicator() {
            if(barCheckItemTrendLine.Checked)
                return new TrendLine("TrendLine");
            if(barCheckItemFibonacciArcs.Checked)
                return new FibonacciIndicator(FibonacciIndicatorKind.FibonacciArcs, "FibonacciArcs");
            if(barCheckItemFibonacciFans.Checked)
                return new FibonacciIndicator(FibonacciIndicatorKind.FibonacciFans, "FibonacciFans");
            if(barCheckItemFibonacciRetracement.Checked)
                return new FibonacciIndicator(FibonacciIndicatorKind.FibonacciRetracement, "FibonacciRetracement");
            return null;
        }
    }
    public class PeriodItem {
        public PeriodItem(string caption, int ticks) {
            Caption = caption;
            Ticks = ticks;
        }
        public override string ToString() {
            return Caption;
        }
        public string Caption {
            get;
            private set;
        }
        public int Ticks {
            get;
            private set;
        }
    }
    //
    public class SvgResources {
        const string prefix = "DevExpress.StockMarketTrader.ImagesSvg.";
        const string ext = ".svg";
        readonly static Dictionary<string, SvgImage> svgImages = new Dictionary<string, SvgImage>(20);
        public static SvgImage GetSvgImage(string imageName) {
            SvgImage svgImage;
            if(!svgImages.TryGetValue(imageName, out svgImage)) {
                svgImage = ResourceImageHelper.CreateSvgImageFromResources(prefix + imageName + ext, typeof(SvgResources).Assembly);
                svgImages.Add(imageName, svgImage);
            }
            return svgImage;
        }
    }
}