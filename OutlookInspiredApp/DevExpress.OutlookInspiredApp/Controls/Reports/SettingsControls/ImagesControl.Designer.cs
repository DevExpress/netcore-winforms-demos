namespace DevExpress.DevAV {
    partial class ImagesControl {
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
            this.settingsLayout = new DevExpress.XtraLayout.LayoutControl();
            this.btnDisplayImages = new DevExpress.XtraEditors.CheckButton();
            this.btnHideImages = new DevExpress.XtraEditors.CheckButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).BeginInit();
            this.settingsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsLayout
            // 
            this.settingsLayout.AllowCustomization = false;
            this.settingsLayout.Controls.Add(this.btnDisplayImages);
            this.settingsLayout.Controls.Add(this.btnHideImages);
            this.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayout.Location = new System.Drawing.Point(0, 0);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Root = this.Root;
            this.settingsLayout.Size = new System.Drawing.Size(238, 232);
            this.settingsLayout.TabIndex = 3;
            // 
            // btnDisplayImages
            // 
            this.btnDisplayImages.Checked = true;
            this.btnDisplayImages.GroupIndex = 1;
            this.btnDisplayImages.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnDisplayImages.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ShowProduct.svg";
            this.btnDisplayImages.Location = new System.Drawing.Point(0, 0);
            this.btnDisplayImages.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnDisplayImages.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnDisplayImages.Name = "btnDisplayImages";
            this.btnDisplayImages.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDisplayImages.Size = new System.Drawing.Size(238, 40);
            this.btnDisplayImages.StyleController = this.settingsLayout;
            this.btnDisplayImages.TabIndex = 2;
            this.btnDisplayImages.Text = "Display Product Images";
            this.btnDisplayImages.CheckedChanged += new System.EventHandler(this.btnDisplayImages_CheckedChanged);
            // 
            // btnHideImages
            // 
            this.btnHideImages.GroupIndex = 1;
            this.btnHideImages.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnHideImages.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.HideProduct.svg";
            this.btnHideImages.Location = new System.Drawing.Point(0, 40);
            this.btnHideImages.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnHideImages.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnHideImages.Name = "btnHideImages";
            this.btnHideImages.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnHideImages.Size = new System.Drawing.Size(238, 40);
            this.btnHideImages.StyleController = this.settingsLayout;
            this.btnHideImages.TabIndex = 2;
            this.btnHideImages.TabStop = false;
            this.btnHideImages.Text = "Hide Product Images";
            this.btnHideImages.CheckedChanged += new System.EventHandler(this.btnHideImages_CheckedChanged);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(238, 232);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnDisplayImages;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(238, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnHideImages;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 192);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ImagesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsLayout);
            this.Name = "ImagesControl";
            this.Size = new System.Drawing.Size(238, 232);
            ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).EndInit();
            this.settingsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl settingsLayout;
        private XtraEditors.CheckButton btnDisplayImages;
        private XtraEditors.CheckButton btnHideImages;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
