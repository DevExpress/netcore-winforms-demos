using DevExpress.XtraGauges.Core.Customization;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Primitive;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DevExpress.DevAV.Reports {
    public class TaskListReport : DevExpress.XtraReports.UI.XtraReport {
        private XtraReports.UI.TopMarginBand topMarginBand1;
        private XtraReports.UI.DetailBand detailBand1;
        private XtraReports.UI.XRPictureBox xrPictureBox2;
        private XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private XtraReports.Parameters.Parameter paramDueDate;
        private XtraReports.UI.ReportHeaderBand ReportHeader;
        private XtraReports.UI.XRTable xrTable1;
        private XtraReports.UI.XRTableRow xrTableRow2;
        private XtraReports.UI.XRTableCell xrTableCell1;
        private XtraReports.UI.XRTableCell xrTableCell2;
        private XtraReports.UI.XRTableCell xrTableCell3;
        private XtraReports.UI.XRGauge xrGauge1;
        private XtraReports.UI.XRTable xrTable2;
        private XtraReports.UI.XRTableRow xrTableRow1;
        private XtraReports.UI.XRTableCell xrTableCell4;
        private XtraReports.UI.XRTableRow xrTableRow3;
        private XtraReports.UI.XRTableCell xrTableCell7;
        private XtraReports.UI.XRTableRow xrTableRow4;
        private XtraReports.UI.XRTableCell xrTableCell10;
        private XtraReports.UI.XRTableRow xrTableRow6;
        private XtraReports.UI.XRTableCell xrTableCell11;
        private XtraReports.UI.XRTableCell xrTableCell6;
        private XtraReports.UI.XRTableRow xrTableRow7;
        private XtraReports.UI.XRTableCell xrTableCell12;
        private XtraReports.UI.XRTableCell xrTableCell13;
        private XtraReports.UI.XRTableRow xrTableRow8;
        private XtraReports.UI.XRTableCell xrTableCell14;
        private XtraReports.UI.XRTableRow xrTableRow9;
        private XtraReports.UI.XRTableCell xrTableCell16;
        private XtraReports.UI.XRTableCell xrTableCell15;
        private XtraReports.UI.XRTableRow xrTableRow10;
        private XtraReports.UI.XRTableCell xrTableCell17;
        private XtraReports.UI.XRTableCell xrTableCell18;
        private XtraReports.UI.XRTableRow xrTableRow11;
        private XtraReports.UI.XRTableCell xrTableCell19;
        private XtraReports.UI.XRTableRow xrTableRow12;
        private XtraReports.UI.XRTableCell xrTableCell20;
        private XtraReports.UI.XRTableRow xrTableRow13;
        private XtraReports.UI.XRTableCell xrTableCell21;
        private XtraReports.UI.XRLine xrLine1;
        private XtraReports.UI.XRPageInfo xrPageInfo1;
        private XtraReports.UI.XRPageInfo xrPageInfo2;
        private XRLabel xrLabel1;
        private System.ComponentModel.IContainer components;

        public TaskListReport() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskListReport));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrGauge1 = new DevExpress.XtraReports.UI.XRGauge();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paramDueDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox2});
            this.topMarginBand1.HeightF = 134.9844F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox2.Image")));
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(472F, 53F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(170.8333F, 56.41184F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrTable2,
            this.xrGauge1});
            this.detailBand1.HeightF = 365.75F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("DueDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Completion")});
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(26F, 69F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(124F, 38F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel1.TextFormatString = "{0}%";
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(185.0911F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10,
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow13});
            this.xrTable2.SizeF = new System.Drawing.SizeF(464.9088F, 315.243F);
            this.xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1.4561409052612624D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Subject")});
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.xrTableCell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(178)))), ((int)(((byte)(144)))));
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.Weight = 3D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.43358413797172923D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.CanGrow = false;
            this.xrTableCell7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AssignedEmployeesFullList")});
            this.xrTableCell7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.xrTableCell7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseForeColor = false;
            this.xrTableCell7.Weight = 3D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.5157897018652231D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1});
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Weight = 3D;
            // 
            // xrLine1
            // 
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(464.9089F, 24.28609F);
            this.xrLine1.StylePriority.UseForeColor = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell6});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 0.26817029657063368D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.CanGrow = false;
            this.xrTableCell11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseForeColor = false;
            this.xrTableCell11.Text = "START DATE";
            this.xrTableCell11.Weight = 1.4690801221887797D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.CanGrow = false;
            this.xrTableCell6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.StylePriority.UseForeColor = false;
            this.xrTableCell6.Text = "DUE DATE";
            this.xrTableCell6.Weight = 1.5309198778112203D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell13});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 0.26817032410528907D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.CanGrow = false;
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "StartDate", "{0:MMMM d, yyyy}")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Text = "January 1, 2015";
            this.xrTableCell12.Weight = 1.4690799252625617D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.CanGrow = false;
            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "DueDate", "{0:MMMM d, yyyy}")});
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Text = "January 1, 2015";
            this.xrTableCell13.Weight = 1.5309200747374383D;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 0.24442671984616451D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Weight = 3D;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell15});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 0.29191392836441366D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.CanGrow = false;
            this.xrTableCell16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseForeColor = false;
            this.xrTableCell16.Text = "STATUS";
            this.xrTableCell16.Weight = 1.4690799252625617D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.CanGrow = false;
            this.xrTableCell15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseForeColor = false;
            this.xrTableCell15.Text = "PRIORIRY";
            this.xrTableCell15.Weight = 1.5309200747374383D;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell17,
            this.xrTableCell18});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 0.26817032410528907D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Status")});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Text = "Incomplete";
            this.xrTableCell17.Weight = 1.4690799252625617D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Priority")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Text = "High";
            this.xrTableCell18.Weight = 1.5309200747374383D;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 0.26817032410528907D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Weight = 3D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 0.24960543844855337D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.CanGrow = false;
            this.xrTableCell20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseForeColor = false;
            this.xrTableCell20.Text = "OWNER";
            this.xrTableCell20.Weight = 3D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 0.28673520976202477D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.CanGrow = false;
            this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Owner.FullName")});
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "James Doe";
            this.xrTableCell21.Weight = 3D;
            // 
            // xrGauge1
            // 
            this.xrGauge1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("ActualValue", null, "Completion")});
            this.xrGauge1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrGauge1.Maximum = 100F;
            this.xrGauge1.Minimum = 0F;
            this.xrGauge1.Name = "xrGauge1";
            this.xrGauge1.SizeF = new System.Drawing.SizeF(180F, 180F);
            this.xrGauge1.StylePriority.UseBorders = false;
            this.xrGauge1.ViewStyle = DevExpress.XtraGauges.Core.Customization.DashboardGaugeStyle.Full;
            this.xrGauge1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrGauge1_BeforePrint);
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo1.Format = "Page {0} of {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(156.25F, 23F);
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo2.Format = "{0:MMMM d, yyyy}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(485.4167F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(156.25F, 23F);
            this.xrPageInfo2.StylePriority.UseForeColor = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DevExpress.DevAV.EmployeeTask);
            // 
            // paramDueDate
            // 
            this.paramDueDate.Description = "DueDate";
            this.paramDueDate.Name = "paramDueDate";
            this.paramDueDate.Type = typeof(bool);
            this.paramDueDate.ValueInfo = "True";
            this.paramDueDate.Visible = false;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.ReportHeader.HeightF = 44.09029F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 29.69642F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UseTextAlignment = false;
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrTableCell1.ForeColor = System.Drawing.Color.White;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Task List";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.80032469757233127D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Weight = 0.024452088141954528D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.xrTableCell3.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Sort Order: Due Date";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 2.2141840142121296D;
            // 
            // TaskListReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.DrawWatermark = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 135, 100);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramDueDate});
            this.Version = "15.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.TaskListReport_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void TaskListReport_DataSourceDemanded(object sender, EventArgs e) {
            if(Equals(true, paramDueDate.Value)) {
                xrTableCell3.Text = "Sort Order: Due Date";
                this.detailBand1.SortFields[0].FieldName = "DueDate";
            } else {
                xrTableCell3.Text = "Sort Order: Start Date";
                this.detailBand1.SortFields[0].FieldName = "StartDate";
            }
        
        }

        bool onFirstBeforePrint = true;
        private void xrGauge1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if(!onFirstBeforePrint)
                return;
            XRGauge gauge = sender as XRGauge;
            ModifyGauge(gauge);
        }
        private void ModifyGauge(XRGauge gauge) {
            DashboardGauge gaugeControl = gauge.Gauge as DashboardGauge;
            RemoveElements(gaugeControl);

            ArcScaleRangeBar rangeBar = new ArcScaleRangeBar() { ArcScale = gaugeControl.Elements[0] as ArcScale };

            SetupArcScale(gaugeControl.Elements[0] as ArcScale);
            SetupRangeBar(gaugeControl, rangeBar);
        }
        void RemoveElements(DashboardGauge gaugeControl) {
            gaugeControl.BeginUpdate();

            if(gaugeControl.Elements.Count == 3) {
                gaugeControl.Model.Composite.Remove(gaugeControl.Elements[2] as IRenderableElement);
                gaugeControl.Elements.Remove(gaugeControl.Elements[2]);
            }

            gaugeControl.Model.Composite.Remove(gaugeControl.Elements[1] as IRenderableElement);
            gaugeControl.Elements.Remove(gaugeControl.Elements[1]);

            gaugeControl.EndUpdate();
        }
        void SetupArcScale(ArcScale arcScale) {
            arcScale.EndAngle = 270F;
            arcScale.MaxValue = 100F;
            arcScale.Name = "Gauge0_Scale1";
            arcScale.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(115F, 115F);
            arcScale.RadiusX = 100F;
            arcScale.RadiusY = 100F;
            arcScale.StartAngle = -90F;
            arcScale.Value = 50F;
            arcScale.MajorTickCount = 0;
            arcScale.MajorTickmark.ShowTick = false;
        }
        void SetupRangeBar(DashboardGauge gaugeControl, ArcScaleRangeBar rangeBar) {
            gaugeControl.BeginUpdate();

            rangeBar.Name = "arcScaleRangeBarComponent2";
            rangeBar.RoundedCaps = true;
            rangeBar.ShowBackground = true;
            rangeBar.StartOffset = 100F;
            rangeBar.EndOffset = 17F;
            rangeBar.ZOrder = -10;

            rangeBar.Appearance.BackgroundBrush = new SolidBrushObject("Color:#E0E0E0");
            rangeBar.Appearance.ContentBrush = new SolidBrushObject("Color:#4D82B8");

            gaugeControl.Model.Composite.Add(rangeBar);
            gaugeControl.Elements.Add(rangeBar);

            gaugeControl.EndUpdate();
        }
    }
}
