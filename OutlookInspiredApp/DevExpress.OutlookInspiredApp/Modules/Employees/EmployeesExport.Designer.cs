namespace DevExpress.DevAV.Modules {
    partial class EmployeesExport {
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
            this.exportSettingsControl = new DevExpress.DevAV.ReportExportControl();
            this.previewControl = new DevExpress.DevAV.ReportPreviewControl();
            this.SuspendLayout();
            // 
            // exportSettingsControl
            // 
            this.exportSettingsControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.exportSettingsControl.Location = new System.Drawing.Point(0, 0);
            this.exportSettingsControl.Name = "exportSettingsControl";
            this.exportSettingsControl.SelectedExport = DevExpress.XtraPrinting.ExportTarget.Xls;
            this.exportSettingsControl.Size = new System.Drawing.Size(310, 600);
            this.exportSettingsControl.TabIndex = 0;
            // 
            // previewControl
            // 
            this.previewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl.Location = new System.Drawing.Point(310, 0);
            this.previewControl.Name = "previewControl";
            this.previewControl.Size = new System.Drawing.Size(714, 600);
            this.previewControl.TabIndex = 1;
            this.previewControl.Visible = false;
            // 
            // EmployeesExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previewControl);
            this.Controls.Add(this.exportSettingsControl);
            this.Name = "EmployeesExport";
            this.Size = new System.Drawing.Size(1024, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private ReportExportControl exportSettingsControl;
        private ReportPreviewControl previewControl;
    }
}
