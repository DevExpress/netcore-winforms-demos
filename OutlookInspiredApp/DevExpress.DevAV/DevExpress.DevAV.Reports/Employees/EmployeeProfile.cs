using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.Reports {
    public class EmployeeProfile : DevExpress.XtraReports.UI.XtraReport {
        private XtraReports.UI.TopMarginBand topMarginBand1;
        private XtraReports.UI.DetailBand detailBand1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private XtraReports.UI.XRPictureBox xrPictureBox1;
        private XtraReports.UI.XRPictureBox xrPictureBox2;
        private XtraReports.UI.ReportHeaderBand ReportHeader;
        private XtraReports.UI.XRTable xrTable1;
        private XtraReports.UI.XRTableRow xrTableRow1;
        private XtraReports.UI.XRTableCell xrTableCell1;
        private XtraReports.UI.XRTableCell xrTableCell2;
        private XtraReports.UI.XRTableCell xrTableCell3;
        private XtraReports.UI.XRTable xrTable2;
        private XtraReports.UI.XRTableRow xrTableRow8;
        private XtraReports.UI.XRTableCell xrTableCell15;
        private XtraReports.UI.XRTableRow xrTableRow7;
        private XtraReports.UI.XRTableCell xrTableCell14;
        private XtraReports.UI.XRTable xrTable3;
        private XtraReports.UI.XRTableRow xrTableRow13;
        private XtraReports.UI.XRTableCell xrTableCell20;
        private XtraReports.UI.XRTableCell xrTableCell21;
        private XtraReports.UI.XRTableRow xrTableRow14;
        private XtraReports.UI.XRTableCell xrTableCell22;
        private XtraReports.UI.XRTableCell xrTableCell23;
        private XtraReports.UI.XRTableRow xrTableRow15;
        private XtraReports.UI.XRTableCell xrTableCell24;
        private XtraReports.UI.XRTableCell xrTableCell25;
        private XtraReports.UI.XRTableRow xrTableRow16;
        private XtraReports.UI.XRTableCell xrTableCell26;
        private XtraReports.UI.XRTableCell xrTableCell27;
        private XtraReports.UI.XRTableRow xrTableRow17;
        private XtraReports.UI.XRTableCell xrTableCell28;
        private XtraReports.UI.XRTableCell xrTableCell29;
        private XtraReports.UI.XRTableRow xrTableRow9;
        private XtraReports.UI.XRTableCell xrTableCell16;
        private XtraReports.UI.DetailReportBand DetailReport;
        private XtraReports.UI.DetailBand Detail;
        private XtraReports.UI.XRTable xrTable5;
        private XtraReports.UI.XRTableRow xrTableRow3;
        private XtraReports.UI.XRTableCell xrTableCell7;
        private XtraReports.UI.XRTableCell xrTableCell8;
        private XtraReports.UI.XRTableRow xrTableRow4;
        private XtraReports.UI.XRTableCell xrTableCell9;
        private XtraReports.UI.XRTableCell xrTableCell10;
        private XtraReports.UI.ReportHeaderBand ReportHeader1;
        private XtraReports.UI.XRTable xrTable4;
        private XtraReports.UI.XRTableRow xrTableRow2;
        private XtraReports.UI.XRTableCell xrTableCell4;
        private XtraReports.UI.XRTableCell xrTableCell5;
        private XtraReports.UI.XRTableCell xrTableCell6;
        private XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private XtraReports.UI.GroupHeaderBand GroupHeader1;
        private XtraReports.UI.XRPageInfo xrPageInfo1;
        private XtraReports.UI.XRPageInfo xrPageInfo2;
        private XtraReports.Parameters.Parameter paramEvaluations;

        public EmployeeProfile() {
            InitializeComponent();
            BeforePrint += EmployeeProfile_BeforePrint;
        }

        private void EmployeeProfile_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            SetShowEvaluations((bool)Parameters["paramEvaluations"].Value);
        }
        public void SetShowEvaluations(bool show) {
            if(DetailReport.Visible != show) DetailReport.Visible = show;
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeProfile));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.paramEvaluations = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.topMarginBand1.Dpi = 100F;
            this.topMarginBand1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.topMarginBand1.HeightF = 128F;
            this.topMarginBand1.Name = "topMarginBand1";
            this.topMarginBand1.StylePriority.UseFont = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Dpi = 100F;
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(465.2917F, 52F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(182.7083F, 54.16668F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3,
            this.xrTable2,
            this.xrPictureBox2});
            this.detailBand1.Dpi = 100F;
            this.detailBand1.HeightF = 308.9286F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("FirstName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // xrTable3
            // 
            this.xrTable3.Dpi = 100F;
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(179.1667F, 181.25F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17});
            this.xrTable3.SizeF = new System.Drawing.SizeF(461.5F, 114.1369F);
            this.xrTable3.StylePriority.UsePadding = false;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20,
            this.xrTableCell21});
            this.xrTableRow13.Dpi = 100F;
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 0.65333328891811748D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Dpi = 100F;
            this.xrTableCell20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseForeColor = false;
            this.xrTableCell20.Text = "HOME ADDRESS";
            this.xrTableCell20.Weight = 1.5238964537134105D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Dpi = 100F;
            this.xrTableCell21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseForeColor = false;
            this.xrTableCell21.Text = "PHONE";
            this.xrTableCell21.Weight = 1.4761035462865895D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23});
            this.xrTableRow14.Dpi = 100F;
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 0.47484509486472504D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Dpi = 100F;
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Text = "[Address.Line]";
            this.xrTableCell22.Weight = 1.5238964675999105D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Dpi = 100F;
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Text = "[MobilePhone] (Mobile)";
            this.xrTableCell23.Weight = 1.4761035324000895D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell24,
            this.xrTableCell25});
            this.xrTableRow15.Dpi = 100F;
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1.2140452917989133D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Dpi = 100F;
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Text = "[Address.CityLine]";
            this.xrTableCell24.Weight = 1.5238964514898998D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Dpi = 100F;
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Text = "[HomePhone] (Home)";
            this.xrTableCell25.Weight = 1.4761035485101002D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell26,
            this.xrTableCell27});
            this.xrTableRow16.Dpi = 100F;
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 0.56444328332196525D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Dpi = 100F;
            this.xrTableCell26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.StylePriority.UseForeColor = false;
            this.xrTableCell26.Text = "EMAIL";
            this.xrTableCell26.Weight = 1.5238964900469829D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Dpi = 100F;
            this.xrTableCell27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.StylePriority.UseForeColor = false;
            this.xrTableCell27.Text = "SKYPE";
            this.xrTableCell27.Weight = 1.4761035099530171D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrTableCell29});
            this.xrTableRow17.Dpi = 100F;
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 0.50222112518535189D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Dpi = 100F;
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Text = "[Email]";
            this.xrTableCell28.Weight = 1.523896534941128D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.Dpi = 100F;
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Text = "[Skype]";
            this.xrTableCell29.Weight = 1.476103465058872D;
            // 
            // xrTable2
            // 
            this.xrTable2.Dpi = 100F;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(179.1667F, 14.58333F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8,
            this.xrTableRow7,
            this.xrTableRow9});
            this.xrTable2.SizeF = new System.Drawing.SizeF(462.5F, 129.6131F);
            this.xrTable2.StylePriority.UsePadding = false;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15});
            this.xrTableRow8.Dpi = 100F;
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1.3733330546061278D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Dpi = 100F;
            this.xrTableCell15.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.xrTableCell15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(178)))), ((int)(((byte)(144)))));
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseForeColor = false;
            this.xrTableCell15.Text = "[Prefix]. [FullName]";
            this.xrTableCell15.Weight = 3D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14});
            this.xrTableRow7.Dpi = 100F;
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1.7263104059547862D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Dpi = 100F;
            this.xrTableCell14.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.xrTableCell14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UseForeColor = false;
            this.xrTableCell14.Text = "[TItle]";
            this.xrTableCell14.Weight = 3D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16});
            this.xrTableRow9.Dpi = 100F;
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 0.57521688842586149D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Dpi = 100F;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Text = "[PersonalProfile]";
            this.xrTableCell16.Weight = 3D;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.xrPictureBox2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPictureBox2.BorderWidth = 2F;
            this.xrPictureBox2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Photo")});
            this.xrPictureBox2.Dpi = 100F;
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(154.5417F, 205F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox2.StylePriority.UseBorderColor = false;
            this.xrPictureBox2.StylePriority.UseBorders = false;
            this.xrPictureBox2.StylePriority.UseBorderWidth = false;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.bottomMarginBand1.Dpi = 100F;
            this.bottomMarginBand1.HeightF = 127.0833F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DevExpress.DevAV.Employee);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.ReportHeader.Dpi = 100F;
            this.ReportHeader.HeightF = 41F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 100F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(647.9999F, 28.125F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow1.Dpi = 100F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell1.Dpi = 100F;
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.ForeColor = System.Drawing.Color.White;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Employee List";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.79745375929065565D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Dpi = 100F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Weight = 0.036651192371484773D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.xrTableCell3.Dpi = 100F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.Weight = 2.1658950483378594D;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.ReportHeader1});
            this.DetailReport.DataMember = "Evaluations";
            this.DetailReport.DataSource = this.bindingSource1;
            this.DetailReport.Dpi = 100F;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 85.5F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // xrTable5
            // 
            this.xrTable5.Dpi = 100F;
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 19.875F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Padding = new DevExpress.XtraPrinting.PaddingInfo(4, 0, 2, 0, 100F);
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3,
            this.xrTableRow4});
            this.xrTable5.SizeF = new System.Drawing.SizeF(647.9999F, 65.625F);
            this.xrTable5.StylePriority.UsePadding = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow3.Dpi = 100F;
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.52857141212930436D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Evaluations.CreatedOn", "{0:MM/dd/yyyy}")});
            this.xrTableCell7.Dpi = 100F;
            this.xrTableCell7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.Weight = 0.83410493056778723D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Evaluations.Subject")});
            this.xrTableCell8.Dpi = 100F;
            this.xrTableCell8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.Weight = 2.1658950694322128D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10});
            this.xrTableRow4.Dpi = 100F;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.37142861926020571D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Dpi = 100F;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Weight = 0.83410493056778723D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Evaluations.Details")});
            this.xrTableCell10.Dpi = 100F;
            this.xrTableCell10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.Weight = 2.1658950694322128D;
            // 
            // ReportHeader1
            // 
            this.ReportHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4});
            this.ReportHeader1.Dpi = 100F;
            this.ReportHeader1.HeightF = 28.125F;
            this.ReportHeader1.Name = "ReportHeader1";
            // 
            // xrTable4
            // 
            this.xrTable4.Dpi = 100F;
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable4.SizeF = new System.Drawing.SizeF(647.9999F, 28.125F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow2.Dpi = 100F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell4.Dpi = 100F;
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.ForeColor = System.Drawing.Color.White;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Employee Evaluations";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 0.79745375929065565D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 100F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Weight = 0.036651192371484773D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.xrTableCell6.Dpi = 100F;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.Weight = 2.1658950483378594D;
            // 
            // paramEvaluations
            // 
            this.paramEvaluations.Description = "Evaluations";
            this.paramEvaluations.Name = "paramEvaluations";
            this.paramEvaluations.Type = typeof(bool);
            this.paramEvaluations.ValueInfo = "True";
            this.paramEvaluations.Visible = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Dpi = 100F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("LastName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 100F;
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo1.Format = "Page {0} of {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 9.999974F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(156.25F, 23F);
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Dpi = 100F;
            this.xrPageInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo2.Format = "{0:MMMM d, yyyy}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(411.524F, 9.999974F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(236.4759F, 23F);
            this.xrPageInfo2.StylePriority.UseForeColor = false;
            this.xrPageInfo2.StylePriority.UsePadding = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // EmployeeProfile
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportHeader,
            this.DetailReport,
            this.GroupHeader1});
            this.DataSource = this.bindingSource1;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 128, 127);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramEvaluations});
            this.Version = "16.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
