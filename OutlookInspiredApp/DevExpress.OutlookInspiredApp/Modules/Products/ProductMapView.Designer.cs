namespace DevExpress.DevAV.Modules {
    partial class ProductMapView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            keyColorColorizer = new DevExpress.DevAV.Modules.Colorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.pieChartDataAdapter1 = new DevExpress.XtraMap.PieChartDataAdapter();
            this.bindingSourceMapItem = new System.Windows.Forms.BindingSource(this.components);
            this.chartPanel = new DevExpress.XtraEditors.PanelControl();
            this.periodButtons = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.bindingSourceChart = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biSave = new DevExpress.XtraBars.BarButtonItem();
            this.biClose = new DevExpress.XtraBars.BarButtonItem();
            this.biSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.biDelete = new DevExpress.XtraBars.BarButtonItem();
            this.biLifetime = new DevExpress.XtraBars.BarCheckItem();
            this.biThisYear = new DevExpress.XtraBars.BarCheckItem();
            this.biThisMonth = new DevExpress.XtraBars.BarCheckItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barExportItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.moduleDataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            this.DescriptionLabel = new DevExpress.XtraEditors.LabelControl();
            this.ImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMap = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForChartPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAddressLine1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMapItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).BeginInit();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).BeginInit();
            this.moduleDataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForChartPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageTilesLayer1
            // 
            this.imageTilesLayer1.DataProvider = this.bingMapDataProvider1;
            // 
            // bingMapDataProvider1
            // 
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            // 
            // vectorItemsLayer1
            // 
            keyColorColorizer.ItemKeyProvider = argumentItemKeyProvider1;
            this.vectorItemsLayer1.Colorizer = keyColorColorizer;
            this.vectorItemsLayer1.Data = this.pieChartDataAdapter1;
            this.vectorItemsLayer1.ToolTipPattern = "City:%A% Total:%V%";
            // 
            // pieChartDataAdapter1
            // 
            this.pieChartDataAdapter1.DataSource = this.bindingSourceMapItem;
            this.pieChartDataAdapter1.ItemMaxSize = 60;
            this.pieChartDataAdapter1.ItemMinSize = 20;
            this.pieChartDataAdapter1.Mappings.Latitude = "Latitude";
            this.pieChartDataAdapter1.Mappings.Longitude = "Longitude";
            this.pieChartDataAdapter1.Mappings.PieSegment = "CustomerName";
            this.pieChartDataAdapter1.Mappings.Value = "Total";
            this.pieChartDataAdapter1.PieItemDataMember = "City";
            // 
            // bindingSourceMapItem
            // 
            this.bindingSourceMapItem.DataSource = typeof(DevExpress.DevAV.MapItem);
            // 
            // chartPanel
            // 
            this.chartPanel.Controls.Add(this.periodButtons);
            this.chartPanel.Controls.Add(this.chart);
            this.chartPanel.Location = new System.Drawing.Point(736, 150);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(476, 484);
            this.chartPanel.TabIndex = 32;
            // 
            // periodButtons
            // 
            this.periodButtons.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("This Month", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("YTD", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Lifetime", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)});
            this.periodButtons.ContentAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.periodButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.periodButtons.Location = new System.Drawing.Point(2, 2);
            this.periodButtons.Name = "periodButtons";
            this.periodButtons.Padding = new System.Windows.Forms.Padding(0, 0, 44, 0);
            this.periodButtons.Size = new System.Drawing.Size(472, 32);
            this.periodButtons.TabIndex = 31;
            this.periodButtons.UseButtonBackgroundImages = false;
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.DataBindings = null;
            this.chart.DataSource = this.bindingSourceChart;
            xyDiagram1.AxisX.Label.Visible = false;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisY.Label.TextPattern = "{V:$##,#0}";
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Rotated = true;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(2, 2);
            this.chart.Name = "chart";
            this.chart.Padding.Bottom = 40;
            this.chart.Padding.Left = 40;
            this.chart.Padding.Right = 40;
            this.chart.Padding.Top = 48;
            this.chart.PaletteName = "Office 2013";
            series1.ArgumentDataMember = "CustomerName";
            series1.ColorDataMember = "CustomerName";
            series1.Name = "Customers";
            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([Total])";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(472, 480);
            this.chart.TabIndex = 34;
            // 
            // bindingSourceChart
            // 
            this.bindingSourceChart.DataSource = typeof(DevExpress.DevAV.MapItem);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.ViewModels.ProductMapViewModel);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.biSave,
            this.biClose,
            this.biSaveAndClose,
            this.biDelete,
            this.biLifetime,
            this.biThisYear,
            this.biThisMonth,
            this.biPrint,
            this.biPrintPreview,
            this.barExportItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 12;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.Size = new System.Drawing.Size(1226, 120);
            // 
            // biSave
            // 
            this.biSave.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biSave.Caption = "Save";
            this.biSave.Id = 1;
            this.biSave.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biSave.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg";
            this.biSave.Name = "biSave";
            // 
            // biClose
            // 
            this.biClose.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biClose.Caption = "Close";
            this.biClose.Id = 2;
            this.biClose.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg";
            this.biClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape);
            this.biClose.Name = "biClose";
            // 
            // biSaveAndClose
            // 
            this.biSaveAndClose.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biSaveAndClose.Caption = "Save && Close";
            this.biSaveAndClose.Id = 3;
            this.biSaveAndClose.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biSaveAndClose.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg";
            this.biSaveAndClose.Name = "biSaveAndClose";
            // 
            // biDelete
            // 
            this.biDelete.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biDelete.Caption = "Delete";
            this.biDelete.Id = 4;
            this.biDelete.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biDelete.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
            this.biDelete.Name = "biDelete";
            // 
            // biLifetime
            // 
            this.biLifetime.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biLifetime.Caption = "Lifetime";
            this.biLifetime.Id = 5;
            this.biLifetime.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biLifetime.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodLifetime.svg";
            this.biLifetime.Name = "biLifetime";
            // 
            // biThisYear
            // 
            this.biThisYear.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biThisYear.Caption = "This Year";
            this.biThisYear.Id = 6;
            this.biThisYear.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biThisYear.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodYear.svg";
            this.biThisYear.Name = "biThisYear";
            // 
            // biThisMonth
            // 
            this.biThisMonth.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biThisMonth.Caption = "This Month";
            this.biThisMonth.Id = 7;
            this.biThisMonth.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biThisMonth.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SalesPeriodMonth.svg";
            this.biThisMonth.Name = "biThisMonth";
            // 
            // biPrint
            // 
            this.biPrint.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biPrint.Caption = "Print";
            this.biPrint.Id = 8;
            this.biPrint.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biPrint.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg";
            this.biPrint.Name = "biPrint";
            // 
            // biPrintPreview
            // 
            this.biPrintPreview.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biPrintPreview.Caption = "Print Preview";
            this.biPrintPreview.Id = 9;
            this.biPrintPreview.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biPrintPreview.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintPreview.svg";
            this.biPrintPreview.Name = "biPrintPreview";
            // 
            // barExportItem
            // 
            this.barExportItem.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barExportItem.Caption = "Export";
            this.barExportItem.Id = 11;
            this.barExportItem.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.barExportItem.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg";
            this.barExportItem.LargeImageIndex = 50;
            this.barExportItem.Name = "barExportItem";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HOME";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.biSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.biSaveAndClose);
            this.ribbonPageGroup1.MergeOrder = 0;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.biDelete);
            this.ribbonPageGroup2.MergeOrder = 0;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Delete";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.biPrintPreview);
            this.ribbonPageGroup5.ItemLinks.Add(this.biPrint);
            this.ribbonPageGroup5.ItemLinks.Add(this.barExportItem);
            this.ribbonPageGroup5.MergeOrder = 0;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Print and Export";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.biThisMonth);
            this.ribbonPageGroup4.ItemLinks.Add(this.biThisYear);
            this.ribbonPageGroup4.ItemLinks.Add(this.biLifetime);
            this.ribbonPageGroup4.MergeOrder = 0;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Sales Period";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.biClose);
            this.ribbonPageGroup3.MergeOrder = 0;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Close";
            // 
            // moduleDataLayout
            // 
            this.moduleDataLayout.AllowCustomization = false;
            this.moduleDataLayout.Controls.Add(this.chartPanel);
            this.moduleDataLayout.Controls.Add(this.mapControl);
            this.moduleDataLayout.Controls.Add(this.NameLabel);
            this.moduleDataLayout.Controls.Add(this.DescriptionLabel);
            this.moduleDataLayout.Controls.Add(this.ImagePictureEdit);
            this.moduleDataLayout.DataSource = this.bindingSource;
            this.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleDataLayout.Location = new System.Drawing.Point(0, 120);
            this.moduleDataLayout.Name = "moduleDataLayout";
            this.moduleDataLayout.Root = this.layoutControlGroup1;
            this.moduleDataLayout.Size = new System.Drawing.Size(1226, 642);
            this.moduleDataLayout.TabIndex = 2;
            this.moduleDataLayout.Text = "moduleDataLayout";
            // 
            // mapControl
            // 
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapControl.Layers.Add(this.imageTilesLayer1);
            this.mapControl.Layers.Add(this.vectorItemsLayer1);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(720, 642);
            this.mapControl.TabIndex = 18;
            this.mapControl.ZoomLevel = 8D;
            // 
            // NameLabel
            // 
            this.NameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.NameLabel.Appearance.Options.UseFont = true;
            this.NameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true));
            this.NameLabel.Location = new System.Drawing.Point(856, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(356, 32);
            this.NameLabel.StyleController = this.moduleDataLayout;
            this.NameLabel.TabIndex = 8;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.DescriptionLabel.Appearance.Options.UseFont = true;
            this.DescriptionLabel.Appearance.Options.UseTextOptions = true;
            this.DescriptionLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.DescriptionLabel.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.DescriptionLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.DescriptionLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DescriptionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.DescriptionLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Description", true));
            this.DescriptionLabel.Location = new System.Drawing.Point(856, 40);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(356, 88);
            this.DescriptionLabel.StyleController = this.moduleDataLayout;
            this.DescriptionLabel.TabIndex = 8;
            // 
            // ImagePictureEdit
            // 
            this.ImagePictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Image", true));
            this.ImagePictureEdit.Location = new System.Drawing.Point(736, 8);
            this.ImagePictureEdit.MenuManager = this.ribbonControl;
            this.ImagePictureEdit.Name = "ImagePictureEdit";
            this.ImagePictureEdit.Properties.ReadOnly = true;
            this.ImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ImagePictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.ImagePictureEdit.Size = new System.Drawing.Size(108, 120);
            this.ImagePictureEdit.StyleController = this.moduleDataLayout;
            this.ImagePictureEdit.TabIndex = 17;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMap,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.simpleSeparator1,
            this.simpleSeparator2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1226, 642);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ItemForMap
            // 
            this.ItemForMap.Control = this.mapControl;
            this.ItemForMap.CustomizationFormText = "map";
            this.ItemForMap.Location = new System.Drawing.Point(0, 0);
            this.ItemForMap.Name = "layoutControlItem1";
            this.ItemForMap.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForMap.Size = new System.Drawing.Size(720, 642);
            this.ItemForMap.Text = "map";
            this.ItemForMap.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForMap.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForChartPanel});
            this.layoutControlGroup3.Location = new System.Drawing.Point(722, 140);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8);
            this.layoutControlGroup3.Size = new System.Drawing.Size(504, 502);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // ItemForChartPanel
            // 
            this.ItemForChartPanel.Control = this.chartPanel;
            this.ItemForChartPanel.CustomizationFormText = "layoutControlItem2";
            this.ItemForChartPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemForChartPanel.Name = "ItemForChartPanel";
            this.ItemForChartPanel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForChartPanel.Size = new System.Drawing.Size(476, 484);
            this.ItemForChartPanel.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForChartPanel.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4";
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForImage,
            this.ItemForAddressLine1,
            this.ItemForFullName});
            this.layoutControlGroup4.Location = new System.Drawing.Point(722, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8);
            this.layoutControlGroup4.Size = new System.Drawing.Size(504, 138);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // ItemForImage
            // 
            this.ItemForImage.Control = this.ImagePictureEdit;
            this.ItemForImage.CustomizationFormText = "Image";
            this.ItemForImage.Location = new System.Drawing.Point(0, 0);
            this.ItemForImage.MaxSize = new System.Drawing.Size(120, 120);
            this.ItemForImage.MinSize = new System.Drawing.Size(120, 120);
            this.ItemForImage.Name = "ItemForImage";
            this.ItemForImage.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 12, 0, 0);
            this.ItemForImage.Size = new System.Drawing.Size(120, 120);
            this.ItemForImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForImage.Text = "Image";
            this.ItemForImage.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForImage.TextVisible = false;
            // 
            // ItemForAddressLine1
            // 
            this.ItemForAddressLine1.Control = this.DescriptionLabel;
            this.ItemForAddressLine1.CustomizationFormText = "Address";
            this.ItemForAddressLine1.Location = new System.Drawing.Point(120, 32);
            this.ItemForAddressLine1.MaxSize = new System.Drawing.Size(356, 88);
            this.ItemForAddressLine1.MinSize = new System.Drawing.Size(356, 88);
            this.ItemForAddressLine1.Name = "ItemForAddressLine1";
            this.ItemForAddressLine1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForAddressLine1.Size = new System.Drawing.Size(356, 88);
            this.ItemForAddressLine1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForAddressLine1.Text = "Address";
            this.ItemForAddressLine1.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForAddressLine1.TextVisible = false;
            // 
            // ItemForFullName
            // 
            this.ItemForFullName.Control = this.NameLabel;
            this.ItemForFullName.CustomizationFormText = "Full Name";
            this.ItemForFullName.Location = new System.Drawing.Point(120, 0);
            this.ItemForFullName.Name = "ItemForFullName";
            this.ItemForFullName.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForFullName.Size = new System.Drawing.Size(356, 32);
            this.ItemForFullName.Text = "Full Name";
            this.ItemForFullName.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForFullName.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(722, 138);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(504, 2);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(720, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 642);
            // 
            // ProductMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleDataLayout);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ProductMapView";
            this.Size = new System.Drawing.Size(1226, 762);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMapItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).EndInit();
            this.chartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).EndInit();
            this.moduleDataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForChartPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAddressLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.DevAV.Modules.Colorizer keyColorColorizer;
        private System.Windows.Forms.BindingSource bindingSource;
        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.BarButtonItem biSave;
        private XtraBars.BarButtonItem biClose;
        private XtraBars.BarButtonItem biSaveAndClose;
        private XtraBars.BarButtonItem biDelete;
        private XtraBars.BarCheckItem biLifetime;
        private XtraBars.BarCheckItem biThisYear;
        private XtraBars.BarCheckItem biThisMonth;
        private XtraBars.BarButtonItem biPrint;
        private XtraBars.BarButtonItem biPrintPreview;
        private XtraBars.BarButtonItem barExportItem;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraDataLayout.DataLayoutControl moduleDataLayout;
        private XtraMap.MapControl mapControl;
        private XtraEditors.LabelControl NameLabel;
        private XtraEditors.LabelControl DescriptionLabel;
        private XtraEditors.PictureEdit ImagePictureEdit;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem ItemForMap;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.LayoutControlItem ItemForImage;
        private XtraLayout.LayoutControlItem ItemForAddressLine1;
        private XtraLayout.LayoutControlItem ItemForFullName;
        private XtraLayout.SimpleSeparator simpleSeparator1;
        private XtraLayout.SimpleSeparator simpleSeparator2;
        private XtraCharts.ChartControl chart;
        private XtraLayout.LayoutControlItem ItemForChartPanel;
        private System.Windows.Forms.BindingSource bindingSourceChart;
        private XtraBars.Docking2010.WindowsUIButtonPanel periodButtons;
        private DevExpress.XtraEditors.PanelControl chartPanel;
        private System.Windows.Forms.BindingSource bindingSourceMapItem;
        private XtraMap.ImageLayer imageTilesLayer1;
        private XtraMap.BingMapDataProvider bingMapDataProvider1;
        private XtraMap.VectorItemsLayer vectorItemsLayer1;
        private XtraMap.PieChartDataAdapter pieChartDataAdapter1;
    }
}
