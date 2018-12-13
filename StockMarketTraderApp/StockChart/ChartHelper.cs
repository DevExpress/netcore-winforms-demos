using System.Collections.Generic;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Native;

namespace DevExpress.StockMarketTrader {
    public static class ChartHelper {
        static void InitializeNewPaneLegend(ChartControl chart, SeparatePaneIndicator indicator) {
            Legend legend = new Legend();
            chart.Legends.Add(legend);
            indicator.Legend = legend;
            legend.Tag = indicator.Tag;
            legend.DockTarget = indicator.Pane;
            legend.AlignmentHorizontal = LegendAlignmentHorizontal.Left;
            legend.Margins.All = chart.Legend.Margins.All;
        }
        static void UpdateAxisXVisibilityInPanes(XYDiagram diagram) {
            List<XYDiagramPaneBase> panes = diagram.GetAllPanes();
            for (int i = 0; i < panes.Count; i++)
                diagram.AxisX.SetVisibilityInPane(i == panes.Count - 1, panes[i]);
        }
        public static void InitializeSeparatePaneIndicator(ChartControl chart, SeparatePaneIndicator separatePaneIndicator) {
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if (diagram != null) {
                XYDiagramPane pane = new XYDiagramPane(separatePaneIndicator.Name + " Pane");
                pane.Tag = separatePaneIndicator.Tag;
                diagram.Panes.Add(pane);
                SecondaryAxisY axisY = new SecondaryAxisY(separatePaneIndicator.Name + " Axis");
                axisY.Tag = separatePaneIndicator.Tag;
                axisY.Alignment = AxisAlignment.Far;
                axisY.GridLines.Visible = true;
                axisY.GridLines.MinorVisible = true;
                axisY.WholeRange.AlwaysShowZeroLevel = false;
                diagram.SecondaryAxesY.Add(axisY);
                separatePaneIndicator.Pane = pane;
                separatePaneIndicator.AxisY = axisY;
                InitializeNewPaneLegend(chart, separatePaneIndicator);
                UpdateAxisXVisibilityInPanes(diagram);
            }
        }
        public static void RemoveIndicator(ChartControl chart, XYDiagramSeriesViewBase view, Indicator indicator) {
            SeparatePaneIndicator separatePaneIndicator = indicator as SeparatePaneIndicator;
            if (separatePaneIndicator != null ) {
                foreach (Legend legend in chart.Legends) {
                    if (legend.Tag == separatePaneIndicator.Tag) {
                        chart.Legends.Remove(legend);
                        break;
                    }
                }
                XYDiagram diagram = chart.Diagram as XYDiagram;
                if (diagram != null) {
                    foreach (XYDiagramPane pane in diagram.Panes) {
                        if (pane.Tag == separatePaneIndicator.Tag) {
                            diagram.Panes.Remove(pane);
                            break;
                        }
                    }
                    foreach (SecondaryAxisY axisY in diagram.SecondaryAxesY) {
                        if (axisY.Tag == separatePaneIndicator.Tag) {
                            diagram.SecondaryAxesY.Remove(axisY);
                            break;
                        }
                    }
                }
            }
            view.Indicators.Remove(indicator);
        }
    }
}
