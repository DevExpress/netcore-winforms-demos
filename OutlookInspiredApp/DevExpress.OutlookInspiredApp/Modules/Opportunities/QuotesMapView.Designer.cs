namespace DevExpress.DevAV.Modules {
    partial class QuoteMapView {
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
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.MapCallout mapCallout1 = new DevExpress.XtraMap.MapCallout();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.bubbleChartDataAdapter1 = new DevExpress.XtraMap.BubbleChartDataAdapter();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biSave = new DevExpress.XtraBars.BarButtonItem();
            this.biClose = new DevExpress.XtraBars.BarButtonItem();
            this.biSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.biDelete = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barExportItem = new DevExpress.XtraBars.BarButtonItem();
            this.biHigh = new DevExpress.XtraBars.BarCheckItem();
            this.biMedium = new DevExpress.XtraBars.BarCheckItem();
            this.biLow = new DevExpress.XtraBars.BarCheckItem();
            this.biUnlikely = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.moduleDataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMap = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).BeginInit();
            this.moduleDataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLayer1
            // 
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            // 
            // bingMapDataProvider1
            // 
            this.bingMapDataProvider1.Kind = DevExpress.XtraMap.BingMapKind.Road;
            // 
            // vectorItemsLayer1
            // 
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1;
            this.vectorItemsLayer1.Colorizer = keyColorColorizer1;
            this.vectorItemsLayer1.Data = this.bubbleChartDataAdapter1;
            this.vectorItemsLayer1.ToolTipPattern = "City:%A% Value:%V%";
            this.vectorItemsLayer1.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.ItemsLayer_DataLoaded);
            // 
            // bubbleChartDataAdapter1
            // 
            this.bubbleChartDataAdapter1.BubbleItemDataMember = "City";
            this.bubbleChartDataAdapter1.DataSource = this.bindingSource;
            this.bubbleChartDataAdapter1.Mappings.BubbleGroup = "Index";
            this.bubbleChartDataAdapter1.Mappings.Latitude = "Latitude";
            this.bubbleChartDataAdapter1.Mappings.Longitude = "Longitude";
            this.bubbleChartDataAdapter1.Mappings.Value = "Value";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.QuoteMapItem);
            // 
            // vectorItemsLayer2
            // 
            this.vectorItemsLayer2.Data = this.mapItemStorage1;
            // 
            // mapItemStorage1
            // 
            mapCallout1.AllowHtmlText = true;
            mapCallout1.Text = "Test";
            this.mapItemStorage1.Items.Add(mapCallout1);
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
            this.biPrint,
            this.biPrintPreview,
            this.barExportItem,
            this.biHigh,
            this.biMedium,
            this.biLow,
            this.biUnlikely});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
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
            // biHigh
            // 
            this.biHigh.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biHigh.Caption = "High";
            this.biHigh.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biHigh.Id = 16;
            this.biHigh.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biHigh.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.High.svg";
            this.biHigh.Name = "biHigh";
            // 
            // biMedium
            // 
            this.biMedium.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biMedium.Caption = "Medium";
            this.biMedium.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biMedium.Id = 17;
            this.biMedium.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biMedium.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Medium.svg";
            this.biMedium.Name = "biMedium";
            // 
            // biLow
            // 
            this.biLow.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biLow.Caption = "Low";
            this.biLow.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biLow.Id = 18;
            this.biLow.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biLow.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Low.svg";
            this.biLow.Name = "biLow";
            // 
            // biUnlikely
            // 
            this.biUnlikely.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biUnlikely.Caption = "Unlikely";
            this.biUnlikely.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biUnlikely.Id = 19;
            this.biUnlikely.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biUnlikely.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Unlike.svg";
            this.biUnlikely.Name = "biUnlikely";
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
            this.ribbonPageGroup4.ItemLinks.Add(this.biHigh);
            this.ribbonPageGroup4.ItemLinks.Add(this.biMedium);
            this.ribbonPageGroup4.ItemLinks.Add(this.biLow);
            this.ribbonPageGroup4.ItemLinks.Add(this.biUnlikely);
            this.ribbonPageGroup4.MergeOrder = 0;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Opportunities";
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
            this.moduleDataLayout.Controls.Add(this.mapControl);
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
            this.mapControl.Layers.Add(this.imageLayer1);
            this.mapControl.Layers.Add(this.vectorItemsLayer1);
            this.mapControl.Layers.Add(this.vectorItemsLayer2);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(1222, 642);
            this.mapControl.TabIndex = 18;
            this.mapControl.ZoomLevel = 8D;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForMap,
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
            this.ItemForMap.Size = new System.Drawing.Size(1222, 642);
            this.ItemForMap.Text = "map";
            this.ItemForMap.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForMap.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(1224, 0);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(2, 642);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(1222, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 642);
            // 
            // QuoteMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleDataLayout);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuoteMapView";
            this.Size = new System.Drawing.Size(1226, 762);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).EndInit();
            this.moduleDataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.BarButtonItem biSave;
        private XtraBars.BarButtonItem biClose;
        private XtraBars.BarButtonItem biSaveAndClose;
        private XtraBars.BarButtonItem biDelete;
        private XtraBars.BarButtonItem biPrint;
        private XtraBars.BarButtonItem biPrintPreview;
        private XtraBars.BarButtonItem barExportItem;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraDataLayout.DataLayoutControl moduleDataLayout;
        private XtraMap.MapControl mapControl;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem ItemForMap;
        private XtraLayout.SimpleSeparator simpleSeparator1;
        private XtraLayout.SimpleSeparator simpleSeparator2;
        private XtraBars.BarCheckItem biHigh;
        private XtraBars.BarCheckItem biMedium;
        private XtraBars.BarCheckItem biLow;
        private XtraBars.BarCheckItem biUnlikely;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraMap.ImageLayer imageLayer1;
        private XtraMap.BingMapDataProvider bingMapDataProvider1;
        private XtraMap.VectorItemsLayer vectorItemsLayer1;
        private XtraMap.BubbleChartDataAdapter bubbleChartDataAdapter1;
        private XtraMap.VectorItemsLayer vectorItemsLayer2;
        private XtraMap.MapItemStorage mapItemStorage1;
    }
}
