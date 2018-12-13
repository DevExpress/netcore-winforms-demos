using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Customization;
using DevExpress.Data;
using DevExpress.Skins;
using DevExpress.Sparkline;
using DevExpress.StockMarketTrader.Model.BusinessObjects;
using DevExpress.StockMarketTrader.ViewModel;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DevExpress.StockMarketTrader {
    public partial class StockWorkspacesUC : XtraUserControl {
        int selectedPiePointIndex = 0;
        string selectedCompanyName;
        Color red = Color.Red;
        Color green = Color.Green;

        public StockWorkspacesUC() {
            InitializeComponent();
            UpdateCustomColors();
        }
        void UpdateCustomColors() {
            red = CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            green = CommonColors.GetInformationColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
        }
        void StockWorkspacesUC_Load(object sender, EventArgs e) {
            if(StockMarketView.defaultViewModel == null)
                return;
            StockMarketView.defaultViewModel.CurrentPriceIndexChanged += defaultViewModel_CurrentPriceIndexChanged;
            StockMarketView.defaultViewModel.PropertyChanged += defaultViewModel_PropertyChanged;
            //watchList
            watchListGridView.OptionsBehavior.AutoPopulateColumns = false;
            watchListGridView.OptionsBehavior.CacheValuesOnRowUpdating = CacheRowValuesMode.Disabled;
            watchListGrid.MainView.DataController.AllowIEnumerableDetails = false;
            watchListGridView.FocusRectStyle = XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            watchListGrid.DataSource = StockMarketView.defaultViewModel.WatchListBindingData;
            GridColumn col = watchListGridView.Columns.Add();
            col.FieldName = "CompanyName";
            col.Caption = "Symbol";
            col.Visible = true;
            col = watchListGridView.Columns.Add();
            col.FieldName = "Price";
            col.Caption = "Last Price";

            //col.ColumnEdit = new ArrowButtonRepositoryItem();
            col.DisplayFormat.FormatType = FormatType.Numeric;
            col.DisplayFormat.FormatString = "c";
            col.Visible = true;
            col = watchListGridView.Columns.Add();
            col.FieldName = "Volume";
            col.DisplayFormat.FormatType = FormatType.Numeric;
            col.DisplayFormat.FormatString = "n0";
            col.Visible = true;
            col = watchListGridView.Columns.Add();
            col.FieldName = "Volume Dynamics";
            RepositoryItemSparklineEdit rise = new RepositoryItemSparklineEdit();
            col.ColumnEdit = rise;
            col.UnboundType = Data.UnboundColumnType.Object;
            AreaSparklineView view = new AreaSparklineView();
            view.HighlightMaxPoint = true;
            view.HighlightMinPoint = true;
            rise.View = view;
            col.Visible = true;

            
            col = watchListGridView.Columns.Add();
            col.FieldName = "Rise";
            col.Name = "Rise";
            col.Visible = false;

            //col = watchListGridView.Columns.Add();
            //col.FieldName = "TotalRise";
            //col.Name = "TotalRise";
            //col.Visible = false;


            //FormatConditionRuleIconSet val = new FormatConditionIconSetPositiveNegativeTriangles() { RangeDescription = "0, >0" };

            //watchListGridView.FormatRules.Add(new GridFormatRule() { Rule =   val, Column = watchListGridView.Columns["Rise"], ColumnApplyTo=watchListGridView.Columns[1]});
            var rule = watchListGridView.FormatRules.AddIconSetRule(watchListGridView.Columns["Rise"], new FormatConditionIconSetPositiveNegativeTriangles() { RangeDescription = "<0, 0, >0" });
            rule.ColumnApplyTo = watchListGridView.Columns[1];
            rule.Enabled = true;
            

            watchListGridView.BestFitColumns();
            watchListGridView.FocusedRowChanged += new XtraGrid.Views.Base.FocusedRowChangedEventHandler(watchListGridView_FocusedRowChanged);
            //watchListGridView.CustomDrawCell += watchListGridView_CustomDrawCell;
            watchListGridView.CustomUnboundColumnData += watchListGridView_CustomUnboundColumnData;

            //chart
            stockChartUC.stockChart.Series["Price"].DataSource = StockMarketView.defaultViewModel.StockChartBindingData;
            stockChartUC.stockChart.Series["Price"].ArgumentDataMember = "Date";
            stockChartUC.stockChart.Series["Price"].ValueDataMembers.AddRange(new string[] { "Low", "High", "Open", "Close" });

            stockChartUC.stockChart.Series["Volume"].DataSource = StockMarketView.defaultViewModel.StockChartBindingData;
            stockChartUC.stockChart.Series["Volume"].ArgumentDataMember = "Date";
            stockChartUC.stockChart.Series["Volume"].ValueDataMembers.AddRange(new string[] { "Volume" });
            //volumeChart
            volumeChart.Series[0].DataSource = StockMarketView.defaultViewModel.VolumeChartBindingData;
            volumeChart.Series[0].ArgumentDataMember = "CompanyName";
            volumeChart.Series[0].ToolTipPointPattern = "Argument: {A}&#x0a;Value: {V}";
            volumeChart.Series[0].ValueDataMembers.AddRange(new string[] { "Volume" });

            //transationsGrid
            transactionGridView.OptionsBehavior.AutoPopulateColumns = false;
            transactionGrid.DataSource = StockMarketView.defaultViewModel.TransactionGridBindingData;
            var fceAsk = new FormatConditionRuleExpression() { Expression = "Ask > 0", PredefinedName = "Red Fill" };
            transactionGridView.FormatRules.AddRule(new GridFormatRule() { ApplyToRow = true, Rule = fceAsk });
            
            var fceBid = new FormatConditionRuleExpression() { Expression = "Bid > 0", PredefinedName = "Green Fill" };
            transactionGridView.FormatRules.AddRule(new GridFormatRule() { ApplyToRow = true, Rule = fceBid });
            
            StockMarketView.defaultViewModel.WatchListChanged += defaultViewModel_WatchListChanged;

            helpBarItemButton.ImageOptions.SvgImage = SvgResources.GetSvgImage("Help");
            bbiSwatches.ImageOptions.SvgImage = SvgResources.GetSvgImage("Swatches");
            bsiConnectedStatus.ImageOptions.SvgImage = SvgResources.GetSvgImage("Connected");
        }
        void defaultViewModel_WatchListChanged(object sender, EventArgs e) {
            watchListGridView.RefreshData();
        }
        void UpdateNetworkState() {
            bsiConnectedStatus.Caption = StockMarketView.defaultViewModel.NetworkState;
        }
        void defaultViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e) {
            if(e.PropertyName == "NetworkState" && FindForm() != null) {
                this.FindForm().BeginInvoke(new MethodInvoker(UpdateNetworkState), new object[] { });
            }
        }
        void OnVolumeChartBoundDataChanged(object sender, EventArgs e) {
            if(volumeChart.Series[0].Points.Count > 0 && selectedPiePointIndex != -1 && volumeChart.Series[0].Points.Count > selectedPiePointIndex) {
                DoughnutSeriesView view = volumeChart.Series[0].View as DoughnutSeriesView;
                for(int i = 0; i < volumeChart.Series[0].Points.Count; i++) {
                    if(selectedCompanyName == volumeChart.Series[0].Points[i].Argument.ToString()) {
                        ExplodePoint(volumeChart.Series[0].Points[i], view);
                        selectedPiePointIndex = i;
                        break;
                    }
                }
            }
        }
        //void watchListGridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
        //    if(StockMarketView.defaultViewModel == null)
        //        return;
        //    GridCellInfo info = e.Cell as GridCellInfo;
        //    if(info == null)
        //        return;
        //    CompanyTradingDataViewModel rowData = watchListGridView.GetRow(e.RowHandle) as CompanyTradingDataViewModel;
        //    ArrowButtonRepositoryItem arrowb = info.Editor as ArrowButtonRepositoryItem;
        //    if(info.Column.FieldName == "Price" && arrowb != null) {
        //        arrowb.ContextImageOptions.SvgImage = SvgResources.GetSvgImage(rowData.Rise == 0 ? "Up" : "Down");
        //        info.ViewInfo.DetailLevel = XtraEditors.Controls.DetailLevel.Full;
        //        info.ViewInfo.CalcViewInfo();
        //    }
        //}
        void defaultViewModel_CurrentPriceIndexChanged(object sender, EventArgs e) {
            if(StockMarketView.defaultViewModel == null) return;
            transactionGridView.FocusedRowHandle = StockMarketView.defaultViewModel.CurrentPriceIndex;
        }
        void watchListGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            StockMarketView.defaultViewModel.SelectedCompany = watchListGridView.GetFocusedRow() as CompanyTradingDataViewModel;
            selectedCompanyName = StockMarketView.defaultViewModel.SelectedCompany.CompanyName;
            SeriesPoint sPoint = FindSeriesPointByName(StockMarketView.defaultViewModel.SelectedCompany.CompanyName);
            DoughnutSeriesView view = volumeChart.Series[0].View as DoughnutSeriesView;
            if(sPoint != null && view != null)
                ExplodePoint(sPoint, view);
            else
                view.ExplodedPoints.Clear();
        }
        //void transactionGridView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) {
        //    if(StockMarketView.defaultViewModel == null)
        //        return;
        //    double cellValue = -1;
        //    GridCellInfo info = e.Cell as GridCellInfo;
        //    if(info == null)
        //        return;
        //    double.TryParse(e.CellValue.ToString(), out cellValue);
        //    if(cellValue != -1) {
        //        if(cellValue == 0) {
        //            info.Appearance.ForeColor = e.Appearance.BackColor;
        //            return;
        //        }
        //        TransactionData rowData = transactionGridView.GetRow(e.RowHandle) as TransactionData;
        //        if(rowData.TransactionType == "Ask")
        //            info.Appearance.ForeColor = green;
        //        else info.Appearance.ForeColor = red;
        //    }
        //}
        void volumeChart_MouseDown(object sender, MouseEventArgs e) {
            SeriesPoint seriesPoint = volumeChart.CalcHitInfo(e.Location).SeriesPoint;
            DoughnutSeriesView view = volumeChart.Series[0].View as DoughnutSeriesView;
            if(seriesPoint == null || view == null)
                return;
            ExplodePoint(seriesPoint, view);
            int rowH = GetRowHandleByCompanyName(selectedCompanyName);
            if(rowH >= 0) watchListGridView.FocusedRowHandle = rowH;
        }
        void ExplodePoint(SeriesPoint seriesPoint, DoughnutSeriesView view) {
            view.ExplodedPoints.Clear();
            view.ExplodedPoints.Add(seriesPoint);
            selectedCompanyName = seriesPoint.Argument.ToString();
        }
        void volumeChart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if(e.Object is DevExpress.XtraCharts.Series)
                return;
            e.Cancel = true;
        }
        void volumeChart_ObjectSelected(object sender, HotTrackEventArgs e) {
            if(e.Object is DevExpress.XtraCharts.Series)
                return;
            e.Cancel = true;
        }
        void PanelsCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            BarCheckItem item = e.Item as BarCheckItem;
            if(item == null) return;
            SetDockPanelVisibility(item);
        }
        void SetDockPanelVisibility(BarCheckItem item) {
            switch(item.Caption) {
                case "Watch List":
                    if(!item.Checked)
                        watchListDockPanel.Visibility = XtraBars.Docking.DockVisibility.Hidden;
                    else
                        watchListDockPanel.Visibility = XtraBars.Docking.DockVisibility.Visible;
                    break;
                case "Transaction":
                    if(!item.Checked)
                        transactionGridDockPanel.Visibility = XtraBars.Docking.DockVisibility.Hidden;
                    else
                        transactionGridDockPanel.Visibility = XtraBars.Docking.DockVisibility.Visible;
                    break;
                case "Top Volumes":
                    if(!item.Checked)
                        topVolumesDockPanel.Visibility = XtraBars.Docking.DockVisibility.Hidden;
                    else
                        topVolumesDockPanel.Visibility = XtraBars.Docking.DockVisibility.Visible;
                    break;
            }
        }
        void watchListDockPanel_ClosedPanel(object sender, DockPanelEventArgs e) {
            watchListbarCheckItem.Checked = false;
        }
        void topVolumesDockPanel_ClosedPanel(object sender, DockPanelEventArgs e) {
            topVolumesbarCheckItem.Checked = false;
        }
        void transactionGridDockPanel_ClosedPanel(object sender, DockPanelEventArgs e) {
            transactionGridbarCheckItem.Checked = false;
        }
        void panelContainerTopVolumesAndTransaction_ClosedPanel(object sender, DockPanelEventArgs e) {
            transactionGridbarCheckItem.Checked = false;
            topVolumesbarCheckItem.Checked = false;
        }
        void watchListGridView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
            if(e.IsGetData) {
                CompanyTradingDataViewModel model = e.Row as CompanyTradingDataViewModel;
                if(model != null && model.VolumeDynamics != null) {
                    List<double> values = new List<double>();
                    foreach(TradingDataViewModel dynamicItem in model.VolumeDynamics)
                        values.Add(dynamicItem.Volume);
                    e.Value = values;
                }
            }
        }
        SeriesPoint FindSeriesPointByName(string name) {
            for(int i = 0; i < volumeChart.Series[0].Points.Count; i++) {
                if(name == volumeChart.Series[0].Points[i].Argument.ToString())
                    return volumeChart.Series[0].Points[i];
            }
            return null;
        }
        protected int GetRowHandleByCompanyName(string name) {
            for(int i = 0; i < watchListGridView.RowCount; i++) {
                if(watchListGridView.GetRow(i) != null && ((CompanyTradingDataViewModel)watchListGridView.GetRow(i)).CompanyName == name) return i;
            }
            return -1;
        }
        void bbiSwatches_ItemClick(object sender, ItemClickEventArgs e) {
            using(SvgSkinPaletteSelector svgSkinPaletteSelector = new SvgSkinPaletteSelector(this.FindForm())) {
                svgSkinPaletteSelector.ShowDialog();
            }
            UpdateCustomColors();
        }
        void helpBarItemButton_ItemClick(object sender, ItemClickEventArgs e) {
            AboutHelper.Show(ProductKind.DXperienceWin, new ProductStringInfoWin("Stock Market Trader Demo"));
        }
    }
}