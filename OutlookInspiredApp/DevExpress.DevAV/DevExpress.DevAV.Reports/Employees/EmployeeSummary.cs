using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.Reports {
    public class EmployeeSummary : DevExpress.XtraReports.UI.XtraReport {
        private XtraReports.UI.TopMarginBand topMarginBand1;
        private XtraReports.UI.DetailBand detailBand1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private XtraReports.UI.ReportHeaderBand ReportHeader;
        private XtraReports.UI.XRPictureBox xrPictureBox1;
        private XtraReports.UI.XRTable xrTable2;
        private XtraReports.UI.XRTableRow xrTableRow10;
        private XtraReports.UI.XRTableCell xrTableCell15;
        private XtraReports.UI.XRTableCell xrTableCell16;
        private XtraReports.UI.XRTableCell xrTableCell17;
        private XtraReports.UI.XRPageInfo xrPageInfo1;
        private XtraReports.UI.XRPageInfo xrPageInfo2;
        private XtraReports.UI.XRPictureBox xrPictureBox2;
        private XtraReports.UI.XRTable xrTable1;
        private XtraReports.UI.XRTableRow xrTableRow1;
        private XtraReports.UI.XRTableCell xrTableCell1;
        private XtraReports.UI.XRTableRow xrTableRow2;
        private XtraReports.UI.XRTableCell xrTableCell2;
        private XtraReports.UI.XRTableRow xrTableRow4;
        private XtraReports.UI.XRTableCell xrTableCell5;
        private XtraReports.UI.XRTableRow xrTableRow3;
        private XtraReports.UI.XRTableCell xrTableCell4;
        private XtraReports.UI.XRTableCell xrTableCell3;
        private XtraReports.UI.XRTableRow xrTableRow5;
        private XtraReports.UI.XRTableCell xrTableCell6;
        private XtraReports.UI.XRTableCell xrTableCell7;
        private XtraReports.UI.XRTableRow xrTableRow6;
        private XtraReports.UI.XRTableCell xrTableCell8;
        private XtraReports.UI.XRTableCell xrTableCell9;
        private XtraReports.UI.XRTableRow xrTableRow7;
        private XtraReports.UI.XRTableCell xrTableCell10;
        private XtraReports.UI.XRTableRow xrTableRow8;
        private XtraReports.UI.XRTableCell xrTableCell12;
        private XtraReports.UI.XRTableCell xrTableCell11;
        private XtraReports.UI.XRTableRow xrTableRow9;
        private XtraReports.UI.XRTableCell xrTableCell13;
        private XtraReports.UI.XRTableCell xrTableCell14;
        private XtraReports.UI.XRLine xrLine1;
        private XtraReports.Parameters.Parameter paramAscending;
        private XtraReports.UI.GroupHeaderBand GroupHeader1;
        private XtraReports.UI.BottomMarginBand bottomMarginBand1;

        public EmployeeSummary() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSummary));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.paramAscending = new DevExpress.XtraReports.Parameters.Parameter();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2});
            this.topMarginBand1.Dpi = 100F;
            this.topMarginBand1.HeightF = 125F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Dpi = 100F;
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(470.8333F, 52.08333F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(170.8333F, 56.41184F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1,
            this.xrPictureBox1});
            this.detailBand1.Dpi = 100F;
            this.detailBand1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailBand1.HeightF = 256F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("FirstName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.detailBand1.StylePriority.UseFont = false;
            this.detailBand1.StylePriority.UseForeColor = false;
            // 
            // xrTable1
            // 
            this.xrTable1.Dpi = 100F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(179.8967F, 17.82827F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow2,
            this.xrTableRow4,
            this.xrTableRow3,
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9});
            this.xrTable1.SizeF = new System.Drawing.SizeF(461.77F, 217.2385F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1});
            this.xrTableRow1.Dpi = 100F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 0.63958756585072929D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.CanGrow = false;
            this.xrTableCell1.Dpi = 100F;
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(178)))), ((int)(((byte)(144)))));
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "[Prefix]. [FullName]";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableCell1.Weight = 3D;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2});
            this.xrTableRow2.Dpi = 100F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.4068930757754366D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Title")});
            this.xrTableCell2.Dpi = 100F;
            this.xrTableCell2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseForeColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell2.Weight = 3D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5});
            this.xrTableRow4.Dpi = 100F;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.47679215639238742D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1});
            this.xrTableCell5.Dpi = 100F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Weight = 3D;
            // 
            // xrLine1
            // 
            this.xrLine1.Dpi = 100F;
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 3.973643E-05F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(461.77F, 32.59834F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell3});
            this.xrTableRow3.Dpi = 100F;
            this.xrTableRow3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.StylePriority.UseForeColor = false;
            this.xrTableRow3.Weight = 0.27799953466570859D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.Dpi = 100F;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseBorderColor = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.Text = "HOME ADDRESS";
            this.xrTableCell4.Weight = 1.4636767710884846D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.CanGrow = false;
            this.xrTableCell3.Dpi = 100F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "PHONE";
            this.xrTableCell3.Weight = 1.5363232289115154D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell7});
            this.xrTableRow5.Dpi = 100F;
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.27270867469998472D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.CanGrow = false;
            this.xrTableCell6.Dpi = 100F;
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.RowSpan = 2;
            this.xrTableCell6.Text = "[Address.Line]\r\n[Address.CityLine]";
            this.xrTableCell6.Weight = 1.4636768842199621D;
            this.xrTableCell6.WordWrap = false;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.CanGrow = false;
            this.xrTableCell7.Dpi = 100F;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.Text = "[MobilePhone] (Mobile)";
            this.xrTableCell7.Weight = 1.5363231157800379D;
            this.xrTableCell7.WordWrap = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow6.Dpi = 100F;
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 0.296050406027006D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.Dpi = 100F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "xrTableCell8";
            this.xrTableCell8.Weight = 1.4636768842199621D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.CanGrow = false;
            this.xrTableCell9.Dpi = 100F;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "[HomePhone] (Home)";
            this.xrTableCell9.Weight = 1.5363231157800379D;
            this.xrTableCell9.WordWrap = false;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10});
            this.xrTableRow7.Dpi = 100F;
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 0.20932491335747283D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Dpi = 100F;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Weight = 3D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell11});
            this.xrTableRow8.Dpi = 100F;
            this.xrTableRow8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.StylePriority.UseForeColor = false;
            this.xrTableRow8.Weight = 0.27782294316403405D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Dpi = 100F;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Text = "EMAIL";
            this.xrTableCell12.Weight = 1.4636771502088639D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Dpi = 100F;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Text = "SKYPE";
            this.xrTableCell11.Weight = 1.5363228497911361D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow9.Dpi = 100F;
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 0.32020800489844209D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Email")});
            this.xrTableCell13.Dpi = 100F;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Weight = 1.4636770897901221D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Skype")});
            this.xrTableCell14.Dpi = 100F;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Weight = 1.5363229102098779D;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Photo")});
            this.xrPictureBox1.Dpi = 100F;
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(7.65625F, 19.91159F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(152.3728F, 208.25F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
            this.bottomMarginBand1.Dpi = 100F;
            this.bottomMarginBand1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMarginBand1.HeightF = 102F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            this.bottomMarginBand1.StylePriority.UseFont = false;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Dpi = 100F;
            this.xrPageInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo2.Format = "{0:MMMM d, yyyy}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(405.1908F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 6, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(236.4759F, 23F);
            this.xrPageInfo2.StylePriority.UseForeColor = false;
            this.xrPageInfo2.StylePriority.UsePadding = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 100F;
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo1.Format = "Page {0} of {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(156.25F, 23F);
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DevExpress.DevAV.Employee);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.ReportHeader.Dpi = 100F;
            this.ReportHeader.HeightF = 30F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.Dpi = 100F;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable2.SizeF = new System.Drawing.SizeF(641.6667F, 29.69642F);
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17});
            this.xrTableRow10.Dpi = 100F;
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell15.Dpi = 100F;
            this.xrTableCell15.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell15.ForeColor = System.Drawing.Color.White;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell15.StylePriority.UseBackColor = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseForeColor = false;
            this.xrTableCell15.StylePriority.UsePadding = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "Employee List";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell15.Weight = 0.7808441558441559D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Dpi = 100F;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Weight = 0.043932629870129913D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.xrTableCell17.Dpi = 100F;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBackColor = false;
            this.xrTableCell17.Weight = 2.1752232142857144D;
            // 
            // paramAscending
            // 
            this.paramAscending.Description = "Ascending";
            this.paramAscending.Name = "paramAscending";
            this.paramAscending.Type = typeof(bool);
            this.paramAscending.ValueInfo = "True";
            this.paramAscending.Visible = false;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Dpi = 100F;
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("LastName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 0F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // EmployeeSummary
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportHeader,
            this.GroupHeader1});
            this.DataSource = this.bindingSource1;
            this.Margins = new System.Drawing.Printing.Margins(104, 104, 125, 102);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramAscending});
            this.Version = "16.2";
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.EmployeeSummary_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void EmployeeSummary_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if(Equals(true, paramAscending.Value)) {
                this.detailBand1.SortFields[0].SortOrder = XtraReports.UI.XRColumnSortOrder.Ascending;
                this.GroupHeader1.GroupFields[0].SortOrder = XtraReports.UI.XRColumnSortOrder.Ascending;
            } else {
                this.detailBand1.SortFields[0].SortOrder = XtraReports.UI.XRColumnSortOrder.Descending;
                this.GroupHeader1.GroupFields[0].SortOrder = XtraReports.UI.XRColumnSortOrder.Descending;
            }
        }
    } 
}
