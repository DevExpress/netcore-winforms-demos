namespace DevExpress.DevAV {
    partial class ReportPrintControl {
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

                if(imagesContainer != null) {
                    imagesContainer.Dispose();
                    imagesContainer = null;
                }
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
            this.settingsPanel = new DevExpress.DevAV.SettingPanel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnOptions = new DevExpress.XtraEditors.SimpleButton();
            this.cbPrinters = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForButtonPrint = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPrinters = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOptions = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.captionLabelItem = new DevExpress.XtraLayout.SimpleLabelItem();
            this.buttonLabelItem = new DevExpress.XtraLayout.SimpleLabelItem();
            this.separator = new DevExpress.XtraLayout.SimpleSeparator();
            this.ItemForSettings = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbPrinters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForButtonPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrinters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionLabelItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.settingsPanel);
            this.moduleLayout.Controls.Add(this.btnPrint);
            this.moduleLayout.Controls.Add(this.btnOptions);
            this.moduleLayout.Controls.Add(this.cbPrinters);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.layoutControlGroup1;
            this.moduleLayout.Size = new System.Drawing.Size(310, 600);
            this.moduleLayout.TabIndex = 0;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Location = new System.Drawing.Point(40, 318);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(228, 242);
            this.settingsPanel.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::DevExpress.DevAV.Properties.Resources.icon_print_42x40;
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(40, 89);
            this.btnPrint.MaximumSize = new System.Drawing.Size(75, 75);
            this.btnPrint.MinimumSize = new System.Drawing.Size(75, 75);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 75);
            this.btnPrint.StyleController = this.moduleLayout;
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Enabled = false;
            this.btnOptions.Location = new System.Drawing.Point(40, 245);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(112, 22);
            this.btnOptions.StyleController = this.moduleLayout;
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Print Options";
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // cbPrinters
            // 
            this.cbPrinters.Location = new System.Drawing.Point(40, 217);
            this.cbPrinters.Name = "cbPrinters";
            this.cbPrinters.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPrinters.Size = new System.Drawing.Size(228, 20);
            this.cbPrinters.StyleController = this.moduleLayout;
            this.cbPrinters.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForButtonPrint,
            this.ItemForPrinters,
            this.ItemForOptions,
            this.emptySpaceItem1,
            this.captionLabelItem,
            this.buttonLabelItem,
            this.separator,
            this.ItemForSettings});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 40);
            this.layoutControlGroup1.Size = new System.Drawing.Size(310, 600);
            this.layoutControlGroup1.Text = "Root";
            // 
            // ItemForButtonPrint
            // 
            this.ItemForButtonPrint.Control = this.btnPrint;
            this.ItemForButtonPrint.CustomizationFormText = "Print";
            this.ItemForButtonPrint.Location = new System.Drawing.Point(0, 89);
            this.ItemForButtonPrint.Name = "layoutControlItem1";
            this.ItemForButtonPrint.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForButtonPrint.Size = new System.Drawing.Size(75, 75);
            this.ItemForButtonPrint.Text = "Print";
            this.ItemForButtonPrint.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForButtonPrint.TextToControlDistance = 0;
            this.ItemForButtonPrint.TextVisible = false;
            // 
            // ItemForPrinters
            // 
            this.ItemForPrinters.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemForPrinters.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForPrinters.Control = this.cbPrinters;
            this.ItemForPrinters.CustomizationFormText = "Printer";
            this.ItemForPrinters.Location = new System.Drawing.Point(0, 164);
            this.ItemForPrinters.Name = "Printer";
            this.ItemForPrinters.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 8);
            this.ItemForPrinters.Size = new System.Drawing.Size(228, 81);
            this.ItemForPrinters.Text = "Printer";
            this.ItemForPrinters.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.ItemForPrinters.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForPrinters.TextSize = new System.Drawing.Size(70, 32);
            this.ItemForPrinters.TextToControlDistance = 5;
            // 
            // ItemForOptions
            // 
            this.ItemForOptions.Control = this.btnOptions;
            this.ItemForOptions.CustomizationFormText = "layoutControlItem3";
            this.ItemForOptions.Location = new System.Drawing.Point(0, 245);
            this.ItemForOptions.Name = "layoutControlItem3";
            this.ItemForOptions.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForOptions.Size = new System.Drawing.Size(112, 22);
            this.ItemForOptions.Text = "layoutControlItem3";
            this.ItemForOptions.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForOptions.TextToControlDistance = 0;
            this.ItemForOptions.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(112, 245);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(116, 22);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // captionLabelItem
            // 
            this.captionLabelItem.AllowHotTrack = false;
            this.captionLabelItem.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionLabelItem.AppearanceItemCaption.Options.UseFont = true;
            this.captionLabelItem.CustomizationFormText = "Print";
            this.captionLabelItem.Location = new System.Drawing.Point(0, 0);
            this.captionLabelItem.Name = "simpleLabelItem1";
            this.captionLabelItem.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 24);
            this.captionLabelItem.Size = new System.Drawing.Size(228, 89);
            this.captionLabelItem.Text = "Print";
            this.captionLabelItem.TextSize = new System.Drawing.Size(114, 65);
            // 
            // buttonLabelItem
            // 
            this.buttonLabelItem.AllowHotTrack = false;
            this.buttonLabelItem.AllowHtmlStringInCaption = true;
            this.buttonLabelItem.AppearanceItemCaption.Options.UseTextOptions = true;
            this.buttonLabelItem.AppearanceItemCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.buttonLabelItem.CustomizationFormText = "Specify how you want<br>the report to be printed";
            this.buttonLabelItem.Location = new System.Drawing.Point(75, 89);
            this.buttonLabelItem.Name = "simpleLabelItem2";
            this.buttonLabelItem.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 0);
            this.buttonLabelItem.Size = new System.Drawing.Size(153, 75);
            this.buttonLabelItem.Text = "Specify how you want<br>the report to be printed";
            this.buttonLabelItem.TextSize = new System.Drawing.Size(114, 26);
            // 
            // separator
            // 
            this.separator.AllowHotTrack = false;
            this.separator.CustomizationFormText = "simpleSeparator1";
            this.separator.Location = new System.Drawing.Point(228, 0);
            this.separator.Name = "simpleSeparator1";
            this.separator.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.separator.Size = new System.Drawing.Size(42, 560);
            this.separator.Spacing = new DevExpress.XtraLayout.Utils.Padding(40, 0, 0, 0);
            this.separator.Text = "simpleSeparator1";
            // 
            // ItemForSettings
            // 
            this.ItemForSettings.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ItemForSettings.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForSettings.Control = this.settingsPanel;
            this.ItemForSettings.CustomizationFormText = "Settings";
            this.ItemForSettings.Location = new System.Drawing.Point(0, 267);
            this.ItemForSettings.Name = "ItemForSettings";
            this.ItemForSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 0);
            this.ItemForSettings.Size = new System.Drawing.Size(228, 293);
            this.ItemForSettings.Text = "Settings";
            this.ItemForSettings.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForSettings.TextSize = new System.Drawing.Size(114, 32);
            // 
            // ReportPrintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "ReportPrintControl";
            this.Size = new System.Drawing.Size(310, 600);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbPrinters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForButtonPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPrinters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionLabelItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLabelItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private XtraEditors.ImageComboBoxEdit cbPrinters;
        private DevExpress.XtraEditors.SimpleButton btnOptions;
        private DevExpress.XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem ItemForButtonPrint;
        private XtraLayout.LayoutControlItem ItemForOptions;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.SimpleLabelItem captionLabelItem;
        private XtraLayout.LayoutControlItem ItemForPrinters;
        private XtraLayout.SimpleLabelItem buttonLabelItem;
        private XtraLayout.SimpleSeparator separator;
        private SettingPanel settingsPanel;
        private XtraLayout.LayoutControlItem ItemForSettings;
    }
}
