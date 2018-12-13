namespace DevExpress.DevAV {
    partial class ReportExportControl {
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
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.btnExport = new DevExpress.XtraEditors.DropDownButton();
            this.settingsPanel = new DevExpress.DevAV.SettingPanel();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.captionLabelItem = new DevExpress.XtraLayout.SimpleLabelItem();
            this.ItemForSettings = new DevExpress.XtraLayout.LayoutControlItem();
            this.separator = new DevExpress.XtraLayout.SimpleSeparator();
            this.ItemForButtonExport = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonLabelItem = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionLabelItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForButtonExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.btnExport);
            this.moduleLayout.Controls.Add(this.settingsPanel);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.layoutControlGroup1;
            this.moduleLayout.Size = new System.Drawing.Size(310, 600);
            this.moduleLayout.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnExport.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnExport.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg";
            this.btnExport.Location = new System.Drawing.Point(40, 89);
            this.btnExport.MaximumSize = new System.Drawing.Size(75, 75);
            this.btnExport.MinimumSize = new System.Drawing.Size(75, 75);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 75);
            this.btnExport.StyleController = this.moduleLayout;
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(40, 215);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(228, 345);
            this.settingsPanel.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.captionLabelItem,
            this.ItemForSettings,
            this.separator,
            this.ItemForButtonExport,
            this.buttonLabelItem});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 40);
            this.layoutControlGroup1.Size = new System.Drawing.Size(310, 600);
            // 
            // captionLabelItem
            // 
            this.captionLabelItem.AllowHotTrack = false;
            this.captionLabelItem.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLabelItem.AppearanceItemCaption.Options.UseFont = true;
            this.captionLabelItem.CustomizationFormText = "Export";
            this.captionLabelItem.Location = new System.Drawing.Point(0, 0);
            this.captionLabelItem.Name = "captionLabelItem";
            this.captionLabelItem.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 24);
            this.captionLabelItem.Size = new System.Drawing.Size(228, 89);
            this.captionLabelItem.Text = "Export";
            this.captionLabelItem.TextSize = new System.Drawing.Size(138, 65);
            // 
            // ItemForSettings
            // 
            this.ItemForSettings.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ItemForSettings.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForSettings.Control = this.settingsPanel;
            this.ItemForSettings.CustomizationFormText = "Settings";
            this.ItemForSettings.Location = new System.Drawing.Point(0, 164);
            this.ItemForSettings.Name = "ItemForSettings";
            this.ItemForSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 0);
            this.ItemForSettings.Size = new System.Drawing.Size(228, 396);
            this.ItemForSettings.Text = "Settings";
            this.ItemForSettings.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForSettings.TextSize = new System.Drawing.Size(138, 32);
            // 
            // separator
            // 
            this.separator.AllowHotTrack = false;
            this.separator.CustomizationFormText = "separator";
            this.separator.Location = new System.Drawing.Point(228, 0);
            this.separator.Name = "separator";
            this.separator.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.separator.Size = new System.Drawing.Size(42, 560);
            this.separator.Spacing = new DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 0);
            // 
            // ItemForButtonExport
            // 
            this.ItemForButtonExport.Control = this.btnExport;
            this.ItemForButtonExport.CustomizationFormText = "ItemForButtonExport";
            this.ItemForButtonExport.Location = new System.Drawing.Point(0, 89);
            this.ItemForButtonExport.Name = "ItemForButtonExport";
            this.ItemForButtonExport.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForButtonExport.Size = new System.Drawing.Size(75, 75);
            this.ItemForButtonExport.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForButtonExport.TextVisible = false;
            // 
            // buttonLabelItem
            // 
            this.buttonLabelItem.AllowHotTrack = false;
            this.buttonLabelItem.AllowHtmlStringInCaption = true;
            this.buttonLabelItem.AppearanceItemCaption.Options.UseTextOptions = true;
            this.buttonLabelItem.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.buttonLabelItem.CustomizationFormText = "Specify how you want<br>the report to be printed";
            this.buttonLabelItem.Location = new System.Drawing.Point(75, 89);
            this.buttonLabelItem.Name = "buttonLabelItem";
            this.buttonLabelItem.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0);
            this.buttonLabelItem.Size = new System.Drawing.Size(153, 75);
            this.buttonLabelItem.Text = "The DevExpress Reporting<br>platform allows you to<br>export any report to<br>PDF" +
    ", XLS, RTF and countless<br>image file formats.";
            this.buttonLabelItem.TextSize = new System.Drawing.Size(138, 65);
            // 
            // ReportExportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "ReportExportControl";
            this.Size = new System.Drawing.Size(310, 600);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionLabelItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForButtonExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private XtraLayout.LayoutControl moduleLayout;
        private SettingPanel settingsPanel;
        private XtraEditors.DropDownButton btnExport;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.SimpleLabelItem captionLabelItem;
        private XtraLayout.SimpleLabelItem buttonLabelItem;
        private XtraLayout.LayoutControlItem ItemForSettings;
        private XtraLayout.SimpleSeparator separator;
        private XtraLayout.LayoutControlItem ItemForButtonExport;
    }
}
