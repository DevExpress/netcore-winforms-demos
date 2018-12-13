namespace DevExpress.DevAV.Modules {
    partial class EmployeesFilterPane {
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
            this.btnNewEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.treeListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNewEmployeeLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewEmployeeLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnNewEmployee.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16";
            this.btnNewEmployee.Location = new System.Drawing.Point(14, 14);
            this.btnNewEmployee.MaximumSize = new System.Drawing.Size(150, 0);
            this.btnNewEmployee.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(150, 22);
            this.btnNewEmployee.StyleController = this.moduleLayout;
            this.btnNewEmployee.TabIndex = 0;
            this.btnNewEmployee.Text = "New Employee";
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.btnNewEmployee);
            this.moduleLayout.Controls.Add(this.treeList);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.Root;
            this.moduleLayout.Size = new System.Drawing.Size(200, 603);
            this.moduleLayout.TabIndex = 2;
            // 
            // treeList
            // 
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Location = new System.Drawing.Point(12, 54);
            this.treeList.Name = "treeList";
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
            this.treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None;
            this.treeList.OptionsView.ShowColumns = false;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.Size = new System.Drawing.Size(176, 537);
            this.treeList.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.treeListLayoutControlItem,
            this.btnNewEmployeeLayoutControlItem});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 6;
            this.Root.Size = new System.Drawing.Size(200, 603);
            // 
            // treeListLayoutControlItem
            // 
            this.treeListLayoutControlItem.Control = this.treeList;
            this.treeListLayoutControlItem.CustomizationFormText = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.Location = new System.Drawing.Point(0, 42);
            this.treeListLayoutControlItem.Name = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.Size = new System.Drawing.Size(180, 541);
            this.treeListLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.treeListLayoutControlItem.TextVisible = false;
            // 
            // btnNewEmployeeLayoutControlItem
            // 
            this.btnNewEmployeeLayoutControlItem.Control = this.btnNewEmployee;
            this.btnNewEmployeeLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEmployeeLayoutControlItem.CustomizationFormText = "btnNewEmployeeLayoutControlItem";
            this.btnNewEmployeeLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.btnNewEmployeeLayoutControlItem.Name = "btnNewEmployeeLayoutControlItem";
            this.btnNewEmployeeLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16);
            this.btnNewEmployeeLayoutControlItem.Size = new System.Drawing.Size(180, 42);
            this.btnNewEmployeeLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.btnNewEmployeeLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.btnNewEmployeeLayoutControlItem.TextVisible = false;
            this.btnNewEmployeeLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // EmployeesFilterPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "EmployeesFilterPane";
            this.Size = new System.Drawing.Size(200, 603);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewEmployeeLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewEmployee;
        private XtraTreeList.TreeList treeList;
        private XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem treeListLayoutControlItem;
        private XtraLayout.LayoutControlItem btnNewEmployeeLayoutControlItem;
    }
}