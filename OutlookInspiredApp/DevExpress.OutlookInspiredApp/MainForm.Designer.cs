namespace DevExpress.DevAV {
    partial class MainForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.SlideFadeTransition slideFadeTransition1 = new DevExpress.Utils.Animation.SlideFadeTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.modulesContainer = new DevExpress.XtraEditors.XtraUserControl();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.notificationManager = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.overviewControl = new DevExpress.DevAV.Modules.OverviewControl();
            this.officeNavigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewClientControl3 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.tabBackstageViewAbout = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.tabBackstageViewExport = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.tabBackstageViewPrint = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.biBackstageViewGetStarted = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.biBackstageViewGetSupport = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.biBackstageViewBuyNow = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.barNavigationItem = new DevExpress.XtraBars.BarSubItem();
            this.biFolderPaneSubItem = new DevExpress.XtraBars.BarSubItem();
            this.bmiFolderNormal = new DevExpress.XtraBars.BarCheckItem();
            this.bmiFolderMinimized = new DevExpress.XtraBars.BarCheckItem();
            this.bmiFolderOff = new DevExpress.XtraBars.BarCheckItem();
            this.biGetStarted = new DevExpress.XtraBars.BarButtonItem();
            this.biGetSupport = new DevExpress.XtraBars.BarButtonItem();
            this.biBuyNow = new DevExpress.XtraBars.BarButtonItem();
            this.biAbout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiNormal = new DevExpress.XtraBars.BarCheckItem();
            this.beZoomLevel = new DevExpress.XtraBars.BarEditItem();
            this.zoomLevelTrackBar = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.bbiReading = new DevExpress.XtraBars.BarCheckItem();
            this.bbiZoomDialog = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.transitionManager = new DevExpress.Utils.Animation.TransitionManager(this.components);
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.modulesContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl)).BeginInit();
            this.backstageViewControl.SuspendLayout();
            this.backstageViewClientControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevelTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // modulesContainer
            // 
            this.modulesContainer.Controls.Add(this.navBar);
            this.modulesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modulesContainer.Location = new System.Drawing.Point(0, 143);
            this.modulesContainer.Margin = new System.Windows.Forms.Padding(24, 23, 24, 3);
            this.modulesContainer.Name = "modulesContainer";
            this.modulesContainer.Size = new System.Drawing.Size(1368, 604);
            this.modulesContainer.TabIndex = 2;
            // 
            // navBar
            // 
            this.navBar.AllowHorizontalResizing = DevExpress.Utils.DefaultBoolean.True;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.CollapsedWidth = 41;
            this.navBar.OptionsNavPane.ExpandedWidth = 225;
            this.navBar.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBar.Size = new System.Drawing.Size(225, 604);
            this.navBar.TabIndex = 5;
            this.navBar.Text = "navBarControl1";
            // 
            // notificationManager
            // 
            this.notificationManager.ApplicationId = "devenv";
            this.notificationManager.ApplicationName = "DevAV";
            this.notificationManager.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf013", global::DevExpress.DevAV.Properties.Resources.reports_360x664, null, global::DevExpress.DevAV.Properties.Resources.reports_96x96, null, null, null, "DevAV Tips & Tricks", "Become a UI Superhero, check out", "our WYSIWYG Reporting in the Sales Module", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Default, null, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf014", global::DevExpress.DevAV.Properties.Resources.map_360x664, null, global::DevExpress.DevAV.Properties.Resources.Map96x96, null, null, null, "DevAV Tips & Tricks", "Become a UI Superhero, take users ", "where they want to go with DevExpress Maps", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Default, null, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf015", global::DevExpress.DevAV.Properties.Resources.pdf_360x664, null, global::DevExpress.DevAV.Properties.Resources.pdf_96x96, null, null, null, "DevAV Tips & Tricks", "Become a UI Superhero, explore", "PDF-documents with DevExpress PDF Viewer", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Default, null, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf016", global::DevExpress.DevAV.Properties.Resources.Spreadsheet_360x664, null, global::DevExpress.DevAV.Properties.Resources.Spreadsheet_96x96, null, null, null, "DevAV Tips & Tricks", "Become a UI Superhero, check out our", "straightforward and easy-to-use Spreadsheet", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Default, null, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.Default, DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic)});
            // 
            // overviewControl
            // 
            this.overviewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewControl.Location = new System.Drawing.Point(0, 0);
            this.overviewControl.Name = "overviewControl";
            this.overviewControl.Size = new System.Drawing.Size(1235, 540);
            this.overviewControl.TabIndex = 0;
            // 
            // officeNavigationBar
            // 
            this.officeNavigationBar.AllowDrag = true;
            this.officeNavigationBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar.Location = new System.Drawing.Point(0, 747);
            this.officeNavigationBar.MenuManager = this.ribbonControl;
            this.officeNavigationBar.MinimumSize = new System.Drawing.Size(0, 21);
            this.officeNavigationBar.Name = "officeNavigationBar";
            this.officeNavigationBar.OptionsPeekFormButtonPanel.AllowGlyphSkinning = true;
            buttonImageOptions1.Image = global::DevExpress.DevAV.Properties.Resources.icon_docking_16;
            this.officeNavigationBar.OptionsPeekFormButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("", false, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.officeNavigationBar.OptionsPeekFormButtonPanel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.officeNavigationBar.OptionsPeekFormButtonPanel.ShowButtonPanel = true;
            this.officeNavigationBar.PeekFormSize = new System.Drawing.Size(250, 350);
            this.officeNavigationBar.Size = new System.Drawing.Size(1368, 21);
            this.officeNavigationBar.TabIndex = 3;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.backstageViewControl;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barNavigationItem,
            this.biFolderPaneSubItem,
            this.bmiFolderNormal,
            this.bmiFolderMinimized,
            this.bmiFolderOff,
            this.biGetStarted,
            this.biGetSupport,
            this.biBuyNow,
            this.biAbout,
            this.bbiNormal,
            this.beZoomLevel,
            this.bbiReading,
            this.bbiZoomDialog,
            this.skinDropDownButtonItem1,
            this.skinPaletteRibbonGalleryBarItem1});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 16;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsTouch.ShowTouchUISelectorInQAT = true;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.zoomLevelTrackBar});
            this.ribbonControl.Size = new System.Drawing.Size(1368, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // backstageViewControl
            // 
            this.backstageViewControl.Controls.Add(this.backstageViewClientControl1);
            this.backstageViewControl.Controls.Add(this.backstageViewClientControl2);
            this.backstageViewControl.Controls.Add(this.backstageViewClientControl3);
            this.backstageViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backstageViewControl.Items.Add(this.tabBackstageViewAbout);
            this.backstageViewControl.Items.Add(this.tabBackstageViewExport);
            this.backstageViewControl.Items.Add(this.tabBackstageViewPrint);
            this.backstageViewControl.Items.Add(this.backstageViewItemSeparator1);
            this.backstageViewControl.Items.Add(this.biBackstageViewGetStarted);
            this.backstageViewControl.Items.Add(this.biBackstageViewGetSupport);
            this.backstageViewControl.Items.Add(this.biBackstageViewBuyNow);
            this.backstageViewControl.Location = new System.Drawing.Point(0, 143);
            this.backstageViewControl.Name = "backstageViewControl";
            this.backstageViewControl.OwnerControl = this.ribbonControl;
            this.backstageViewControl.SelectedTab = this.tabBackstageViewAbout;
            this.backstageViewControl.SelectedTabIndex = 0;
            this.backstageViewControl.Size = new System.Drawing.Size(1368, 604);
            this.backstageViewControl.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013;
            this.backstageViewControl.TabIndex = 6;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Controls.Add(this.overviewControl);
            this.backstageViewClientControl1.Location = new System.Drawing.Point(132, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(1235, 540);
            this.backstageViewClientControl1.TabIndex = 0;
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Location = new System.Drawing.Point(132, 63);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.Size = new System.Drawing.Size(1235, 540);
            this.backstageViewClientControl2.TabIndex = 1;
            // 
            // backstageViewClientControl3
            // 
            this.backstageViewClientControl3.Location = new System.Drawing.Point(132, 63);
            this.backstageViewClientControl3.Name = "backstageViewClientControl3";
            this.backstageViewClientControl3.Size = new System.Drawing.Size(1235, 540);
            this.backstageViewClientControl3.TabIndex = 2;
            // 
            // tabBackstageViewAbout
            // 
            this.tabBackstageViewAbout.Caption = "About";
            this.tabBackstageViewAbout.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left;
            this.tabBackstageViewAbout.ContentControl = this.backstageViewClientControl1;
            this.tabBackstageViewAbout.Name = "tabBackstageViewAbout";
            this.tabBackstageViewAbout.Selected = true;
            // 
            // tabBackstageViewExport
            // 
            this.tabBackstageViewExport.Caption = "Export";
            this.tabBackstageViewExport.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left;
            this.tabBackstageViewExport.ContentControl = this.backstageViewClientControl2;
            this.tabBackstageViewExport.Name = "tabBackstageViewExport";
            // 
            // tabBackstageViewPrint
            // 
            this.tabBackstageViewPrint.Caption = "Print";
            this.tabBackstageViewPrint.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left;
            this.tabBackstageViewPrint.ContentControl = this.backstageViewClientControl3;
            this.tabBackstageViewPrint.Name = "tabBackstageViewPrint";
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // biBackstageViewGetStarted
            // 
            this.biBackstageViewGetStarted.Caption = "Get Started";
            this.biBackstageViewGetStarted.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left;
            this.biBackstageViewGetStarted.Name = "biBackstageViewGetStarted";
            // 
            // biBackstageViewGetSupport
            // 
            this.biBackstageViewGetSupport.Caption = "Get Support";
            this.biBackstageViewGetSupport.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left;
            this.biBackstageViewGetSupport.Name = "biBackstageViewGetSupport";
            // 
            // biBackstageViewBuyNow
            // 
            this.biBackstageViewBuyNow.Caption = "Buy Now";
            this.biBackstageViewBuyNow.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left;
            this.biBackstageViewBuyNow.Name = "biBackstageViewBuyNow";
            // 
            // barNavigationItem
            // 
            this.barNavigationItem.Caption = "Navigation";
            this.barNavigationItem.Id = 2;
            this.barNavigationItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barNavigationItem.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.barNavigationItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Navigation.svg";
            this.barNavigationItem.ImageOptions.LargeImageIndex = 43;
            this.barNavigationItem.Name = "barNavigationItem";
            this.barNavigationItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // biFolderPaneSubItem
            // 
            this.biFolderPaneSubItem.Caption = "Folder Pane";
            this.biFolderPaneSubItem.Id = 10;
            this.biFolderPaneSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biFolderPaneSubItem.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biFolderPaneSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.FolderPanel2.svg";
            this.biFolderPaneSubItem.ImageOptions.LargeImageIndex = 42;
            this.biFolderPaneSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bmiFolderNormal),
            new DevExpress.XtraBars.LinkPersistInfo(this.bmiFolderMinimized),
            new DevExpress.XtraBars.LinkPersistInfo(this.bmiFolderOff)});
            this.biFolderPaneSubItem.Name = "biFolderPaneSubItem";
            this.biFolderPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bmiFolderNormal
            // 
            this.bmiFolderNormal.Caption = "Normal";
            this.bmiFolderNormal.GroupIndex = 4;
            this.bmiFolderNormal.Id = 6;
            this.bmiFolderNormal.Name = "bmiFolderNormal";
            // 
            // bmiFolderMinimized
            // 
            this.bmiFolderMinimized.Caption = "Minimized";
            this.bmiFolderMinimized.GroupIndex = 4;
            this.bmiFolderMinimized.Id = 7;
            this.bmiFolderMinimized.Name = "bmiFolderMinimized";
            // 
            // bmiFolderOff
            // 
            this.bmiFolderOff.Caption = "Off";
            this.bmiFolderOff.GroupIndex = 4;
            this.bmiFolderOff.Id = 7;
            this.bmiFolderOff.Name = "bmiFolderOff";
            // 
            // biGetStarted
            // 
            this.biGetStarted.Caption = "Getting Started";
            this.biGetStarted.Id = 3;
            this.biGetStarted.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biGetStarted.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biGetStarted.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.GettingStarted.svg";
            this.biGetStarted.Name = "biGetStarted";
            // 
            // biGetSupport
            // 
            this.biGetSupport.Caption = "Get Free Support";
            this.biGetSupport.Id = 4;
            this.biGetSupport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biGetSupport.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biGetSupport.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Support.svg";
            this.biGetSupport.Name = "biGetSupport";
            // 
            // biBuyNow
            // 
            this.biBuyNow.Caption = "Buy Now";
            this.biBuyNow.Id = 5;
            this.biBuyNow.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biBuyNow.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biBuyNow.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Buy.svg";
            this.biBuyNow.Name = "biBuyNow";
            // 
            // biAbout
            // 
            this.biAbout.Caption = "About";
            this.biAbout.Id = 6;
            this.biAbout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biAbout.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biAbout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.About.svg";
            this.biAbout.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.biAbout.Name = "biAbout";
            // 
            // bbiNormal
            // 
            this.bbiNormal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiNormal.BindableChecked = true;
            this.bbiNormal.Caption = "Normal";
            this.bbiNormal.Checked = true;
            this.bbiNormal.Id = 8;
            this.bbiNormal.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bbiNormal.ImageOptions.Image = global::DevExpress.DevAV.Properties.Resources.icon_normal_bottom_16;
            this.bbiNormal.Name = "bbiNormal";
            this.bbiNormal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // beZoomLevel
            // 
            this.beZoomLevel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.beZoomLevel.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.beZoomLevel.Edit = this.zoomLevelTrackBar;
            this.beZoomLevel.EditValue = 10;
            this.beZoomLevel.EditWidth = 150;
            this.beZoomLevel.Id = 9;
            this.beZoomLevel.Name = "beZoomLevel";
            // 
            // zoomLevelTrackBar
            // 
            this.zoomLevelTrackBar.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.zoomLevelTrackBar.AllowUseMiddleValue = true;
            this.zoomLevelTrackBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.zoomLevelTrackBar.Maximum = 20;
            this.zoomLevelTrackBar.Middle = 10;
            this.zoomLevelTrackBar.Minimum = 1;
            this.zoomLevelTrackBar.Name = "zoomLevelTrackBar";
            // 
            // bbiReading
            // 
            this.bbiReading.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiReading.Caption = "Reading";
            this.bbiReading.Id = 10;
            this.bbiReading.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.bbiReading.ImageOptions.Image = global::DevExpress.DevAV.Properties.Resources.icon_reading_bottom_16;
            this.bbiReading.Name = "bbiReading";
            this.bbiReading.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bbiZoomDialog
            // 
            this.bbiZoomDialog.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiZoomDialog.Caption = "100%";
            this.bbiZoomDialog.Id = 11;
            this.bbiZoomDialog.Name = "bbiZoomDialog";
            this.bbiZoomDialog.SmallWithTextWidth = 50;
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 13;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem1.Id = 15;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "HOME";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.biGetStarted);
            this.ribbonPageGroup4.ItemLinks.Add(this.biGetSupport);
            this.ribbonPageGroup4.ItemLinks.Add(this.biBuyNow);
            this.ribbonPageGroup4.ItemLinks.Add(this.biAbout);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "DevExpress";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "VIEW";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barNavigationItem);
            this.ribbonPageGroup3.MergeOrder = 0;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Module";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.biFolderPaneSubItem);
            this.ribbonPageGroup2.MergeOrder = 1;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Layout";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem1);
            this.ribbonPageGroup1.MergeOrder = 2;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Appearance";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bbiNormal);
            this.ribbonStatusBar1.ItemLinks.Add(this.bbiReading);
            this.ribbonStatusBar1.ItemLinks.Add(this.beZoomLevel);
            this.ribbonStatusBar1.ItemLinks.Add(this.bbiZoomDialog);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 768);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1368, 31);
            // 
            // dockManager
            // 
            this.dockManager.DockingOptions.FloatOnDblClick = false;
            this.dockManager.DockingOptions.ShowAutoHideButton = false;
            this.dockManager.DockingOptions.ShowMaximizeButton = false;
            this.dockManager.Form = this.modulesContainer;
            this.dockManager.MenuManager = this.ribbonControl;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // transitionManager
            // 
            this.transitionManager.ShowWaitingIndicator = false;
            transition1.Control = this.modulesContainer;
            slideFadeTransition1.Parameters.EffectOptions = DevExpress.Utils.Animation.PushEffectOptions.FromRight;
            slideFadeTransition1.Parameters.FrameInterval = 5000;
            transition1.TransitionType = slideFadeTransition1;
            this.transitionManager.Transitions.Add(transition1);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(DevExpress.DevAV.ViewModels.MainViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 799);
            this.Controls.Add(this.backstageViewControl);
            this.Controls.Add(this.modulesContainer);
            this.Controls.Add(this.officeNavigationBar);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DevAV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.modulesContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl)).EndInit();
            this.backstageViewControl.ResumeLayout(false);
            this.backstageViewClientControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.zoomLevelTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPage ribbonPage2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraBars.Navigation.OfficeNavigationBar officeNavigationBar;
        private XtraBars.Docking.DockManager dockManager;
        private Utils.Animation.TransitionManager transitionManager;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager notificationManager;
        private DevExpress.XtraEditors.XtraUserControl modulesContainer;
        private XtraBars.BarSubItem barNavigationItem;
        private XtraNavBar.NavBarControl navBar;
        private XtraBars.BarButtonItem biGetStarted;
        private XtraBars.BarButtonItem biGetSupport;
        private XtraBars.BarButtonItem biBuyNow;
        private XtraBars.BarButtonItem biAbout;
        private XtraBars.BarSubItem biFolderPaneSubItem;
        private XtraBars.BarCheckItem bmiFolderNormal;
        private XtraBars.BarCheckItem bmiFolderMinimized;
        private XtraBars.BarCheckItem bmiFolderOff;
        private XtraBars.Ribbon.BackstageViewControl backstageViewControl;
        private XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl3;
        private XtraBars.Ribbon.BackstageViewTabItem tabBackstageViewAbout;
        private XtraBars.Ribbon.BackstageViewTabItem tabBackstageViewExport;
        private XtraBars.Ribbon.BackstageViewTabItem tabBackstageViewPrint;
        private XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private XtraBars.Ribbon.BackstageViewButtonItem biBackstageViewGetStarted;
        private XtraBars.Ribbon.BackstageViewButtonItem biBackstageViewGetSupport;
        private XtraBars.Ribbon.BackstageViewButtonItem biBackstageViewBuyNow;
        private DevExpress.DevAV.Modules.OverviewControl overviewControl;
        private XtraBars.BarCheckItem bbiNormal;
        private XtraBars.BarCheckItem bbiReading;
        private XtraBars.BarEditItem beZoomLevel;
        private XtraEditors.Repository.RepositoryItemZoomTrackBar zoomLevelTrackBar;
        private XtraBars.BarButtonItem bbiZoomDialog;
        private Utils.MVVM.MVVMContext mvvmContext;
        private XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
    }
}
