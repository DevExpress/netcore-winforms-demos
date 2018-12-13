namespace DevExpress.DevAV.Modules {
    partial class QuoteView {
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
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FunnelSeriesLabel funnelSeriesLabel1 = new DevExpress.XtraCharts.FunnelSeriesLabel();
            DevExpress.XtraCharts.FunnelSeriesView funnelSeriesView1 = new DevExpress.XtraCharts.FunnelSeriesView();
            DevExpress.XtraCharts.FunnelSeriesView funnelSeriesView2 = new DevExpress.XtraCharts.FunnelSeriesView();
            this.modueLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFunnel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.modueLayout)).BeginInit();
            this.modueLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFunnel)).BeginInit();
            this.SuspendLayout();
            // 
            // modueLayout
            // 
            this.modueLayout.AllowCustomization = false;
            this.modueLayout.Controls.Add(this.chartControl);
            this.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modueLayout.Location = new System.Drawing.Point(0, 0);
            this.modueLayout.Margin = new System.Windows.Forms.Padding(2);
            this.modueLayout.Name = "modueLayout";
            this.modueLayout.Root = this.Root;
            this.modueLayout.Size = new System.Drawing.Size(458, 572);
            this.modueLayout.TabIndex = 0;
            // 
            // chartControl
            // 
            this.chartControl.AccessibleName = "";
            this.chartControl.AllowDrop = true;
            simpleDiagram1.EqualPieSize = false;
            this.chartControl.Diagram = simpleDiagram1;
            this.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl.Legend.EnableAntialiasing = Utils.DefaultBoolean.True;
            this.chartControl.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl.Legend.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chartControl.Legend.Margins.Bottom = 0;
            this.chartControl.Legend.Margins.Left = 0;
            this.chartControl.Legend.Margins.Right = 0;
            this.chartControl.Legend.Margins.Top = 0;
            this.chartControl.Legend.MarkerSize = new System.Drawing.Size(20, 20);
            this.chartControl.Legend.Padding.Bottom = 0;
            this.chartControl.Legend.Padding.Left = 0;
            this.chartControl.Legend.Padding.Right = 0;
            this.chartControl.Legend.Padding.Top = 40;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.Padding.Bottom = 40;
            this.chartControl.Padding.Left = 40;
            this.chartControl.Padding.Right = 40;
            this.chartControl.Padding.Top = 40;
            this.chartControl.PaletteName = "Opportunities Palette";
            this.chartControl.PaletteRepository.Add("Opportunities Palette", new DevExpress.XtraCharts.Palette("Opportunities Palette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(108)))), ((int)(((byte)(41))))), System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(108)))), ((int)(((byte)(41)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(135)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(135)))), ((int)(((byte)(184)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))), System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))))}));
            funnelSeriesLabel1.EnableAntialiasing = Utils.DefaultBoolean.True;
            funnelSeriesLabel1.BackColor = System.Drawing.Color.Transparent;
            funnelSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            funnelSeriesLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            funnelSeriesLabel1.Position = DevExpress.XtraCharts.FunnelSeriesLabelPosition.Center;
            funnelSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            funnelSeriesLabel1.TextPattern = "{V:c}";
            series1.Label = funnelSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            funnelSeriesView1.AlignToCenter = true;
            series1.View = funnelSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.SeriesTemplate.View = funnelSeriesView2;
            this.chartControl.Size = new System.Drawing.Size(458, 572);
            this.chartControl.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.CustomizationFormText = "Root";
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFunnel});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.OptionsItemText.TextToControlDistance = 6;
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(458, 572);
            this.Root.Text = "Root";
            // 
            // ItemForFunnel
            // 
            this.ItemForFunnel.Control = this.chartControl;
            this.ItemForFunnel.CustomizationFormText = "ItemForFunnel";
            this.ItemForFunnel.Location = new System.Drawing.Point(0, 0);
            this.ItemForFunnel.Name = "ItemForFunnel";
            this.ItemForFunnel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.ItemForFunnel.Size = new System.Drawing.Size(458, 572);
            this.ItemForFunnel.Text = "ItemForFunnel";
            this.ItemForFunnel.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForFunnel.TextToControlDistance = 0;
            this.ItemForFunnel.TextVisible = false;
            // 
            // QuoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.modueLayout);
            this.Name = "QuoteView";
            this.Size = new System.Drawing.Size(458, 572);
            ((System.ComponentModel.ISupportInitialize)(this.modueLayout)).EndInit();
            this.modueLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFunnel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl modueLayout;
        private XtraLayout.LayoutControlGroup Root;
        private XtraCharts.ChartControl chartControl;
        private XtraLayout.LayoutControlItem ItemForFunnel;
    }
}
