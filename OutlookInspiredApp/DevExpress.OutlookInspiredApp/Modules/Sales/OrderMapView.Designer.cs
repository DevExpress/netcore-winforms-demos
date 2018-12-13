namespace DevExpress.DevAV.Modules {
    partial class OrderMapView {
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
            this.imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.bingGeocodeDataProvider1 = new DevExpress.XtraMap.BingGeocodeDataProvider();
            this.informationLayer2 = new DevExpress.XtraMap.InformationLayer();
            this.bingSearchDataProvider1 = new DevExpress.XtraMap.BingSearchDataProvider();
            this.informationLayer3 = new DevExpress.XtraMap.InformationLayer();
            this.bingRouteDataProvider1 = new DevExpress.XtraMap.BingRouteDataProvider();
            this.bindingSourceRoute = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biClose = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barExportItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleDataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Viewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.InvoiceLabel = new DevExpress.XtraEditors.LabelControl();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            this.LogoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForMap = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForViewer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInvoice = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).BeginInit();
            this.moduleDataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            this.SuspendLayout();
            this.imageTilesLayer1.DataProvider = this.bingMapDataProvider1;
            this.informationLayer1.DataProvider = this.bingGeocodeDataProvider1;
            this.bingGeocodeDataProvider1.GenerateLayerItems = false;
            this.bingGeocodeDataProvider1.MaxVisibleResultCount = 3;
            this.bingGeocodeDataProvider1.ProcessMouseEvents = true;
            this.informationLayer2.DataProvider = this.bingSearchDataProvider1;
            this.bingSearchDataProvider1.GenerateLayerItems = false;
            this.informationLayer3.DataProvider = this.bingRouteDataProvider1;
            this.informationLayer3.HighlightedItemStyle.Stroke = System.Drawing.Color.Cyan;
            this.informationLayer3.HighlightedItemStyle.StrokeWidth = 3;
            this.informationLayer3.ItemStyle.Stroke = System.Drawing.Color.Cyan;
            this.informationLayer3.ItemStyle.StrokeWidth = 3;
            this.bingRouteDataProvider1.RouteOptions.DistanceUnit = DevExpress.XtraMap.DistanceMeasureUnit.Mile;
            // 
            // bindingSourceRoute
            // 
            this.bindingSourceRoute.DataSource = typeof(DevExpress.DevAV.Presenters.RoutePoint);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.biClose,
            this.biPrint,
            this.barExportItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 12;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.Size = new System.Drawing.Size(1226, 141);
            // 
            // biClose
            // 
            this.biClose.Caption = "Close";
            this.biClose.Id = 2;
            this.biClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biClose.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg";
            this.biClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape);
            this.biClose.Name = "biClose";
            // 
            // biPrint
            // 
            this.biPrint.Caption = "Print";
            this.biPrint.Id = 8;
            this.biPrint.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biPrint.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg";
            this.biPrint.Name = "biPrint";
            // 
            // barExportItem
            // 
            this.barExportItem.Caption = "Export";
            this.barExportItem.Id = 11;
            this.barExportItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barExportItem.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.barExportItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg";
            this.barExportItem.ImageOptions.LargeImageIndex = 50;
            this.barExportItem.Name = "barExportItem";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HOME";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.biPrint);
            this.ribbonPageGroup5.ItemLinks.Add(this.barExportItem);
            this.ribbonPageGroup5.MergeOrder = 0;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "Print and Export";
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
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.ViewModels.OrderMapViewModel);
            // 
            // moduleDataLayout
            // 
            this.moduleDataLayout.AllowCustomization = false;
            this.moduleDataLayout.Controls.Add(this.Viewer);
            this.moduleDataLayout.Controls.Add(this.InvoiceLabel);
            this.moduleDataLayout.Controls.Add(this.mapControl);
            this.moduleDataLayout.Controls.Add(this.NameLabel);
            this.moduleDataLayout.Controls.Add(this.LogoPictureEdit);
            this.moduleDataLayout.DataSource = this.bindingSource;
            this.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleDataLayout.Location = new System.Drawing.Point(0, 141);
            this.moduleDataLayout.Name = "moduleDataLayout";
            this.moduleDataLayout.Root = this.layoutControlGroup1;
            this.moduleDataLayout.Size = new System.Drawing.Size(1226, 621);
            this.moduleDataLayout.TabIndex = 1;
            this.moduleDataLayout.Text = "moduleDataLayout";
            // 
            // Viewer
            // 
            this.Viewer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Viewer.Appearance.Options.UseBackColor = true;
            this.Viewer.Location = new System.Drawing.Point(810, 98);
            this.Viewer.MenuManager = this.ribbonControl;
            this.Viewer.MinimumSize = new System.Drawing.Size(400, 0);
            this.Viewer.Name = "Viewer";
            this.Viewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.Viewer.NavigationPanePageVisibility = DevExpress.XtraPdfViewer.PdfNavigationPanePageVisibility.None;
            this.Viewer.Size = new System.Drawing.Size(400, 513);
            this.Viewer.TabIndex = 20;
            this.Viewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
            // 
            // InvoiceLabel
            // 
            this.InvoiceLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.InvoiceLabel.Appearance.Options.UseFont = true;
            this.InvoiceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Entity.InvoiceNumber", true));
            this.InvoiceLabel.Location = new System.Drawing.Point(952, 52);
            this.InvoiceLabel.Name = "InvoiceLabel";
            this.InvoiceLabel.Size = new System.Drawing.Size(258, 20);
            this.InvoiceLabel.StyleController = this.moduleDataLayout;
            this.InvoiceLabel.TabIndex = 19;
            // 
            // mapControl
            // 
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapControl.Layers.Add(this.imageTilesLayer1);
            this.mapControl.Layers.Add(this.informationLayer1);
            this.mapControl.Layers.Add(this.informationLayer2);
            this.mapControl.Layers.Add(this.informationLayer3);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.ShowSearchPanel = false;
            this.mapControl.Size = new System.Drawing.Size(792, 621);
            this.mapControl.TabIndex = 18;
            this.mapControl.ZoomLevel = 8D;
            // 
            // NameLabel
            // 
            this.NameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.NameLabel.Appearance.Options.UseFont = true;
            this.NameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true));
            this.NameLabel.Location = new System.Drawing.Point(884, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(328, 32);
            this.NameLabel.StyleController = this.moduleDataLayout;
            this.NameLabel.TabIndex = 8;
            // 
            // LogoPictureEdit
            // 
            this.LogoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Logo", true));
            this.LogoPictureEdit.Location = new System.Drawing.Point(808, 8);
            this.LogoPictureEdit.MenuManager = this.ribbonControl;
            this.LogoPictureEdit.Name = "LogoPictureEdit";
            this.LogoPictureEdit.Properties.ReadOnly = true;
            this.LogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.LogoPictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.LogoPictureEdit.Size = new System.Drawing.Size(64, 64);
            this.LogoPictureEdit.StyleController = this.moduleDataLayout;
            this.LogoPictureEdit.TabIndex = 17;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(1226, 621);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ItemForMap
            // 
            this.ItemForMap.Control = this.mapControl;
            this.ItemForMap.CustomizationFormText = "map";
            this.ItemForMap.Location = new System.Drawing.Point(0, 0);
            this.ItemForMap.Name = "ItemForMap";
            this.ItemForMap.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForMap.Size = new System.Drawing.Size(792, 621);
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
            this.ItemForViewer});
            this.layoutControlGroup3.Location = new System.Drawing.Point(794, 86);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8);
            this.layoutControlGroup3.Size = new System.Drawing.Size(432, 535);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 0);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // ItemForViewer
            // 
            this.ItemForViewer.Control = this.Viewer;
            this.ItemForViewer.Location = new System.Drawing.Point(0, 0);
            this.ItemForViewer.Name = "ItemForViewer";
            this.ItemForViewer.Size = new System.Drawing.Size(404, 517);
            this.ItemForViewer.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForViewer.TextVisible = false;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4";
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForLogo,
            this.ItemForFullName,
            this.ItemForInvoice,
            this.emptySpaceItem2});
            this.layoutControlGroup4.Location = new System.Drawing.Point(794, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 8, 8);
            this.layoutControlGroup4.Size = new System.Drawing.Size(432, 84);
            this.layoutControlGroup4.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 2);
            this.layoutControlGroup4.TextVisible = false;
            // 
            // ItemForLogo
            // 
            this.ItemForLogo.Control = this.LogoPictureEdit;
            this.ItemForLogo.CustomizationFormText = "Logo";
            this.ItemForLogo.Location = new System.Drawing.Point(0, 0);
            this.ItemForLogo.MaxSize = new System.Drawing.Size(76, 64);
            this.ItemForLogo.MinSize = new System.Drawing.Size(76, 64);
            this.ItemForLogo.Name = "ItemForLogo";
            this.ItemForLogo.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 12, 0, 0);
            this.ItemForLogo.Size = new System.Drawing.Size(76, 66);
            this.ItemForLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForLogo.Text = "Logo";
            this.ItemForLogo.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForLogo.TextVisible = false;
            // 
            // ItemForFullName
            // 
            this.ItemForFullName.Control = this.NameLabel;
            this.ItemForFullName.CustomizationFormText = "Full Name";
            this.ItemForFullName.Location = new System.Drawing.Point(76, 0);
            this.ItemForFullName.Name = "ItemForFullName";
            this.ItemForFullName.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForFullName.Size = new System.Drawing.Size(328, 32);
            this.ItemForFullName.Text = "Full Name";
            this.ItemForFullName.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForFullName.TextVisible = false;
            // 
            // ItemForInvoice
            // 
            this.ItemForInvoice.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ItemForInvoice.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForInvoice.Control = this.InvoiceLabel;
            this.ItemForInvoice.Location = new System.Drawing.Point(76, 42);
            this.ItemForInvoice.Name = "ItemForInvoice";
            this.ItemForInvoice.Size = new System.Drawing.Size(328, 24);
            this.ItemForInvoice.Text = "Invoice #";
            this.ItemForInvoice.TextSize = new System.Drawing.Size(60, 20);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(76, 32);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.emptySpaceItem2.Size = new System.Drawing.Size(328, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(794, 84);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(432, 2);
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.CustomizationFormText = "simpleSeparator2";
            this.simpleSeparator2.Location = new System.Drawing.Point(792, 0);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(2, 621);
            // 
            // OrderMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleDataLayout);
            this.Controls.Add(this.ribbonControl);
            this.Name = "OrderMapView";
            this.Size = new System.Drawing.Size(1226, 762);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).EndInit();
            this.moduleDataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.BarButtonItem biClose;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraDataLayout.DataLayoutControl moduleDataLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource bindingSource;
        private XtraEditors.LabelControl NameLabel;
        private XtraEditors.PictureEdit LogoPictureEdit;
        private DevExpress.XtraMap.MapControl mapControl;
        private System.Windows.Forms.BindingSource bindingSourceRoute;
        private XtraBars.BarButtonItem biPrint;
        private XtraBars.BarButtonItem barExportItem;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraLayout.LayoutControlItem ItemForMap;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlGroup layoutControlGroup4;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem ItemForLogo;
        private XtraLayout.LayoutControlItem ItemForFullName;
        private XtraLayout.SimpleSeparator simpleSeparator1;
        private XtraLayout.SimpleSeparator simpleSeparator2;
        private XtraMap.ImageLayer imageTilesLayer1;
        private XtraMap.BingMapDataProvider bingMapDataProvider1;
        private XtraMap.InformationLayer informationLayer1;
        private XtraMap.BingGeocodeDataProvider bingGeocodeDataProvider1;
        private XtraMap.InformationLayer informationLayer2;
        private XtraMap.BingSearchDataProvider bingSearchDataProvider1;
        private XtraMap.InformationLayer informationLayer3;
        private XtraMap.BingRouteDataProvider bingRouteDataProvider1;
        private XtraPdfViewer.PdfViewer Viewer;
        private XtraEditors.LabelControl InvoiceLabel;
        private XtraLayout.LayoutControlItem ItemForViewer;
        private XtraLayout.LayoutControlItem ItemForInvoice;
    }
}