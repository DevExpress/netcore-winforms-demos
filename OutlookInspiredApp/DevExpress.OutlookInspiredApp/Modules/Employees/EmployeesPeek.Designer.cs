namespace DevExpress.DevAV.Modules {
    partial class EmployeesPeek {
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
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPhoto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFullName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTitle = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.searchControl);
            this.moduleLayout.Controls.Add(this.gridControl);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Margin = new System.Windows.Forms.Padding(0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.Root;
            this.moduleLayout.Size = new System.Drawing.Size(250, 330);
            this.moduleLayout.TabIndex = 1;
            // 
            // searchControl
            // 
            this.searchControl.Client = this.gridControl;
            this.searchControl.Location = new System.Drawing.Point(10, 2);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl.Size = new System.Drawing.Size(230, 20);
            this.searchControl.StyleController = this.moduleLayout;
            this.searchControl.TabIndex = 2;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSource;
            this.gridControl.Location = new System.Drawing.Point(10, 55);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl.ShowOnlyPredefinedDetails = true;
            this.gridControl.Size = new System.Drawing.Size(230, 265);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.Employee);
            // 
            // gridView
            // 
            this.gridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colPhoto,
            this.colFullName,
            this.colTitle});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsFind.AllowFindPanel = false;
            this.gridView.OptionsView.ColumnAutoWidth = true;
            this.gridView.OptionsView.ShowBands = false;
            this.gridView.OptionsView.ShowColumnHeaders = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.RowHeight = 25;
            // 
            // gridBand1
            // 
            this.gridBand1.Columns.Add(this.colPhoto);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.OptionsBand.AllowSize = false;
            this.gridBand1.OptionsBand.FixedWidth = true;
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 50;
            // 
            // colPhoto
            // 
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.OptionsColumn.AllowEdit = false;
            this.colPhoto.OptionsColumn.AllowFocus = false;
            this.colPhoto.RowCount = 2;
            this.colPhoto.Visible = true;
            this.colPhoto.Width = 50;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.Padding = new System.Windows.Forms.Padding(4);
            this.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.repositoryItemPictureEdit1.OptionsMask.MaskType = XtraEditors.Controls.PictureEditMaskType.Circle;
            // 
            // gridBand2
            // 
            this.gridBand2.Columns.Add(this.colFullName);
            this.gridBand2.Columns.Add(this.colTitle);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 218;
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.FieldName = "FullNameBindable";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.OptionsColumn.AllowFocus = false;
            this.colFullName.Visible = true;
            this.colFullName.Width = 218;
            // 
            // colTitle
            // 
            this.colTitle.AppearanceCell.Options.UseTextOptions = true;
            this.colTitle.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.OptionsColumn.AllowEdit = false;
            this.colTitle.OptionsColumn.AllowFocus = false;
            this.colTitle.RowIndex = 1;
            this.colTitle.Visible = true;
            this.colTitle.Width = 218;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.simpleLabelItem1});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 0, 8);
            this.Root.Size = new System.Drawing.Size(250, 330);
            this.Root.Text = "Root";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(234, 269);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.searchControl;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(234, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.CustomizationFormText = "EMPLOYEES";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 24);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 8);
            this.simpleLabelItem1.Size = new System.Drawing.Size(234, 29);
            this.simpleLabelItem1.Text = "EMPLOYEES";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(57, 13);
            // 
            // EmployeesPeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmployeesPeek";
            this.Size = new System.Drawing.Size(250, 330);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.SearchControl searchControl;
        private XtraLayout.LayoutControl moduleLayout;
        private XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource bindingSource;
        private XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private XtraGrid.Views.BandedGrid.AdvBandedGridView gridView;
        private XtraGrid.Views.BandedGrid.BandedGridColumn colPhoto;
        private XtraGrid.Views.BandedGrid.BandedGridColumn colFullName;
        private XtraGrid.Views.BandedGrid.BandedGridColumn colTitle;
        private XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.SimpleLabelItem simpleLabelItem1;

    }
}
