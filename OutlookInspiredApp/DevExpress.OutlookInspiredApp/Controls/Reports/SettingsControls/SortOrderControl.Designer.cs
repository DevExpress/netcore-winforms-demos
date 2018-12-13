namespace DevExpress.DevAV {
    partial class SortOrderControl {
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
            this.btnAscendingOrder = new DevExpress.XtraEditors.CheckButton();
            this.btnDescendingOrder = new DevExpress.XtraEditors.CheckButton();
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
            this.settingsLayout.Controls.Add(this.btnAscendingOrder);
            this.settingsLayout.Controls.Add(this.btnDescendingOrder);
            this.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayout.Location = new System.Drawing.Point(0, 0);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Root = this.Root;
            this.settingsLayout.Size = new System.Drawing.Size(238, 232);
            this.settingsLayout.TabIndex = 3;
            // 
            // btnAscendingOrder
            // 
            this.btnAscendingOrder.Checked = true;
            this.btnAscendingOrder.GroupIndex = 1;
            this.btnAscendingOrder.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnAscendingOrder.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortDesc.svg";
            this.btnAscendingOrder.Location = new System.Drawing.Point(0, 0);
            this.btnAscendingOrder.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnAscendingOrder.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnAscendingOrder.Name = "btnAscendingOrder";
            this.btnAscendingOrder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAscendingOrder.Size = new System.Drawing.Size(238, 40);
            this.btnAscendingOrder.StyleController = this.settingsLayout;
            this.btnAscendingOrder.TabIndex = 2;
            this.btnAscendingOrder.Text = "Ascending Order";
            this.btnAscendingOrder.CheckedChanged += new System.EventHandler(this.btnAscendingOrder_CheckedChanged);
            // 
            // btnDescendingOrder
            // 
            this.btnDescendingOrder.GroupIndex = 1;
            this.btnDescendingOrder.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnDescendingOrder.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SortAsc.svg";
            this.btnDescendingOrder.Location = new System.Drawing.Point(0, 40);
            this.btnDescendingOrder.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnDescendingOrder.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnDescendingOrder.Name = "btnDescendingOrder";
            this.btnDescendingOrder.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDescendingOrder.Size = new System.Drawing.Size(238, 40);
            this.btnDescendingOrder.StyleController = this.settingsLayout;
            this.btnDescendingOrder.TabIndex = 2;
            this.btnDescendingOrder.TabStop = false;
            this.btnDescendingOrder.Text = "Descending Order";
            this.btnDescendingOrder.CheckedChanged += new System.EventHandler(this.btnDescendingOrder_CheckedChanged);
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
            this.layoutControlItem1.Control = this.btnAscendingOrder;
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
            this.layoutControlItem2.Control = this.btnDescendingOrder;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 192);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // SortOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsLayout);
            this.Name = "SortOrderControl";
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
        private XtraEditors.CheckButton btnAscendingOrder;
        private XtraEditors.CheckButton btnDescendingOrder;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
