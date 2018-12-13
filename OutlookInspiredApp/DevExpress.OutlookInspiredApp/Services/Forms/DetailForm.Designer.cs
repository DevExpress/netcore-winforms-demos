namespace DevExpress.DevAV {
    partial class DetailForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biGetStarted = new DevExpress.XtraBars.BarButtonItem();
            this.biGetSupport = new DevExpress.XtraBars.BarButtonItem();
            this.biBuyNow = new DevExpress.XtraBars.BarButtonItem();
            this.biAbout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.biGetStarted,
            this.biGetSupport,
            this.biBuyNow,
            this.biAbout});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsTouch.ShowTouchUISelectorInQAT = true;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1004, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.TransparentEditors = true;
            // 
            // biGetStarted
            // 
            this.biGetStarted.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biGetStarted.Caption = "Getting Started";
            this.biGetStarted.Id = 1;
            this.biGetStarted.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biGetStarted.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.GettingStarted.svg";
            this.biGetStarted.Name = "biGetStarted";
            // 
            // biGetSupport
            // 
            this.biGetSupport.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biGetSupport.Caption = "Get Free Support";
            this.biGetSupport.Id = 2;
            this.biGetSupport.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biGetSupport.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Support.svg";
            this.biGetSupport.Name = "biGetSupport";
            // 
            // biBuyNow
            // 
            this.biBuyNow.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biBuyNow.Caption = "Buy Now";
            this.biBuyNow.Id = 3;
            this.biBuyNow.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biBuyNow.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Buy.svg";
            this.biBuyNow.Name = "biBuyNow";
            // 
            // biAbout
            // 
            this.biAbout.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biAbout.Caption = "About";
            this.biAbout.Id = 4;
            this.biAbout.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biAbout.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.About.svg";
            this.biAbout.Name = "biAbout";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "DX";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.biGetStarted);
            this.ribbonPageGroup1.ItemLinks.Add(this.biGetSupport);
            this.ribbonPageGroup1.ItemLinks.Add(this.biBuyNow);
            this.ribbonPageGroup1.ItemLinks.Add(this.biAbout);
            this.ribbonPageGroup1.MergeOrder = 1;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "DevExpress";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 767);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1004, 31);
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 798);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailForm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "DevAV";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.BarButtonItem biGetStarted;
        private XtraBars.BarButtonItem biGetSupport;
        private XtraBars.BarButtonItem biBuyNow;
        private XtraBars.BarButtonItem biAbout;
    }
}