namespace DevExpress.DevAV {
    partial class SortFilterControl {
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
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.btnOrderDate = new DevExpress.XtraEditors.CheckButton();
            this.btnInvoice = new DevExpress.XtraEditors.CheckButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).BeginInit();
            this.settingsLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsLayout
            // 
            this.settingsLayout.AllowCustomization = false;
            this.settingsLayout.Controls.Add(this.dateEdit2);
            this.settingsLayout.Controls.Add(this.dateEdit1);
            this.settingsLayout.Controls.Add(this.btnOrderDate);
            this.settingsLayout.Controls.Add(this.btnInvoice);
            this.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayout.Location = new System.Drawing.Point(0, 0);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Root = this.Root;
            this.settingsLayout.Size = new System.Drawing.Size(238, 232);
            this.settingsLayout.TabIndex = 3;
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dateEdit2.Location = new System.Drawing.Point(0, 160);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(238, 20);
            this.dateEdit2.StyleController = this.settingsLayout;
            this.dateEdit2.TabIndex = 5;
            this.dateEdit2.DateTimeChanged += new System.EventHandler(this.dateEdit2_DateTimeChanged);
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
            this.dateEdit1.Location = new System.Drawing.Point(0, 132);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(238, 20);
            this.dateEdit1.StyleController = this.settingsLayout;
            this.dateEdit1.TabIndex = 4;
            this.dateEdit1.DateTimeChanged += new System.EventHandler(this.dateEdit1_DateTimeChanged);
            // 
            // btnOrderDate
            // 
            this.btnOrderDate.Checked = true;
            this.btnOrderDate.GroupIndex = 1;
            this.btnOrderDate.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnOrderDate.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortByOrderDate.svg";
            this.btnOrderDate.Location = new System.Drawing.Point(0, 0);
            this.btnOrderDate.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnOrderDate.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnOrderDate.Name = "btnOrderDate";
            this.btnOrderDate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnOrderDate.Size = new System.Drawing.Size(238, 40);
            this.btnOrderDate.StyleController = this.settingsLayout;
            this.btnOrderDate.TabIndex = 2;
            this.btnOrderDate.Text = "Sort by Order Date";
            this.btnOrderDate.CheckedChanged += new System.EventHandler(this.btnOrderDate_CheckedChanged);
            // 
            // btnInvoice
            // 
            this.btnInvoice.GroupIndex = 1;
            this.btnInvoice.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnInvoice.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortByInvoice.svg";
            this.btnInvoice.Location = new System.Drawing.Point(0, 40);
            this.btnInvoice.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnInvoice.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnInvoice.Size = new System.Drawing.Size(238, 40);
            this.btnInvoice.StyleController = this.settingsLayout;
            this.btnInvoice.TabIndex = 2;
            this.btnInvoice.TabStop = false;
            this.btnInvoice.Text = "Sort by Invoice #";
            this.btnInvoice.CheckedChanged += new System.EventHandler(this.btnInvoice_CheckedChanged);
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.simpleLabelItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(238, 232);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnOrderDate;
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
            this.layoutControlItem2.Control = this.btnInvoice;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.CustomizationFormText = "Range";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 80);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 16, 0);
            this.simpleLabelItem1.Size = new System.Drawing.Size(238, 48);
            this.simpleLabelItem1.Text = "Range";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(67, 32);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dateEdit1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 4);
            this.layoutControlItem3.Size = new System.Drawing.Size(238, 28);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dateEdit2;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 156);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 4, 0);
            this.layoutControlItem4.Size = new System.Drawing.Size(238, 76);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // SortFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsLayout);
            this.Name = "SortFilterControl";
            this.Size = new System.Drawing.Size(238, 232);
            ((System.ComponentModel.ISupportInitialize)(this.settingsLayout)).EndInit();
            this.settingsLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl settingsLayout;
        private XtraEditors.CheckButton btnOrderDate;
        private XtraEditors.CheckButton btnInvoice;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.SimpleLabelItem simpleLabelItem1;
        private XtraEditors.DateEdit dateEdit2;
        private XtraEditors.DateEdit dateEdit1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
