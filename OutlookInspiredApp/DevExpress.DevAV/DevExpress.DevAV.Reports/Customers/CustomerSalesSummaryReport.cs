﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraReports.UI;
using System.Reflection;
using System.Drawing;
using System.Data;

namespace DevExpress.DevAV.Reports {
    public class CustomerSalesSummaryReport : DevExpress.XtraReports.UI.XtraReport {
        private XtraReports.UI.TopMarginBand topMarginBand1;
        private XtraReports.UI.DetailBand detailBand1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private XtraReports.UI.XRPictureBox xrPictureBox1;
        private XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private XtraReports.UI.XRPageInfo xrPageInfo1;
        private XtraReports.UI.ReportHeaderBand ReportHeader;
        private XRTable xrTable3;
        private XRTableRow xrTableRow8;
        private XRTableCell xrTableCell15;
        private XRTableRow xrTableRow7;
        private XRTableCell xrTableCell7;
        private XRTableCell xrTableCell14;
        private XRTableRow xrTableRow3;
        private XRTableCell xrTableCell8;
        private XRTableCell xrTableCell9;
        private XRTableRow xrTableRow4;
        private XRTableCell xrTableCell10;
        private XRTableCell xrTableCell11;
        private XRTableRow xrTableRow5;
        private XRTableCell xrTableCell12;
        private XRTableCell xrTableCell13;
        private XRPictureBox xrPictureBox4;
        private XRPageInfo xrPageInfo2;
        private XRTable xrTable2;
        private XRTableRow xrTableRow2;
        private XRTableCell xrTableCell4;
        private XRTableCell xrTableCell5;
        private XRTable xrTable1;
        private XRTableRow xrTableRow1;
        private XRTableCell xrTableCell1;
        private XRTableCell xrTableCell2;
        private XRTable xrTable4;
        private XRTableRow xrTableRow6;
        private XRTableCell xrTableCell3;
        private XRTableCell xrTableCell6;
        private XRTable xrTable7;
        private XRTableRow xrTableRow11;
        private XRTableCell xrTableCell36;
        private XRTableCell xrTableCell37;
        private XRTableCell xrTableCell38;
        private XRTableCell xrTableCell39;
        private XRTableCell xrTableCell40;
        private XRTableCell xrTableCell41;
        private XRTable xrTable6;
        private XRTableRow xrTableRow10;
        private XRTableCell xrTableCell30;
        private XRTableCell xrTableCell31;
        private XRTableCell xrTableCell32;
        private XRTableCell xrTableCell33;
        private XRTableCell xrTableCell34;
        private XRTableCell xrTableCell35;
        private XRLabel xrLabel4;
        private XRLabel xrLabel5;
        private GroupHeaderBand GroupHeader1;
        private GroupFooterBand GroupFooter1;
        private XRTable xrTable5;
        private XRTableRow xrTableRow9;
        private XRTableCell xrTableCell16;
        private XRTableCell xrTableCell17;
        private XRTable xrTable8;
        private XRTableRow xrTableRow12;
        private XRTableCell xrTableCell18;
        private XRTableRow xrTableRow13;
        private XRTableCell xrTableCell19;
        private XRTableRow xrTableRow14;
        private XRTableCell xrTableCell20;
        private XRTableRow xrTableRow15;
        private XRTableCell xrTableCell21;
        private XRTableRow xrTableRow16;
        private XRTableCell xrTableCell22;
        private XRTableRow xrTableRow17;
        private XRTableCell xrTableCell23;
        private Color backCellColor = System.Drawing.Color.FromArgb(223, 223, 223);
        private Color foreCellColor = System.Drawing.Color.FromArgb(221, 128, 71);
        private XtraReports.Parameters.Parameter paramFromDate;
        private XRChart xrChart1;
        private XtraReports.Parameters.Parameter paramOrderDate;
        private XtraReports.Parameters.Parameter paramToDate;

