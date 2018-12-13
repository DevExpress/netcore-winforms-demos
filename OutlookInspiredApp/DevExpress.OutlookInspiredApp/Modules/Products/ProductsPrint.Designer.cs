namespace DevExpress.DevAV.Modules {
    partial class ProductsPrint {
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
            this.printControl = new DevExpress.DevAV.ReportPrintControl();
            this.previewControl = new DevExpress.DevAV.ReportPreviewControl();
            this.SuspendLayout();
            // 
            // printControl
            // 
            this.printControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.printControl.Location = new System.Drawing.Point(0, 0);
            this.printControl.Name = "printControl";
            this.printControl.SelectedPrinterName = "";
            this.printControl.Size = new System.Drawing.Size(310, 600);
            this.printControl.TabIndex = 1;
            this.printControl.PrintClick += new System.EventHandler(this.settingsControl_PrintClick);
            this.printControl.PrintOptionsClick += new System.EventHandler(this.settingsControl_PrintOptionsClick);
            // 
            // previewControl
            // 
            this.previewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl.Location = new System.Drawing.Point(310, 0);
            this.previewControl.Name = "reportPreviewControl1";
            this.previewControl.Size = new System.Drawing.Size(714, 600);
            this.previewControl.TabIndex = 2;
            // 
            // CustomersPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previewControl);
            this.Controls.Add(this.printControl);
            this.Name = "CustomersPrint";
            this.Size = new System.Drawing.Size(1024, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private ReportPrintControl printControl;
        private ReportPreviewControl previewControl;

    }
}
