namespace DevExpress.DevAV {
    partial class InvoiceSettingsControl {
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
            this.checkedListBoxControl1 = new DevExpress.XtraEditors.CheckedListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxControl1
            // 
            this.checkedListBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Header"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Footer"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Status"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Show Comments")});
            this.checkedListBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBoxControl1.Name = "checkedListBoxControl1";
            this.checkedListBoxControl1.Size = new System.Drawing.Size(204, 167);
            this.checkedListBoxControl1.TabIndex = 0;
            this.checkedListBoxControl1.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.checkedListBoxControl1_ItemCheck);
            // 
            // InvoiceSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBoxControl1);
            this.Name = "InvoiceSettingsControl";
            this.Size = new System.Drawing.Size(204, 167);
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.CheckedListBoxControl checkedListBoxControl1;
    }
}
