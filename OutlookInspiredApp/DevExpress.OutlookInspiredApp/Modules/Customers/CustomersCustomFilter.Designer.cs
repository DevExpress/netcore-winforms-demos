namespace DevExpress.DevAV.Modules {
        partial class CustomersCustomFilter {
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
            this.saveFilter = new DevExpress.XtraEditors.CheckEdit();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterName = new DevExpress.XtraEditors.TextEdit();
            this.filterControl = new DevExpress.XtraEditors.FilterControl();
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
            this.okBtn.Location = new System.Drawing.Point(280, 254);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(78, 22);
            this.okBtn.StyleController = this.moduleLayout;
            this.okBtn.TabIndex = 0;
            this.okBtn.Text = "OK";
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.saveFilter);
            this.moduleLayout.Controls.Add(this.filterName);
            this.moduleLayout.Controls.Add(this.filterControl);
            this.moduleLayout.Controls.Add(this.cancelBtn);
            this.moduleLayout.Controls.Add(this.okBtn);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.layoutControlGroup;
            this.moduleLayout.Size = new System.Drawing.Size(452, 288);
            this.moduleLayout.TabIndex = 0;
            // 
            // saveFilter
            // 
            this.saveFilter.AutoSizeInLayoutControl = true;
            this.saveFilter.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Save", true));
            this.saveFilter.Location = new System.Drawing.Point(12, 179);
            this.saveFilter.Name = "saveFilter";
            this.saveFilter.Properties.Caption = "Save for future use";
            this.saveFilter.Size = new System.Drawing.Size(116, 19);
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
            this.filterName.Location = new System.Drawing.Point(12, 202);
            this.filterName.Name = "filterName";
            this.filterName.Properties.NullValuePrompt = "Enter a name for your custom filter";
            this.filterName.Properties.NullValuePromptShowForEmptyValue = true;
            this.filterName.Size = new System.Drawing.Size(428, 20);
            this.filterName.StyleController = this.moduleLayout;
            this.filterName.TabIndex = 4;
            // 
            // filterControl
            // 
            this.filterControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.filterControl.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl.Location = new System.Drawing.Point(0, 0);
            this.filterControl.Name = "filterControl";
            this.filterControl.Size = new System.Drawing.Size(452, 161);
            this.filterControl.TabIndex = 2;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(362, 254);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(78, 22);
            this.cancelBtn.StyleController = this.moduleLayout;
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup.CustomizationFormText = "Root";
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
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup.Size = new System.Drawing.Size(452, 288);
            this.layoutControlGroup.Text = "Root";
            // 
            // itemForControl
            // 
            this.itemForControl.Control = this.filterControl;
            this.itemForControl.CustomizationFormText = "itemForControl";
            this.itemForControl.Location = new System.Drawing.Point(0, 0);
            this.itemForControl.Name = "itemForControl";
            this.itemForControl.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemForControl.Size = new System.Drawing.Size(452, 161);
            this.itemForControl.Text = "itemForControl";
            this.itemForControl.TextSize = new System.Drawing.Size(0, 0);
            this.itemForControl.TextToControlDistance = 0;
            this.itemForControl.TextVisible = false;
            // 
            // itemForOkBtn
            // 
            this.itemForOkBtn.Control = this.okBtn;
            this.itemForOkBtn.CustomizationFormText = "itemForOkBtn";
            this.itemForOkBtn.Location = new System.Drawing.Point(268, 242);
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
            this.itemForCancelBtn.Location = new System.Drawing.Point(360, 242);
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
            this.itemForName.Location = new System.Drawing.Point(0, 198);
            this.itemForName.Name = "itemForName";
            this.itemForName.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 4, 20);
            this.itemForName.Size = new System.Drawing.Size(452, 44);
            this.itemForName.Text = "itemForName";
            this.itemForName.TextSize = new System.Drawing.Size(0, 0);
            this.itemForName.TextToControlDistance = 0;
            this.itemForName.TextVisible = false;
            // 
            // itemForSaveCheck
            // 
            this.itemForSaveCheck.Control = this.saveFilter;
            this.itemForSaveCheck.CustomizationFormText = "itemForSaveCheck";
            this.itemForSaveCheck.Location = new System.Drawing.Point(0, 163);
            this.itemForSaveCheck.Name = "itemForSaveCheck";
            this.itemForSaveCheck.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 16, 0);
            this.itemForSaveCheck.Size = new System.Drawing.Size(452, 35);
            this.itemForSaveCheck.Text = "itemForSaveCheck";
            this.itemForSaveCheck.TextSize = new System.Drawing.Size(0, 0);
            this.itemForSaveCheck.TextToControlDistance = 0;
            this.itemForSaveCheck.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 242);
            this.emptySpaceItem.Name = "emptySpaceItem1";
            this.emptySpaceItem.Size = new System.Drawing.Size(268, 46);
            this.emptySpaceItem.Text = "emptySpaceItem1";
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.separator.AllowHotTrack = false;
            this.separator.CustomizationFormText = "simpleSeparator1";
            this.separator.Location = new System.Drawing.Point(0, 161);
            this.separator.Name = "simpleSeparator1";
            this.separator.Size = new System.Drawing.Size(452, 2);
            this.separator.Text = "simpleSeparator1";
            // 
            // EmployeesCustomFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "CustomersCustomFilter";
            this.Size = new System.Drawing.Size(452, 288);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
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
        private DevExpress.XtraEditors.FilterControl filterControl;
        private DevExpress.XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup;
        private XtraLayout.LayoutControlItem itemForControl;
        private XtraLayout.LayoutControlItem itemForOkBtn;
        private XtraLayout.LayoutControlItem itemForCancelBtn;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraEditors.TextEdit filterName;
        private XtraLayout.LayoutControlItem itemForName;
        private XtraEditors.CheckEdit saveFilter;
        private XtraLayout.LayoutControlItem itemForSaveCheck;
        private System.Windows.Forms.BindingSource bindingSource;
        private XtraLayout.SimpleSeparator separator;
    }
}
