namespace DevExpress.DevAV.Modules {
    partial class ProductsFilterPaneCollapsed {
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.navigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btnNewLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.filtersLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.navigationBar);
            this.moduleLayout.Controls.Add(this.btnNew);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.Root;
            this.moduleLayout.Size = new System.Drawing.Size(60, 600);
            this.moduleLayout.TabIndex = 1;
            // 
            // navigationBar
            // 
            this.navigationBar.AnimateItemPressing = false;
            this.navigationBar.AutoSize = false;
            this.navigationBar.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden;
            this.navigationBar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navigationBar.ItemSkinning = true;
            this.navigationBar.Location = new System.Drawing.Point(12, 38);
            this.navigationBar.MaximumSize = new System.Drawing.Size(50, 0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationBar.ShowPeekFormOnItemHover = false;
            this.navigationBar.Size = new System.Drawing.Size(46, 550);
            this.navigationBar.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNew.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnNew.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewProduct.svg?Size=16x16";
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(46, 22);
            this.btnNew.StyleController = this.moduleLayout;
            this.btnNew.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.btnNewLayoutControlItem,
            this.filtersLayoutControlItem});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 0, 10, 10);
            this.Root.Size = new System.Drawing.Size(60, 600);
            // 
            // btnNewLayoutControlItem
            // 
            this.btnNewLayoutControlItem.Control = this.btnNew;
            this.btnNewLayoutControlItem.CustomizationFormText = "New";
            this.btnNewLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.btnNewLayoutControlItem.Name = "btnNewLayoutControlItem";
            this.btnNewLayoutControlItem.Size = new System.Drawing.Size(50, 26);
            this.btnNewLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.btnNewLayoutControlItem.TextVisible = false;
            this.btnNewLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // filtersLayoutControlItem
            // 
            this.filtersLayoutControlItem.Control = this.navigationBar;
            this.filtersLayoutControlItem.CustomizationFormText = "layoutControlItem2";
            this.filtersLayoutControlItem.Location = new System.Drawing.Point(0, 26);
            this.filtersLayoutControlItem.Name = "layoutControlItem2";
            this.filtersLayoutControlItem.Size = new System.Drawing.Size(50, 554);
            this.filtersLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.filtersLayoutControlItem.TextVisible = false;
            // 
            // ProductsFilterPaneCollapsed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "ProductsFilterPaneCollapsed";
            this.Size = new System.Drawing.Size(60, 600);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar navigationBar;
        private DevExpress.XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem btnNewLayoutControlItem;
        private XtraLayout.LayoutControlItem filtersLayoutControlItem;
    }
}