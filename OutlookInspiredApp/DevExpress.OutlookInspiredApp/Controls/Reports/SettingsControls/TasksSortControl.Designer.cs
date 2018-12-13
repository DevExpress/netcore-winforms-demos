namespace DevExpress.DevAV {
    partial class TasksSortControl {
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
            this.btnDueDate = new DevExpress.XtraEditors.CheckButton();
            this.btnStartDate = new DevExpress.XtraEditors.CheckButton();
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
            this.settingsLayout.Controls.Add(this.btnDueDate);
            this.settingsLayout.Controls.Add(this.btnStartDate);
            this.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayout.Location = new System.Drawing.Point(0, 0);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Root = this.Root;
            this.settingsLayout.Size = new System.Drawing.Size(238, 232);
            this.settingsLayout.TabIndex = 3;
            // 
            // btnDueDate
            // 
            this.btnDueDate.Checked = true;
            this.btnDueDate.GroupIndex = 1;
            this.btnDueDate.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnDueDate.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ShowDueDate.svg";
            this.btnDueDate.Location = new System.Drawing.Point(0, 0);
            this.btnDueDate.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnDueDate.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnDueDate.Name = "btnDueDate";
            this.btnDueDate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnDueDate.Size = new System.Drawing.Size(238, 40);
            this.btnDueDate.StyleController = this.settingsLayout;
            this.btnDueDate.TabIndex = 2;
            this.btnDueDate.Text = "Sort by Due Date";
            this.btnDueDate.CheckedChanged += new System.EventHandler(this.btnDueDate_CheckedChanged);
            // 
            // btnStartDate
            // 
            this.btnStartDate.GroupIndex = 1;
            this.btnStartDate.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnStartDate.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ShowStartDate.svg";
            this.btnStartDate.Location = new System.Drawing.Point(0, 40);
            this.btnStartDate.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnStartDate.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnStartDate.Name = "btnStartDate";
            this.btnStartDate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnStartDate.Size = new System.Drawing.Size(238, 40);
            this.btnStartDate.StyleController = this.settingsLayout;
            this.btnStartDate.TabIndex = 2;
            this.btnStartDate.TabStop = false;
            this.btnStartDate.Text = "Sort by Start Date";
            this.btnStartDate.CheckedChanged += new System.EventHandler(this.btnStartDate_CheckedChanged);
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
            this.layoutControlItem1.Control = this.btnDueDate;
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
            this.layoutControlItem2.Control = this.btnStartDate;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 192);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // TasksSortControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsLayout);
            this.Name = "TasksSortControl";
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
        private XtraEditors.CheckButton btnDueDate;
        private XtraEditors.CheckButton btnStartDate;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
