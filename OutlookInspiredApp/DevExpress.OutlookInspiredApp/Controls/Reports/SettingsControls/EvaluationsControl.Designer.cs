namespace DevExpress.DevAV {
    partial class EvaluationsControl {
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
            this.btnIncludeEvaluations = new DevExpress.XtraEditors.CheckButton();
            this.btnExcludeEvaluations = new DevExpress.XtraEditors.CheckButton();
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
            this.settingsLayout.Controls.Add(this.btnIncludeEvaluations);
            this.settingsLayout.Controls.Add(this.btnExcludeEvaluations);
            this.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayout.Location = new System.Drawing.Point(0, 0);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Root = this.Root;
            this.settingsLayout.Size = new System.Drawing.Size(238, 232);
            this.settingsLayout.TabIndex = 3;
            // 
            // btnIncludeEvaluations
            // 
            this.btnIncludeEvaluations.Checked = true;
            this.btnIncludeEvaluations.GroupIndex = 1;
            this.btnIncludeEvaluations.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnIncludeEvaluations.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintIncludeEvaluations.svg";
            this.btnIncludeEvaluations.Location = new System.Drawing.Point(0, 0);
            this.btnIncludeEvaluations.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnIncludeEvaluations.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnIncludeEvaluations.Name = "btnIncludeEvaluations";
            this.btnIncludeEvaluations.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnIncludeEvaluations.Size = new System.Drawing.Size(238, 40);
            this.btnIncludeEvaluations.StyleController = this.settingsLayout;
            this.btnIncludeEvaluations.TabIndex = 2;
            this.btnIncludeEvaluations.Text = "Include Evaluations";
            this.btnIncludeEvaluations.CheckedChanged += new System.EventHandler(this.btnAscendingOrder_CheckedChanged);
            // 
            // btnExcludeEvaluations
            // 
            this.btnExcludeEvaluations.GroupIndex = 1;
            this.btnExcludeEvaluations.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnExcludeEvaluations.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintExcludeEvaluations.svg";
            this.btnExcludeEvaluations.Location = new System.Drawing.Point(0, 40);
            this.btnExcludeEvaluations.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnExcludeEvaluations.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnExcludeEvaluations.Name = "btnExcludeEvaluations";
            this.btnExcludeEvaluations.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExcludeEvaluations.Size = new System.Drawing.Size(238, 40);
            this.btnExcludeEvaluations.StyleController = this.settingsLayout;
            this.btnExcludeEvaluations.TabIndex = 2;
            this.btnExcludeEvaluations.TabStop = false;
            this.btnExcludeEvaluations.Text = "Exclude Evaluations";
            this.btnExcludeEvaluations.CheckedChanged += new System.EventHandler(this.btnDescendingOrder_CheckedChanged);
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
            this.layoutControlItem1.Control = this.btnIncludeEvaluations;
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
            this.layoutControlItem2.Control = this.btnExcludeEvaluations;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 192);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // EvaluationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsLayout);
            this.Name = "EvaluationsControl";
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
        private XtraEditors.CheckButton btnIncludeEvaluations;
        private XtraEditors.CheckButton btnExcludeEvaluations;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
