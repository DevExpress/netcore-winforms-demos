namespace DevExpress.DevAV.Modules {
        partial class ViewSettingsControl {
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
            this.okBtn = new DevExpress.XtraEditors.SimpleButton();
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.resetViewBtn = new DevExpress.XtraEditors.SimpleButton();
            this.resetFiltersBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cancelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemForOkBtn = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemForCancelBtn = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.separator = new DevExpress.XtraLayout.SimpleSeparator();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForOkBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.moduleLayout.Controls.Add(this.resetViewBtn);
            this.moduleLayout.Controls.Add(this.resetFiltersBtn);
            this.moduleLayout.Controls.Add(this.cancelBtn);
            this.moduleLayout.Controls.Add(this.okBtn);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.layoutControlGroup;
            this.moduleLayout.Size = new System.Drawing.Size(452, 288);
            this.moduleLayout.TabIndex = 0;
            // 
            // resetViewBtn
            // 
            this.resetViewBtn.Location = new System.Drawing.Point(12, 46);
            this.resetViewBtn.Name = "resetViewBtn";
            this.resetViewBtn.Size = new System.Drawing.Size(165, 22);
            this.resetViewBtn.StyleController = this.moduleLayout;
            this.resetViewBtn.TabIndex = 7;
            this.resetViewBtn.Text = "Reset View";
            // 
            // resetFiltersBtn
            // 
            this.resetFiltersBtn.Location = new System.Drawing.Point(12, 16);
            this.resetFiltersBtn.Name = "resetFiltersBtn";
            this.resetFiltersBtn.Size = new System.Drawing.Size(165, 22);
            this.resetFiltersBtn.StyleController = this.moduleLayout;
            this.resetFiltersBtn.TabIndex = 6;
            this.resetFiltersBtn.Text = "Reset Custom Filters";
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
            // layoutControlGroup
            // 
            this.layoutControlGroup.CustomizationFormText = "Root";
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemForOkBtn,
            this.itemForCancelBtn,
            this.emptySpaceItem,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.separator,
            this.emptySpaceItem1});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup.Size = new System.Drawing.Size(452, 288);
            this.layoutControlGroup.Text = "Root";
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
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 242);
            this.emptySpaceItem.Name = "emptySpaceItem1";
            this.emptySpaceItem.Size = new System.Drawing.Size(268, 46);
            this.emptySpaceItem.Text = "emptySpaceItem1";
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.resetFiltersBtn;
            this.layoutControlItem1.CustomizationFormText = "Reset Custom Filters";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 16, 4);
            this.layoutControlItem1.Size = new System.Drawing.Size(452, 42);
            this.layoutControlItem1.Text = "Replace all the filters created by user with predefined";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(257, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.resetViewBtn;
            this.layoutControlItem2.CustomizationFormText = "Reset View";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 42);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(12, 12, 4, 4);
            this.layoutControlItem2.Size = new System.Drawing.Size(452, 30);
            this.layoutControlItem2.Text = "Change View type to default (List, Card etc.)";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(257, 13);
            // 
            // separator
            // 
            this.separator.AllowHotTrack = false;
            this.separator.CustomizationFormText = "simpleSeparator1";
            this.separator.Location = new System.Drawing.Point(0, 240);
            this.separator.Name = "simpleSeparator1";
            this.separator.Size = new System.Drawing.Size(452, 2);
            this.separator.Text = "simpleSeparator1";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(452, 168);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ViewSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "ViewSettingsControl";
            this.Size = new System.Drawing.Size(452, 288);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForOkBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemForCancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okBtn;
        private DevExpress.XtraEditors.SimpleButton cancelBtn;
        private DevExpress.XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup;
        private XtraLayout.LayoutControlItem itemForOkBtn;
        private XtraLayout.LayoutControlItem itemForCancelBtn;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraLayout.SimpleSeparator separator;
        private XtraEditors.SimpleButton resetViewBtn;
        private XtraEditors.SimpleButton resetFiltersBtn;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