        public CustomerSalesSummaryReport() {
            InitializeComponent();
            ParameterHelper.InitializeDateTimeParameters(paramFromDate, paramToDate);
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSalesSummaryReport));
            DevExpress.XtraCharts.SimpleDiagram simpleDiagram1 = new DevExpress.XtraCharts.SimpleDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
            this.paramFromDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrPictureBox4 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.paramToDate = new DevExpress.XtraReports.Parameters.Parameter();
            this.paramOrderDate = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // paramFromDate
            // 
            this.paramFromDate.Description = "ParamFromDate";
            this.paramFromDate.Name = "paramFromDate";
            this.paramFromDate.Type = typeof(System.DateTime);
            this.paramFromDate.ValueInfo = "2013-01-01";
            this.paramFromDate.Visible = false;
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.topMarginBand1.HeightF = 119F;
            this.topMarginBand1.Name = "topMarginBand1";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(473.9583F, 51F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(170.8333F, 56.41184F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // detailBand1
            // 
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7});
            this.detailBand1.HeightF = 20.27876F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            // 
            // xrTable7
            // 
            this.xrTable7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(2.05829E-05F, 0F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
            this.xrTable7.SizeF = new System.Drawing.SizeF(650F, 20.27876F);
            this.xrTable7.StylePriority.UseFont = false;
            this.xrTable7.StylePriority.UseForeColor = false;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.StylePriority.UseTextAlignment = false;
            this.xrTableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.CanGrow = false;
            this.xrTableCell36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "OrderDate", "{0:MM/dd/yyyy}")});
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell36.StylePriority.UsePadding = false;
            this.xrTableCell36.StylePriority.UseTextAlignment = false;
            this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell36.Weight = 0.59429261207580253D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.CanGrow = false;
            this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "InvoiceNumber")});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell37.StylePriority.UsePadding = false;
            this.xrTableCell37.StylePriority.UseTextAlignment = false;
            this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell37.Weight = 0.54843580062572306D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.CanGrow = false;
            this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ProductUnits")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.StylePriority.UseTextAlignment = false;
            this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell38.Weight = 0.399939912733946D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.CanGrow = false;
            this.xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ProductPrice", "{0:$#,#}")});
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.StylePriority.UseTextAlignment = false;
            this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell39.Weight = 0.40955509665451173D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.CanGrow = false;
            this.xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Discount", "{0:$#,#;$#,#; -    }")});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrTableCell40.StylePriority.UsePadding = false;
            this.xrTableCell40.StylePriority.UseTextAlignment = false;
            this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell40.Weight = 0.35327297724209294D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.CanGrow = false;
            this.xrTableCell41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Total", "{0:$#,#}")});
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrTableCell41.StylePriority.UsePadding = false;
            this.xrTableCell41.StylePriority.UseTextAlignment = false;
            this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell41.Weight = 0.69450360066792372D;
            // 
            // xrTable3
            // 
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(178.5F, 55.12498F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8,
            this.xrTableRow7,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5});
            this.xrTable3.SizeF = new System.Drawing.SizeF(462.5F, 184.1186F);
            this.xrTable3.StylePriority.UsePadding = false;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1.3733330546061278D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomerName")});
            this.xrTableCell15.Font = new System.Drawing.Font("Segoe UI", 26.25F);
            this.xrTableCell15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(178)))), ((int)(((byte)(144)))));
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseForeColor = false;
            this.xrTableCell15.Weight = 3D;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell14});
            this.xrTableRow7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xrTableRow7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.StylePriority.UseFont = false;
            this.xrTableRow7.StylePriority.UseForeColor = false;
            this.xrTableRow7.StylePriority.UsePadding = false;
            this.xrTableRow7.StylePriority.UseTextAlignment = false;
            this.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableRow7.Weight = 1.1629306803809705D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "HOME OFFICE";
            this.xrTableCell7.Weight = 1.4122964395059121D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UseForeColor = false;
            this.xrTableCell14.Text = "BILLING ADDRESS";
            this.xrTableCell14.Weight = 1.5877035604940879D;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1.2264701559025575D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "[CustomerHomeOfficeLine]\r\n[CustomerHomeOfficeCityLine]";
            this.xrTableCell8.Weight = 1.4122964395059121D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "[CustomerBillingAddressLine]\r\n[CustomerBillingAddressCityLine]";
            this.xrTableCell9.Weight = 1.5877035604940879D;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11});
            this.xrTableRow4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.StylePriority.UseForeColor = false;
            this.xrTableRow4.StylePriority.UsePadding = false;
            this.xrTableRow4.StylePriority.UseTextAlignment = false;
            this.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableRow4.Weight = 0.84523535774366332D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Text = "PHONE";
            this.xrTableCell10.Weight = 1.4122964395059121D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Text = "FAX";
            this.xrTableCell11.Weight = 1.5877035604940879D;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell13});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 0.61225922764545693D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomerPhone")});
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Weight = 1.4122964395059121D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomerFax")});
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Weight = 1.5877035604940879D;
            // 
            // xrPictureBox4
            // 
            this.xrPictureBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrPictureBox4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPictureBox4.BorderWidth = 1F;
            this.xrPictureBox4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "CustomerImage")});
            this.xrPictureBox4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 57.12503F);
            this.xrPictureBox4.Name = "xrPictureBox4";
            this.xrPictureBox4.SizeF = new System.Drawing.SizeF(158.7394F, 190.1483F);
            this.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            this.xrPictureBox4.StylePriority.UseBorderColor = false;
            this.xrPictureBox4.StylePriority.UseBorders = false;
            this.xrPictureBox4.StylePriority.UseBorderWidth = false;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1});
            this.bottomMarginBand1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMarginBand1.HeightF = 93.37114F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            this.bottomMarginBand1.StylePriority.UseFont = false;
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
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(DevExpress.DevAV.CustomerSaleDetailOrderItemInfo);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1,
            this.xrTable8,
            this.xrTable1,
            this.xrTable2,
            this.xrPictureBox4,
            this.xrTable3,
            this.xrTable4});
            this.ReportHeader.HeightF = 630.4186F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrChart1
            // 
            this.xrChart1.BorderColor = System.Drawing.Color.Black;
            this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            simpleDiagram1.EqualPieSize = false;
            this.xrChart1.Diagram = simpleDiagram1;
            this.xrChart1.EmptyChartText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.xrChart1.EmptyChartText.Text = "\r\n";
            this.xrChart1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.xrChart1.Legend.EnableAntialiasing = Utils.DefaultBoolean.True;
            this.xrChart1.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.xrChart1.Legend.EquallySpacedItems = false;
            this.xrChart1.Legend.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.xrChart1.Legend.MarkerSize = new System.Drawing.Size(20, 20);
            this.xrChart1.Legend.Padding.Left = 30;
            this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 309.375F);
            this.xrChart1.Name = "xrChart1";
            series1.ArgumentDataMember = "ProductCategory";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            pieSeriesLabel1.TextPattern = "{V:$#,#}";
            series1.Label = pieSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            series1.LegendTextPattern = "{A}\n{V:$#,#}\n";
            series1.Name = "Series 1";
            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([Total])";
            series1.SynchronizePointOptions = false;
            pieSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            pieSeriesView1.RuntimeExploding = false;
            pieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            series1.View = pieSeriesView1;
            this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.xrChart1.SeriesTemplate.SynchronizePointOptions = false;
            pieSeriesView2.RuntimeExploding = false;
            pieSeriesView2.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Counterclockwise;
            this.xrChart1.SeriesTemplate.View = pieSeriesView2;
            this.xrChart1.SizeF = new System.Drawing.SizeF(356.6193F, 248.0208F);
            // 
            // xrTable8
            // 
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(407.0465F, 357.1042F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow16,
            this.xrTableRow17});
            this.xrTable8.SizeF = new System.Drawing.SizeF(242.9535F, 175.5873F);
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell18});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 0.77837459842722589D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.Text = "Total sales in date range was";
            this.xrTableCell18.Weight = 3D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1.3828073576824858D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Total")});
            this.xrTableCell19.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            xrSummary1.FormatString = "{0:$#,#}";
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell19.Summary = xrSummary1;
            this.xrTableCell19.Weight = 3D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell20});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 0.83881804389028847D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.Text = "Total discounts on orders was ";
            this.xrTableCell20.Weight = 3D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1.28206876997332D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Discount")});
            this.xrTableCell21.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.StylePriority.UseFont = false;
            xrSummary2.FormatString = "{0:$#,#}";
            xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell21.Summary = xrSummary2;
            this.xrTableCell21.Weight = 3D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 0.71793123002668D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.Text = "Top-selling store was";
            this.xrTableCell22.Weight = 3D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell23});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Total")});
            this.xrTableCell23.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseFont = false;
            xrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell23.Summary = xrSummary3;
            this.xrTableCell23.Weight = 3D;
            this.xrTableCell23.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(this.xrTableCell23_SummaryGetResult);
            this.xrTableCell23.SummaryReset += new System.EventHandler(this.xrTableCell23_SummaryReset);
            this.xrTableCell23.SummaryRowChanged += new System.EventHandler(this.xrTableCell23_SummaryRowChanged);
            // 
            // xrTable1
            // 
            this.xrTable1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 271.875F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(647.9999F, 37.5F);
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1.3333334941638817D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell1.ForeColor = System.Drawing.Color.White;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Analysis";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.8195229174103581D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrTableCell2.StylePriority.UseBackColor = false;
            this.xrTableCell2.StylePriority.UsePadding = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "July 1, 2013 to July 31, 2013";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell2.Weight = 2.1804770825896416D;
            // 
            // xrTable2
            // 
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(647.9999F, 37.5F);
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1.3333334941638817D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.ForeColor = System.Drawing.Color.White;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell4.StylePriority.UseBackColor = false;
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "Customer Profile";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell4.Weight = 0.8195229174103581D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseBackColor = false;
            this.xrTableCell5.Weight = 2.1804770825896416D;
            // 
            // xrTable4
            // 
            this.xrTable4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 578.0417F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable4.SizeF = new System.Drawing.SizeF(650F, 37.5F);
            this.xrTable4.StylePriority.UseFont = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell6});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1.3333334941638817D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell3.ForeColor = System.Drawing.Color.White;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseForeColor = false;
            this.xrTableCell3.StylePriority.UsePadding = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Orders";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell3.Weight = 0.8195229174103581D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrTableCell6.StylePriority.UseBackColor = false;
            this.xrTableCell6.StylePriority.UseFont = false;
            this.xrTableCell6.StylePriority.UsePadding = false;
            this.xrTableCell6.StylePriority.UseTextAlignment = false;
            this.xrTableCell6.Text = "Grouped by Category | Sorted by Order Date";
            this.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell6.Weight = 2.1804770825896416D;
            // 
            // xrTable6
            // 
            this.xrTable6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTable6.ForeColor = System.Drawing.Color.Gray;
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(1.589457E-05F, 64.00003F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable6.SizeF = new System.Drawing.SizeF(650F, 24.99998F);
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseForeColor = false;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(15, 0, 0, 0, 100F);
            this.xrTableCell30.StylePriority.UsePadding = false;
            this.xrTableCell30.StylePriority.UseTextAlignment = false;
            this.xrTableCell30.Text = "ORDER DATE";
            this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell30.Weight = 0.65655051378103091D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.StylePriority.UseTextAlignment = false;
            this.xrTableCell31.Text = "INVOICE #";
            this.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell31.Weight = 0.48617789892049473D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.StylePriority.UseTextAlignment = false;
            this.xrTableCell32.Text = "QTY";
            this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell32.Weight = 0.399939912733946D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.StylePriority.UseTextAlignment = false;
            this.xrTableCell33.Text = "PRICE";
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell33.Weight = 0.40955509665451173D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.StylePriority.UseTextAlignment = false;
            this.xrTableCell34.Text = "DISCOUNT";
            this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell34.Weight = 0.35327269554137175D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrTableCell35.StylePriority.UsePadding = false;
            this.xrTableCell35.StylePriority.UseTextAlignment = false;
            this.xrTableCell35.Text = "ORDER AMOUNT";
            this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell35.Weight = 0.6945038823686448D;
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ProductCategory")});
            this.xrLabel4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 7.999992F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(156.25F, 31.33335F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UsePadding = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel4.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel4_BeforePrint);
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "ProductCategory")});
            this.xrLabel5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(156.25F, 7.999996F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(200.3693F, 31.33335F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            xrSummary4.FormatString = "| # OF ORDERS: {0}";
            xrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
            xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrLabel5.Summary = xrSummary4;
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrTable6,
            this.xrLabel4});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductCategory", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 89.00002F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable5});
            this.GroupFooter1.HeightF = 43.799F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // xrTable5
            // 
            this.xrTable5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(439.8059F, 18.79899F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable5.SizeF = new System.Drawing.SizeF(210.1941F, 25.00001F);
            this.xrTable5.StylePriority.UseFont = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "TOTAL";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell16.Weight = 0.93984267887268125D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Total")});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100F);
            this.xrTableCell17.StylePriority.UsePadding = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            xrSummary5.FormatString = "{0:$#,#}";
            xrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            this.xrTableCell17.Summary = xrSummary5;
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell17.Weight = 1.0653644820811168D;
            // 
            // paramToDate
            // 
            this.paramToDate.Description = "ParamToDate";
            this.paramToDate.Name = "paramToDate";
            this.paramToDate.Type = typeof(System.DateTime);
            this.paramToDate.ValueInfo = "2015-01-01";
            this.paramToDate.Visible = false;
            // 
            // paramOrderDate
            // 
            this.paramOrderDate.Description = "ParamOrderDate";
            this.paramOrderDate.Name = "paramOrderDate";
            this.paramOrderDate.Type = typeof(bool);
            this.paramOrderDate.ValueInfo = "True";
            this.paramOrderDate.Visible = false;
            // 
            // CustomerSalesSummaryReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupFooter1});
            this.DataSource = this.bindingSource1;
            this.DesignerOptions.ShowExportWarnings = false;
            this.FilterString = "[OrderDate] >= ?paramFromDate And [OrderDate] <= ?paramToDate";
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 119, 93);
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.paramFromDate,
            this.paramToDate,
            this.paramOrderDate});
            this.Version = "14.1";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CustomerSalesSummary_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private void xrLabel4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            CustomerSaleDetailOrderItemInfo currentOrderInfo = (CustomerSaleDetailOrderItemInfo)GetCurrentRow();
            if(currentOrderInfo != null) {
                (sender as XRLabel).Text = EnumDisplayTextHelper.GetDisplayText(currentOrderInfo.ProductCategory);
            }
        }

        private void CustomerSalesSummary_DataSourceDemanded(object sender, EventArgs e) {
            if(Equals(true, paramOrderDate.Value)) {
                xrTableCell6.Text = "Grouped by Category | Sorted by Order Date";
                this.detailBand1.SortFields[0].FieldName = "OrderDate";
            } else {
                xrTableCell6.Text = "Grouped by Category | Sorted by Invoice #";
                this.detailBand1.SortFields[0].FieldName = "InvoiceNumber";
            }

            xrTableCell2.Text = ((DateTime)paramFromDate.Value).ToString("MMMM d, yyyy") + " to " + ((DateTime)paramToDate.Value).ToString("MMMM d, yyyy");
        }
        class StoreInfo {
            public StoreInfo(string city) {
                this.City = city;
            }
            public string City { get; private set; }
            public decimal TotalSales { get; set; }
        }
        Dictionary<long, StoreInfo> storeSales = new Dictionary<long, StoreInfo>();
        private void xrTableCell23_SummaryRowChanged(object sender, EventArgs e) {
            CustomerSaleDetailOrderItemInfo currentInfo = (CustomerSaleDetailOrderItemInfo)GetCurrentRow();
            if(storeSales.ContainsKey(currentInfo.StoreId)) {
                storeSales[currentInfo.StoreId].TotalSales += currentInfo.Total;
            } else {
                storeSales.Add(currentInfo.StoreId, new StoreInfo(currentInfo.StoreCity) { TotalSales = currentInfo.Total });
            }

        }

        private void xrTableCell23_SummaryGetResult(object sender, SummaryGetResultEventArgs e) {
            e.Result = storeSales.Count == 0 ? " - " : storeSales.Values.Aggregate((x, y) => x.TotalSales > y.TotalSales ? x : y).City;
            e.Handled = true;
        }

        private void xrTableCell23_SummaryReset(object sender, EventArgs e) {
            storeSales.Clear();
        }
    }
}
