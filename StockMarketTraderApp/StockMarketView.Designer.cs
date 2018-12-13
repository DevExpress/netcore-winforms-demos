using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Reflection;
namespace DevExpress.StockMarketTrader {
    partial class StockMarketView {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.stockWorkspacesUC2 = new DevExpress.StockMarketTrader.StockWorkspacesUC();
            this.SuspendLayout();
            // 
            // stockWorkspacesUC2
            // 
            this.stockWorkspacesUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockWorkspacesUC2.Location = new System.Drawing.Point(0, 0);
            this.stockWorkspacesUC2.Margin = new System.Windows.Forms.Padding(0);
            this.stockWorkspacesUC2.MinimumSize = new System.Drawing.Size(500, 350);
            this.stockWorkspacesUC2.Name = "stockWorkspacesUC2";
            this.stockWorkspacesUC2.Size = new System.Drawing.Size(1299, 676);
            this.stockWorkspacesUC2.TabIndex = 11;
            // 
            // StockMarketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 676);
            this.Controls.Add(this.stockWorkspacesUC2);
            this.MinimumSize = new System.Drawing.Size(1160, 675);
            this.Name = "StockMarketView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        //private UserControl1 userControl11;
        private StockWorkspacesUC stockWorkspacesUC2;

    }
}