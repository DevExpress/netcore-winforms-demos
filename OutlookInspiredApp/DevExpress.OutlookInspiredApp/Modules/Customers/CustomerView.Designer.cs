namespace DevExpress.DevAV.Modules {
    partial class CustomerView {
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCustomerStores = new System.Windows.Forms.BindingSource(this.components);
            this.winExplorerView = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colAddressLines = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrestSmallImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrestLargeImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCrestCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HomeOfficeTextLabel = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForHomeOffice = new DevExpress.XtraLayout.LayoutControlItem();
            this.sliName = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomerStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHomeOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.Customer);
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.pictureEdit);
            this.moduleLayout.Controls.Add(this.gridControl);
            this.moduleLayout.Controls.Add(this.HomeOfficeTextLabel);
            this.moduleLayout.DataSource = this.bindingSource;
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Margin = new System.Windows.Forms.Padding(2);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.Root;
            this.moduleLayout.Size = new System.Drawing.Size(376, 423);
            this.moduleLayout.TabIndex = 0;
            // 
            // pictureEdit
            // 
            this.pictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Logo", true));
            this.pictureEdit.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Properties.AllowAnimationOnValueChanged = DevExpress.Utils.DefaultBoolean.True;
            this.pictureEdit.Properties.AllowFocused = false;
            this.pictureEdit.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pictureEdit.Properties.ReadOnly = true;
            this.pictureEdit.Properties.ShowMenu = false;
            this.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit.Size = new System.Drawing.Size(100, 100);
            this.pictureEdit.StyleController = this.moduleLayout;
            this.pictureEdit.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSourceCustomerStores;
            this.gridControl.Location = new System.Drawing.Point(0, 129);
            this.gridControl.MainView = this.winExplorerView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(376, 294);
            this.gridControl.TabIndex = 7;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView});
            // 
            // bindingSourceCustomerStores
            // 
            this.bindingSourceCustomerStores.DataSource = typeof(DevExpress.DevAV.CustomerStore);
            // 
            // winExplorerView
            // 
            this.winExplorerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddressLines,
            this.colCrestSmallImage,
            this.colCustomerName,
            this.colCrestLargeImage,
            this.colCrestCity});
            this.winExplorerView.ColumnSet.DescriptionColumn = this.colAddressLines;
            this.winExplorerView.ColumnSet.ExtraLargeImageColumn = this.colCrestLargeImage;
            this.winExplorerView.ColumnSet.LargeImageColumn = this.colCrestLargeImage;
            this.winExplorerView.ColumnSet.MediumImageColumn = this.colCrestSmallImage;
            this.winExplorerView.ColumnSet.SmallImageColumn = this.colCrestSmallImage;
            this.winExplorerView.ColumnSet.TextColumn = this.colCrestCity;
            this.winExplorerView.GridControl = this.gridControl;
            this.winExplorerView.Name = "winExplorerView";
            this.winExplorerView.OptionsBehavior.Editable = false;
            this.winExplorerView.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Large;
            this.winExplorerView.OptionsViewStyles.Large.ImageSize = new System.Drawing.Size(110, 110);
            this.winExplorerView.OptionsViewStyles.Large.ShowDescription = DevExpress.Utils.DefaultBoolean.True;
            this.winExplorerView.OptionsViewStyles.Medium.ImageSize = new System.Drawing.Size(80, 80);
            // 
            // colAddressLines
            // 
            this.colAddressLines.FieldName = "AddressLines";
            this.colAddressLines.Name = "colAddressLines";
            this.colAddressLines.Visible = true;
            this.colAddressLines.VisibleIndex = 0;
            // 
            // colCrestSmallImage
            // 
            this.colCrestSmallImage.FieldName = "CrestSmallImage";
            this.colCrestSmallImage.Name = "colCrestSmallImage";
            this.colCrestSmallImage.Visible = true;
            this.colCrestSmallImage.VisibleIndex = 1;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colCrestLargeImage
            // 
            this.colCrestLargeImage.FieldName = "CrestLargeImage";
            this.colCrestLargeImage.Name = "colCrestLargeImage";
            this.colCrestLargeImage.Visible = true;
            this.colCrestLargeImage.VisibleIndex = 0;
            // 
            // colCrestCity
            // 
            this.colCrestCity.FieldName = "CrestCity";
            this.colCrestCity.Name = "colCrestCity";
            this.colCrestCity.Visible = true;
            this.colCrestCity.VisibleIndex = 0;
            // 
            // HomeOfficeTextLabel
            // 
            this.HomeOfficeTextLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.HomeOfficeTextLabel.Appearance.Options.UseFont = true;
            this.HomeOfficeTextLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "HomeOffice", true));
            this.HomeOfficeTextLabel.Location = new System.Drawing.Point(114, 66);
            this.HomeOfficeTextLabel.Margin = new System.Windows.Forms.Padding(2);
            this.HomeOfficeTextLabel.Name = "HomeOfficeTextLabel";
            this.HomeOfficeTextLabel.Size = new System.Drawing.Size(260, 25);
            this.HomeOfficeTextLabel.StyleController = this.moduleLayout;
            this.HomeOfficeTextLabel.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 6;
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(376, 423);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForGrid,
            this.ItemForLogo,
            this.simpleSeparator1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Size = new System.Drawing.Size(376, 423);
            // 
            // ItemForGrid
            // 
            this.ItemForGrid.Control = this.gridControl;
            this.ItemForGrid.CustomizationFormText = "layoutControlItem1";
            this.ItemForGrid.Location = new System.Drawing.Point(0, 129);
            this.ItemForGrid.Name = "layoutControlItem1";
            this.ItemForGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForGrid.Size = new System.Drawing.Size(376, 294);
            this.ItemForGrid.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForGrid.TextVisible = false;
            // 
            // ItemForLogo
            // 
            this.ItemForLogo.Control = this.pictureEdit;
            this.ItemForLogo.CustomizationFormText = "ItemForLogo";
            this.ItemForLogo.Location = new System.Drawing.Point(0, 0);
            this.ItemForLogo.MaxSize = new System.Drawing.Size(100, 100);
            this.ItemForLogo.MinSize = new System.Drawing.Size(100, 100);
            this.ItemForLogo.Name = "ItemForLogo";
            this.ItemForLogo.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForLogo.Size = new System.Drawing.Size(100, 115);
            this.ItemForLogo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForLogo.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForLogo.TextVisible = false;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 115);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.simpleSeparator1.Size = new System.Drawing.Size(376, 14);
            this.simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 12);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForHomeOffice,
            this.sliName,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(100, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 0, 0, 12);
            this.layoutControlGroup2.Size = new System.Drawing.Size(276, 115);
            // 
            // ItemForHomeOffice
            // 
            this.ItemForHomeOffice.Control = this.HomeOfficeTextLabel;
            this.ItemForHomeOffice.CustomizationFormText = "Home Office";
            this.ItemForHomeOffice.Location = new System.Drawing.Point(0, 45);
            this.ItemForHomeOffice.Name = "ItemForHomeOffice";
            this.ItemForHomeOffice.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForHomeOffice.Size = new System.Drawing.Size(260, 44);
            this.ItemForHomeOffice.Text = "HOME OFFICE";
            this.ItemForHomeOffice.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForHomeOffice.TextSize = new System.Drawing.Size(71, 13);
            // 
            // sliName
            // 
            this.sliName.AllowHotTrack = false;
            this.sliName.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sliName.AppearanceItemCaption.Options.UseFont = true;
            this.sliName.CustomizationFormText = "Name";
            this.sliName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true));
            this.sliName.Location = new System.Drawing.Point(0, 0);
            this.sliName.Name = "sliName";
            this.sliName.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 8);
            this.sliName.Size = new System.Drawing.Size(260, 45);
            this.sliName.Text = "Name";
            this.sliName.TextSize = new System.Drawing.Size(71, 37);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 89);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 10);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(260, 10);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(376, 423);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCustomerStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForHomeOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl moduleLayout;
        private XtraEditors.LabelControl HomeOfficeTextLabel;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem ItemForHomeOffice;
        private XtraGrid.GridControl gridControl;
        private XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView;
        private XtraLayout.LayoutControlItem ItemForGrid;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.SimpleSeparator simpleSeparator1;
        private XtraEditors.PictureEdit pictureEdit;
        private XtraLayout.LayoutControlItem ItemForLogo;
        private XtraLayout.SimpleLabelItem sliName;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private System.Windows.Forms.BindingSource bindingSourceCustomerStores;
        private XtraGrid.Columns.GridColumn colAddressLines;
        private XtraGrid.Columns.GridColumn colCrestSmallImage;
        private XtraGrid.Columns.GridColumn colCustomerName;
        private XtraGrid.Columns.GridColumn colCrestLargeImage;
        private XtraGrid.Columns.GridColumn colCrestCity;
    }
}
