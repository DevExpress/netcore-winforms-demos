namespace DevExpress.DevAV.Modules {
    partial class QuotesFilterPane {
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
            this.btnNewQuote = new DevExpress.XtraEditors.SimpleButton();
            this.moduleLayout = new DevExpress.XtraLayout.LayoutControl();
            this.treeList = new DevExpress.XtraTreeList.TreeList();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.treeListLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnNewQuoteLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).BeginInit();
            this.moduleLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewQuoteLayoutControlItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewQuote
            // 
            this.btnNewQuote.Image = global::DevExpress.DevAV.Properties.Resources.icon_new_opportunities_16;
            this.btnNewQuote.Location = new System.Drawing.Point(14, 14);
            this.btnNewQuote.MaximumSize = new System.Drawing.Size(150, 0);
            this.btnNewQuote.MinimumSize = new System.Drawing.Size(150, 0);
            this.btnNewQuote.Name = "btnNewQuote";
            this.btnNewQuote.Size = new System.Drawing.Size(150, 22);
            this.btnNewQuote.StyleController = this.moduleLayout;
            this.btnNewQuote.TabIndex = 0;
            this.btnNewQuote.Text = "New Quote";
            // 
            // moduleLayout
            // 
            this.moduleLayout.AllowCustomization = false;
            this.moduleLayout.Controls.Add(this.btnNewQuote);
            this.moduleLayout.Controls.Add(this.treeList);
            this.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleLayout.Location = new System.Drawing.Point(0, 0);
            this.moduleLayout.Name = "moduleLayout";
            this.moduleLayout.Root = this.Root;
            this.moduleLayout.Size = new System.Drawing.Size(200, 700);
            this.moduleLayout.TabIndex = 2;
            // 
            // treeList
            // 
            this.treeList.Appearance.Empty.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.Empty.Options.UseBackColor = true;
            this.treeList.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.treeList.Appearance.FocusedRow.Options.UseFont = true;
            this.treeList.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.treeList.Appearance.HideSelectionRow.Options.UseFont = true;
            this.treeList.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.treeList.Appearance.Row.Options.UseBackColor = true;
            this.treeList.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.treeList.Appearance.SelectedRow.Options.UseFont = true;
            this.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList.Location = new System.Drawing.Point(12, 54);
            this.treeList.Name = "treeList";
            this.treeList.OptionsDragAndDrop.DragNodesMode = XtraTreeList.DragNodesMode.Single;
            this.treeList.OptionsBehavior.Editable = false;
            this.treeList.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList.OptionsView.ShowColumns = false;
            this.treeList.OptionsView.FocusRectStyle = XtraTreeList.DrawFocusRectStyle.None;
            this.treeList.OptionsView.ShowHorzLines = false;
            this.treeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList.OptionsView.ShowIndicator = false;
            this.treeList.OptionsView.ShowVertLines = false;
            this.treeList.Size = new System.Drawing.Size(176, 634);
            this.treeList.TabIndex = 1;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.treeListLayoutControlItem,
            this.btnNewQuoteLayoutControlItem});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 6;
            this.Root.Size = new System.Drawing.Size(200, 700);
            this.Root.Text = "Root";
            // 
            // treeListLayoutControlItem
            // 
            this.treeListLayoutControlItem.Control = this.treeList;
            this.treeListLayoutControlItem.CustomizationFormText = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.Location = new System.Drawing.Point(0, 42);
            this.treeListLayoutControlItem.Name = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.Size = new System.Drawing.Size(180, 638);
            this.treeListLayoutControlItem.Text = "treeListLayoutControlItem";
            this.treeListLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.treeListLayoutControlItem.TextToControlDistance = 0;
            this.treeListLayoutControlItem.TextVisible = false;
            // 
            // btnNewQuoteLayoutControlItem
            // 
            this.btnNewQuoteLayoutControlItem.Control = this.btnNewQuote;
            this.btnNewQuoteLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewQuoteLayoutControlItem.CustomizationFormText = "btnNewQuoteLayoutControlItem";
            this.btnNewQuoteLayoutControlItem.Location = new System.Drawing.Point(0, 0);
            this.btnNewQuoteLayoutControlItem.Name = "btnNewQuoteLayoutControlItem";
            this.btnNewQuoteLayoutControlItem.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16);
            this.btnNewQuoteLayoutControlItem.Size = new System.Drawing.Size(180, 42);
            this.btnNewQuoteLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.btnNewQuoteLayoutControlItem.Text = "btnNewQuoteLayoutControlItem";
            this.btnNewQuoteLayoutControlItem.TextSize = new System.Drawing.Size(0, 0);
            this.btnNewQuoteLayoutControlItem.TextToControlDistance = 0;
            this.btnNewQuoteLayoutControlItem.TextVisible = false;
            this.btnNewQuoteLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // QuotesFilterPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleLayout);
            this.Name = "QuotesFilterPane";
            this.Size = new System.Drawing.Size(200, 700);
            ((System.ComponentModel.ISupportInitialize)(this.moduleLayout)).EndInit();
            this.moduleLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewQuoteLayoutControlItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewQuote;
        private XtraTreeList.TreeList treeList;
        private XtraLayout.LayoutControl moduleLayout;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem treeListLayoutControlItem;
        private XtraLayout.LayoutControlItem btnNewQuoteLayoutControlItem;
    }
}
