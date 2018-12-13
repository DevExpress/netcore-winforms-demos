namespace DevExpress.DevAV {
    partial class ContactsControl {
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
            this.btnIncludeContacts = new DevExpress.XtraEditors.CheckButton();
            this.btnExcludeContacts = new DevExpress.XtraEditors.CheckButton();
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
            this.settingsLayout.Controls.Add(this.btnIncludeContacts);
            this.settingsLayout.Controls.Add(this.btnExcludeContacts);
            this.settingsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsLayout.Location = new System.Drawing.Point(0, 0);
            this.settingsLayout.Name = "settingsLayout";
            this.settingsLayout.Root = this.Root;
            this.settingsLayout.Size = new System.Drawing.Size(238, 232);
            this.settingsLayout.TabIndex = 3;
            // 
            // btnIncludeContacts
            // 
            this.btnIncludeContacts.Checked = true;
            this.btnIncludeContacts.GroupIndex = 1;
            this.btnIncludeContacts.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnIncludeContacts.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintIncludeEvaluations.svg";
            this.btnIncludeContacts.Location = new System.Drawing.Point(0, 0);
            this.btnIncludeContacts.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnIncludeContacts.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnIncludeContacts.Name = "btnIncludeContacts";
            this.btnIncludeContacts.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnIncludeContacts.Size = new System.Drawing.Size(238, 40);
            this.btnIncludeContacts.StyleController = this.settingsLayout;
            this.btnIncludeContacts.TabIndex = 2;
            this.btnIncludeContacts.Text = "Include Contacts";
            this.btnIncludeContacts.CheckedChanged += new System.EventHandler(this.btnIncludeContacts_CheckedChanged);
            // 
            // btnExcludeContacts
            // 
            this.btnExcludeContacts.GroupIndex = 1;
            this.btnExcludeContacts.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnExcludeContacts.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintExcludeEvaluations.svg";
            this.btnExcludeContacts.Location = new System.Drawing.Point(0, 40);
            this.btnExcludeContacts.MaximumSize = new System.Drawing.Size(0, 40);
            this.btnExcludeContacts.MinimumSize = new System.Drawing.Size(0, 40);
            this.btnExcludeContacts.Name = "btnExcludeContacts";
            this.btnExcludeContacts.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExcludeContacts.Size = new System.Drawing.Size(238, 40);
            this.btnExcludeContacts.StyleController = this.settingsLayout;
            this.btnExcludeContacts.TabIndex = 2;
            this.btnExcludeContacts.TabStop = false;
            this.btnExcludeContacts.Text = "Exclude Contacts";
            this.btnExcludeContacts.CheckedChanged += new System.EventHandler(this.btnExcludeContacts_CheckedChanged);
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
            this.layoutControlItem1.Control = this.btnIncludeContacts;
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
            this.layoutControlItem2.Control = this.btnExcludeContacts;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 192);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ContactsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settingsLayout);
            this.Name = "ContactsControl";
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
        private XtraEditors.CheckButton btnIncludeContacts;
        private XtraEditors.CheckButton btnExcludeContacts;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
