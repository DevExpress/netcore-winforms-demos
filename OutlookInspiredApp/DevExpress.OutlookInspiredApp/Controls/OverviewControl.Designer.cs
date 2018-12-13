namespace DevExpress.DevAV.Modules {
    partial class OverviewControl {
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
            this.buttonsPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.logo = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.descriptionLabel = new DevExpress.XtraEditors.LabelControl();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AllowGlyphSkinning = false;
            this.buttonsPanel.AppearanceButton.Hovered.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonsPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.buttonsPanel.AppearanceButton.Normal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonsPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.buttonsPanel.AppearanceButton.Pressed.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.buttonsPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.buttonsPanel.ButtonInterval = 40;
            this.buttonsPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Getting Started", global::DevExpress.DevAV.Properties.Resources.Overview_GettingStarted, -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Free Support", global::DevExpress.DevAV.Properties.Resources.Overview_FreeSupport, -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Buy Now", global::DevExpress.DevAV.Properties.Resources.Overview_Buy, -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1)});
            this.buttonsPanel.Location = new System.Drawing.Point(24, 477);
            this.buttonsPanel.MaximumSize = new System.Drawing.Size(0, 128);
            this.buttonsPanel.MinimumSize = new System.Drawing.Size(0, 128);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1032, 128);
            this.buttonsPanel.TabIndex = 3;
            this.buttonsPanel.UseButtonBackgroundImages = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.ItemForDescription,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(24, 24, 24, 24);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1080, 710);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.logo;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 581);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(1032, 81);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // logo
            // 
            this.logo.EditValue = global::DevExpress.DevAV.Properties.Resources.Overview_Logo;
            this.logo.Location = new System.Drawing.Point(24, 605);
            this.logo.Name = "logo";
            this.logo.Properties.AllowFocused = false;
            this.logo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.logo.Properties.Appearance.Options.UseBackColor = true;
            this.logo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.logo.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.logo.Properties.ShowMenu = false;
            this.logo.Size = new System.Drawing.Size(1032, 81);
            this.logo.StyleController = this.layoutControl1;
            this.logo.TabIndex = 16;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.buttonsPanel);
            this.layoutControl1.Controls.Add(this.descriptionLabel);
            this.layoutControl1.Controls.Add(this.logo);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1080, 710);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AllowHtmlString = true;
            this.descriptionLabel.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.descriptionLabel.Appearance.Image = global::DevExpress.DevAV.Properties.Resources.Jolt_Logo;
            this.descriptionLabel.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.descriptionLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.descriptionLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.descriptionLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.descriptionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.descriptionLabel.Location = new System.Drawing.Point(24, 24);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(1032, 453);
            this.descriptionLabel.StyleController = this.layoutControl1;
            this.descriptionLabel.TabIndex = 16;
            this.descriptionLabel.Text = "UI SuperHero";
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.descriptionLabel;
            this.ItemForDescription.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ItemForDescription.CustomizationFormText = "layoutControlItem2";
            this.ItemForDescription.Location = new System.Drawing.Point(0, 0);
            this.ItemForDescription.MinSize = new System.Drawing.Size(1, 1);
            this.ItemForDescription.Name = "layoutControlItem2";
            this.ItemForDescription.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForDescription.Size = new System.Drawing.Size(1032, 453);
            this.ItemForDescription.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForDescription.Text = "layoutControlItem2";
            this.ItemForDescription.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForDescription.TextToControlDistance = 0;
            this.ItemForDescription.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.buttonsPanel;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 453);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(1032, 128);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // OverviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "OverviewControl";
            this.Size = new System.Drawing.Size(1080, 710);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraEditors.PictureEdit logo;
        private XtraEditors.LabelControl descriptionLabel;
        private XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonsPanel;
        private XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
