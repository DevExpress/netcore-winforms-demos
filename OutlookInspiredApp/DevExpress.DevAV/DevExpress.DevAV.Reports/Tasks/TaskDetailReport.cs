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
    public class TaskDetailReport : DevExpress.XtraReports.UI.XtraReport {
        #region fields
        private XtraReports.UI.TopMarginBand topMarginBand1;
        private XtraReports.UI.DetailBand detailBand1;
        private XtraReports.UI.XRPictureBox xrPictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private XtraReports.UI.ReportHeaderBand ReportHeader;
        private XtraReports.UI.XRTable xrTable1;
        private XtraReports.UI.XRTableRow xrTableRow2;
        private XtraReports.UI.XRTableCell xrTableCell1;
        private XtraReports.UI.XRTableCell xrTableCell2;
        private XtraReports.UI.XRTableCell xrTableCell3;
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
        private XtraReports.UI.XRGauge xrGauge1;
        private XtraReports.UI.XRTable xrTable4;
        private XtraReports.UI.XRTableRow xrTableRow15;
        private XtraReports.UI.XRTableCell xrTableCell23;
        private XtraReports.UI.XRRichText xrRichText1;
        private XtraReports.UI.XRTable xrTable3;
        private XtraReports.UI.XRTableRow xrTableRow5;
        private XtraReports.UI.XRTableCell xrTableCell5;
        private XtraReports.UI.XRTableCell xrTableCell8;
        private XtraReports.UI.XRTableCell xrTableCell9;
        private XRLabel xrLabel1;
        private System.ComponentModel.IContainer components;
        #endregion

        public TaskDetailReport() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetailReport));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrGauge1 = new DevExpress.XtraReports.UI.XRGauge();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.topMarginBand1.HeightF = 134.9844F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(472.25F, 52.59F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(170.8333F, 56.41184F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrTable4,
            this.xrTable3,
            this.xrGauge1,
            this.xrTable2});
            this.detailBand1.HeightF = 460.7887F;
            this.detailBand1.Name = "detailBand1";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Completion")});
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(30.20833F, 87.97617F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(123.7501F, 38.16666F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseForeColor = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel1.TextFormatString = "{0}%";
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(182.0912F, 417.5595F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15});
            this.xrTable4.SizeF = new System.Drawing.SizeF(467.9088F, 43.22917F);
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell23});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Weight = 1D;
            // 
            // xrRichText1
            // 
            this.xrRichText1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Rtf", null, "RtfTextDescription")});
            this.xrRichText1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(4.577637E-05F, 0F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(467.9088F, 43.22919F);
            this.xrRichText1.StylePriority.UseFont = false;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 374.7024F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable3.SizeF = new System.Drawing.SizeF(650F, 31.18451F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.StylePriority.UseTextAlignment = false;
            this.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableRow5.Weight = 1.0501101610542218D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrTableCell5.ForeColor = System.Drawing.Color.White;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 100F);
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Details";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell5.Weight = 0.80032469757233127D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Weight = 0.024452088141954528D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.xrTableCell9.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 8, 0, 0, 100F);
            this.xrTableCell9.StylePriority.UseBackColor = false;
            this.xrTableCell9.StylePriority.UseFont = false;
            this.xrTableCell9.StylePriority.UsePadding = false;
            this.xrTableCell9.StylePriority.UseTextAlignment = false;
            this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell9.Weight = 2.2141840142121296D;
            // 
            // xrGauge1
            // 
            this.xrGauge1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("ActualValue", null, "Completion")});
            this.xrGauge1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 12.5F);
            this.xrGauge1.Maximum = 100F;
            this.xrGauge1.Minimum = 0F;
            this.xrGauge1.Name = "xrGauge1";
            this.xrGauge1.SizeF = new System.Drawing.SizeF(180F, 180F);
            this.xrGauge1.StylePriority.UseBorders = false;
            this.xrGauge1.ViewStyle = DevExpress.XtraGauges.Core.Customization.DashboardGaugeStyle.Full;
            this.xrGauge1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrGauge1_BeforePrint);
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(182.0912F, 12.97618F);
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
            this.xrTable2.SizeF = new System.Drawing.SizeF(464.9088F, 341.997F);
            this.xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1.4064880914705391D;
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
            this.xrTableRow4.Weight = 0.95166530949901318D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Weight = 3D;
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
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 139.5417F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DevExpress.DevAV.EmployeeTask);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.ReportHeader.HeightF = 31.18451F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 31.18451F);
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
            this.xrTableRow2.Weight = 1.0501101610542218D;
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
            this.xrTableCell1.Text = "Task Report";
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
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell3.Weight = 2.2141840142121296D;
            // 
            // TaskDetailReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.DrawWatermark = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 135, 140);
            this.Version = "18.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

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
            ImageIndicator imageIndicator = new ImageIndicator();

            SetupArcScale(gaugeControl.Elements[0] as ArcScale);
            SetupRangeBar(gaugeControl, rangeBar);
        }
        void RemoveElements(DashboardGauge gaugeControl) {
            gaugeControl.BeginUpdate();

            gaugeControl.Model.Composite.Remove(gaugeControl.Elements[2] as IRenderableElement);
            gaugeControl.Elements.Remove(gaugeControl.Elements[2]);

            gaugeControl.Model.Composite.Remove(gaugeControl.Elements[1] as IRenderableElement);
            gaugeControl.Elements.Remove(gaugeControl.Elements[1]);

            gaugeControl.EndUpdate();
        }
        void SetupArcScale(ArcScale arcScale) {
            arcScale.EndAngle = 270F;
            arcScale.MaxValue = 100F;
            arcScale.Name = "Gauge0_Scale1";
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
            rangeBar.EndOffset = 18F;
            rangeBar.ZOrder = -10;

            rangeBar.Appearance.BackgroundBrush = new SolidBrushObject("Color:#E0E0E0");
            rangeBar.Appearance.ContentBrush = new SolidBrushObject("Color:#4D82B8");

            gaugeControl.Model.Composite.Add(rangeBar);
            gaugeControl.Elements.Add(rangeBar);

            gaugeControl.EndUpdate();
        }
    }
}
