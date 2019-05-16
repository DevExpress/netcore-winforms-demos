namespace DevExpress.DevAV.Modules {
    partial class ProductsGroupFilter {
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
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCollection = new System.Windows.Forms.BindingSource(this.components);
            this.winExplorerView = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveFilter = new DevExpress.XtraEditors.CheckEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterName = new DevExpress.XtraEditors.TextEdit();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemForControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForOkBtn = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForCancelBtn = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForSaveCheck = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.separator = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForOkBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForSaveCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(628, 466);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(78, 22);
            this.okBtn.StyleController = this.moduleLayout;
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.gridControl);
            this.moduleLayout.Controls.Add(this.saveFilter);
            this.moduleLayout.Controls.Add(this.filterName);
            this.moduleLayout.Controls.Add(this.cancelBtn);
            this.moduleLayout.Controls.Add(this.okBtn);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.layoutControlGroup;
            this.moduleLayout.Size = new System.Drawing.Size(800, 500);
            this.moduleLayout.TabIndex = 0;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.bindingSourceCollection;
            this.gridControl.Location = new System.Drawing.Point(0, 0);
            this.gridControl.MainView = this.winExplorerView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(800, 377);
            this.gridControl.TabIndex = 6;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView});
            // 
            // bindingSourceCollection
            // 
            this.bindingSourceCollection.DataSource = typeof(DevExpress.DevAV.Product);
            // 
            // winExplorerView
            // 
            this.winExplorerView.Appearance.ItemHovered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winExplorerView.Appearance.ItemHovered.Options.UseFont = true;
            this.winExplorerView.Appearance.ItemNormal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winExplorerView.Appearance.ItemNormal.Options.UseFont = true;
            this.winExplorerView.Appearance.ItemPressed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winExplorerView.Appearance.ItemPressed.Options.UseFont = true;
            this.winExplorerView.Appearance.ItemSelected.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winExplorerView.Appearance.ItemSelected.Options.UseFont = true;
            this.winExplorerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colImage,
            this.colName,
            this.colDescription,
            this.colCategory,
            this.colCheck});
            this.winExplorerView.ColumnSet.CheckBoxColumn = this.colCheck;
            this.winExplorerView.ColumnSet.DescriptionColumn = this.colDescription;
            this.winExplorerView.ColumnSet.ExtraLargeImageColumn = this.colImage;
            this.winExplorerView.ColumnSet.GroupColumn = this.colCategory;
            this.winExplorerView.ColumnSet.LargeImageColumn = this.colImage;
            this.winExplorerView.ColumnSet.MediumImageColumn = this.colImage;
            this.winExplorerView.ColumnSet.TextColumn = this.colName;
            this.winExplorerView.GridControl = this.gridControl;
            this.winExplorerView.GroupCount = 1;
            this.winExplorerView.Name = "winExplorerView";
            this.winExplorerView.OptionsBehavior.Editable = false;
            this.winExplorerView.OptionsFind.AlwaysVisible = true;
            this.winExplorerView.OptionsFind.FindNullPrompt = "Search Products...";
            this.winExplorerView.OptionsFind.ShowClearButton = false;
            this.winExplorerView.OptionsFind.ShowCloseButton = false;
            this.winExplorerView.OptionsFind.ShowFindButton = false;
            this.winExplorerView.OptionsView.DrawCheckedItemsAsSelected = true;
            this.winExplorerView.OptionsView.ShowCheckBoxes = true;
            this.winExplorerView.OptionsView.ShowExpandCollapseButtons = true;
            this.winExplorerView.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Tiles;
            // 
            // colImage
            // 
            this.colImage.FieldName = "ProductImage";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 2;
            // 
            // colCheck
            // 
            this.colCheck.FieldName = "Check";
            this.colCheck.Name = "colCheck";
            this.colCheck.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 2;
            // 
            // saveFilter
            // 
            this.saveFilter.AutoSizeInLayoutControl = true;
            this.saveFilter.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Save", true));
            this.saveFilter.Location = new System.Drawing.Point(12, 395);
            this.saveFilter.Name = "saveFilter";
            this.saveFilter.Properties.Caption = "Save for future use";
            this.saveFilter.Size = new System.Drawing.Size(112, 15);
            this.saveFilter.StyleController = this.moduleLayout;
            this.saveFilter.TabIndex = 5;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.ViewModels.CustomFilterViewModel);
            // 
            // filterName
            // 
            this.filterName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Name", true));
            this.filterName.EditValue = "";
            this.filterName.Location = new System.Drawing.Point(12, 414);
            this.filterName.Name = "filterName";
            this.filterName.Properties.NullValuePrompt = "Enter a name for your group";
            this.filterName.Properties.NullValuePromptShowForEmptyValue = true;
            this.filterName.Size = new System.Drawing.Size(776, 20);
            this.filterName.StyleController = this.moduleLayout;
            this.filterName.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(710, 466);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(78, 22);
            this.cancelBtn.StyleController = this.moduleLayout;
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemForControl,
            this.itemForOkBtn,
            this.itemForCancelBtn,
            this.itemForName,
            this.itemForSaveCheck,
            this.emptySpaceItem,
            this.separator});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "layoutControlGroup1";
            this.layoutControlGroup.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup.Size = new System.Drawing.Size(800, 500);
            this.layoutControlGroup.Text = "layoutControlGroup1";
            // 
            // itemForControl
            // 
            this.itemForControl.Control = this.gridControl;
            this.itemForControl.CustomizationFormText = "itemForControl";
            this.itemForControl.Location = new System.Drawing.Point(0, 0);
            this.itemForControl.Name = "itemForControl";
            this.itemForControl.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemForControl.Size = new System.Drawing.Size(800, 377);
            this.itemForControl.Text = "itemForControl";
            this.itemForControl.TextSize = new System.Drawing.Size(0, 0);
            this.itemForControl.TextToControlDistance = 0;
            this.itemForControl.TextVisible = false;
            // 
            // itemForOkBtn
            // 
            this.itemForOkBtn.Control = this.okBtn;
            this.itemForOkBtn.CustomizationFormText = "itemForOkBtn";
            this.itemForOkBtn.Location = new System.Drawing.Point(616, 454);
            this.itemForOkBtn.MaxSize = new System.Drawing.Size(92, 46);
            this.itemForOkBtn.MinSize = new System.Drawing.Size(92, 46);
            this.itemForOkBtn.Name = "itemForOkBtn";
            this.itemForOkBtn.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 2, 12, 12);
            this.itemForOkBtn.Size = new System.Drawing.Size(92, 46);
            this.itemForOkBtn.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemForOkBtn.Text = "itemForOkBtn";
            this.itemForOkBtn.TextSize = new System.Drawing.Size(0, 0);
            this.itemForOkBtn.TextToControlDistance = 0;
            this.itemForOkBtn.TextVisible = false;
            // 
            // itemForCancelBtn
            // 
            this.itemForCancelBtn.Control = this.cancelBtn;
            this.itemForCancelBtn.CustomizationFormText = "itemForCancelBtn";
            this.itemForCancelBtn.Location = new System.Drawing.Point(708, 454);
            this.itemForCancelBtn.MaxSize = new System.Drawing.Size(92, 46);
            this.itemForCancelBtn.MinSize = new System.Drawing.Size(92, 46);
            this.itemForCancelBtn.Name = "itemForCancelBtn";
            this.itemForCancelBtn.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 12, 12, 12);
            this.itemForCancelBtn.Size = new System.Drawing.Size(92, 46);
            this.itemForCancelBtn.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.itemForCancelBtn.Text = "itemForCancelBtn";
            this.itemForCancelBtn.TextSize = new System.Drawing.Size(0, 0);
            this.itemForCancelBtn.TextToControlDistance = 0;
            this.itemForCancelBtn.TextVisible = false;
            // 
            // itemForName
            // 
            this.itemForName.Control = this.filterName;
            this.itemForName.CustomizationFormText = "itemForName";
            this.itemForName.Location = new System.Drawing.Point(0, 410);
            this.itemForName.Name = "itemForName";
            this.itemForName.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 4, 20);
            this.itemForName.Size = new System.Drawing.Size(800, 44);
            this.itemForName.Text = "itemForName";
            this.itemForName.TextSize = new System.Drawing.Size(0, 0);
            this.itemForName.TextToControlDistance = 0;
            this.itemForName.TextVisible = false;
            // 
            // itemForSaveCheck
            // 
            this.itemForSaveCheck.Control = this.saveFilter;
            this.itemForSaveCheck.CustomizationFormText = "itemForSaveCheck";
            this.itemForSaveCheck.Location = new System.Drawing.Point(0, 379);
            this.itemForSaveCheck.Name = "itemForSaveCheck";
            this.itemForSaveCheck.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 16, 0);
            this.itemForSaveCheck.Size = new System.Drawing.Size(800, 31);
            this.itemForSaveCheck.Text = "itemForSaveCheck";
            this.itemForSaveCheck.TextSize = new System.Drawing.Size(0, 0);
            this.itemForSaveCheck.TextToControlDistance = 0;
            this.itemForSaveCheck.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 454);
            this.emptySpaceItem.Name = "emptySpaceItem1";
            this.emptySpaceItem.Size = new System.Drawing.Size(616, 46);
            this.emptySpaceItem.Text = "emptySpaceItem1";
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // separator
            // 
            this.separator.AllowHotTrack = false;
            this.separator.CustomizationFormText = "simpleSeparator1";
            this.separator.Location = new System.Drawing.Point(0, 377);
            this.separator.Name = "simpleSeparator1";
            this.separator.Size = new System.Drawing.Size(800, 2);
            this.separator.Text = "simpleSeparator1";
            // 
            // ProductsGroupFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "ProductsGroupFilter";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForOkBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForSaveCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup;
        private XtraEditors.TextEdit filterName;
        private XtraEditors.CheckEdit saveFilter;
        private System.Windows.Forms.BindingSource bindingSource;
        private XtraGrid.GridControl gridControl;
        private XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView;
        private System.Windows.Forms.BindingSource bindingSourceCollection;
        private XtraGrid.Columns.GridColumn colImage;
        private XtraGrid.Columns.GridColumn colName;
        private XtraGrid.Columns.GridColumn colDescription;
        private XtraGrid.Columns.GridColumn colCategory;
        private XtraGrid.Columns.GridColumn colCheck;
        private XtraLayout.LayoutControlItem itemForControl;
        private XtraLayout.LayoutControlItem itemForOkBtn;
        private XtraLayout.LayoutControlItem itemForCancelBtn;
        private XtraLayout.LayoutControlItem itemForName;
        private XtraLayout.LayoutControlItem itemForSaveCheck;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraLayout.SimpleSeparator separator;
    }
}
