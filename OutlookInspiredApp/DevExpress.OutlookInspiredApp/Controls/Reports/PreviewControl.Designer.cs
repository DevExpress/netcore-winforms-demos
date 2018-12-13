namespace DevExpress.DevAV {
    partial class ReportPreviewControl {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPreviewControl));
            this.documentViewerCore = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.documentViewerBarManager1 = new DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(this.components);
            this.previewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
            this.printPreviewBarItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.printPreviewBarItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.progressBarEditItem1 = new DevExpress.XtraPrinting.Preview.ProgressBarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.printPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.zoomTrackBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.printPreviewBarItemWholePage = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItemMultiplePages = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItemScale = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.printPreviewRepositoryItemComboBox1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewRepositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentViewer
            // 
            this.documentViewerCore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewerCore.IsMetric = false;
            this.documentViewerCore.Location = new System.Drawing.Point(0, 0);
            this.documentViewerCore.Name = "documentViewer";
            this.documentViewerCore.Size = new System.Drawing.Size(1045, 553);
            this.documentViewerCore.TabIndex = 0;
            // 
            // documentViewerBarManager1
            // 
            this.documentViewerBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.previewBar1});
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlTop);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlBottom);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlLeft);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlRight);
            this.documentViewerBarManager1.DocumentViewer = this.documentViewerCore;
            this.documentViewerBarManager1.Form = this;
            //this.documentViewerBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("documentViewerBarManager1.ImageStream")));
            this.documentViewerBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.printPreviewStaticItem1,
            this.progressBarEditItem1,
            this.printPreviewBarItem1,
            this.printPreviewStaticItem2,
            this.zoomTrackBarEditItem1,
            this.printPreviewBarItemScale,
            this.printPreviewBarItem18,
            this.printPreviewBarItem19,
            this.printPreviewBarItemMultiplePages,
            this.printPreviewBarItemWholePage});
            this.documentViewerBarManager1.MaxItemId = 57;
            this.documentViewerBarManager1.PreviewBar = this.previewBar1;
            this.documentViewerBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemZoomTrackBar1,
            this.printPreviewRepositoryItemComboBox1});
            this.documentViewerBarManager1.TransparentEditors = true;
            // 
            // previewBar1
            // 
            this.previewBar1.BarName = "Toolbar";
            this.previewBar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.previewBar1.DockCol = 0;
            this.previewBar1.DockRow = 0;
            this.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.previewBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem18),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem19),
            new DevExpress.XtraBars.LinkPersistInfo(this.progressBarEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewStaticItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.zoomTrackBarEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItemWholePage, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItemMultiplePages),
            new DevExpress.XtraBars.LinkPersistInfo(this.printPreviewBarItemScale)});
            this.previewBar1.OptionsBar.AllowQuickCustomization = false;
            this.previewBar1.OptionsBar.DrawBorder = false;
            this.previewBar1.OptionsBar.DrawDragBorder = false;
            this.previewBar1.OptionsBar.UseWholeRow = true;
            this.previewBar1.Text = "Toolbar";
            // 
            // printPreviewBarItem18
            // 
            this.printPreviewBarItem18.Caption = "Previous Page";
            this.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
            this.printPreviewBarItem18.Enabled = false;
            this.printPreviewBarItem18.Glyph = global::DevExpress.DevAV.Properties.Resources.icon_page_prev_16;
            this.printPreviewBarItem18.Hint = "Previous Page";
            this.printPreviewBarItem18.Id = 24;
            this.printPreviewBarItem18.Name = "printPreviewBarItem18";
            // 
            // printPreviewStaticItem1
            // 
            this.printPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.printPreviewStaticItem1.Caption = "Nothing";
            this.printPreviewStaticItem1.Id = 0;
            this.printPreviewStaticItem1.LeftIndent = 1;
            this.printPreviewStaticItem1.Name = "printPreviewStaticItem1";
            this.printPreviewStaticItem1.RightIndent = 1;
            this.printPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.printPreviewStaticItem1.Type = "PageOfPages";
            // 
            // printPreviewBarItem19
            // 
            this.printPreviewBarItem19.Caption = "Next Page";
            this.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
            this.printPreviewBarItem19.Enabled = false;
            this.printPreviewBarItem19.Glyph = global::DevExpress.DevAV.Properties.Resources.icon_page_next_16;
            this.printPreviewBarItem19.Hint = "Next Page";
            this.printPreviewBarItem19.Id = 25;
            this.printPreviewBarItem19.Name = "printPreviewBarItem19";
            // 
            // progressBarEditItem1
            // 
            this.progressBarEditItem1.Edit = this.repositoryItemProgressBar1;
            this.progressBarEditItem1.EditHeight = 12;
            this.progressBarEditItem1.Id = 2;
            this.progressBarEditItem1.Name = "progressBarEditItem1";
            this.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.progressBarEditItem1.Width = 150;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // printPreviewBarItem1
            // 
            this.printPreviewBarItem1.Caption = "Stop";
            this.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
            this.printPreviewBarItem1.Enabled = false;
            this.printPreviewBarItem1.Hint = "Stop";
            this.printPreviewBarItem1.Id = 3;
            this.printPreviewBarItem1.Name = "printPreviewBarItem1";
            this.printPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // printPreviewStaticItem2
            // 
            this.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.printPreviewStaticItem2.Caption = "100%";
            this.printPreviewStaticItem2.Id = 5;
            this.printPreviewStaticItem2.Name = "printPreviewStaticItem2";
            this.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far;
            this.printPreviewStaticItem2.Type = "ZoomFactor";
            // 
            // zoomTrackBarEditItem1
            // 
            this.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.zoomTrackBarEditItem1.Edit = this.repositoryItemZoomTrackBar1;
            this.zoomTrackBarEditItem1.EditValue = 90;
            this.zoomTrackBarEditItem1.Enabled = false;
            this.zoomTrackBarEditItem1.Id = 6;
            this.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1";
            this.zoomTrackBarEditItem1.Range = new int[] {
        10,
        500};
            this.zoomTrackBarEditItem1.Width = 140;
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 180;
            this.repositoryItemZoomTrackBar1.Middle = 5;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // printPreviewBarItemWholePage
            // 
            this.printPreviewBarItemWholePage.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewBarItemWholePage.Caption = "Fit To Page";
            this.printPreviewBarItemWholePage.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToWholePage;
            this.printPreviewBarItemWholePage.Enabled = false;
            this.printPreviewBarItemWholePage.Glyph = global::DevExpress.DevAV.Properties.Resources.icon_fittopage_16;
            this.printPreviewBarItemWholePage.Hint = "Fit to Page";
            this.printPreviewBarItemWholePage.Id = 27;
            this.printPreviewBarItemWholePage.Name = "printPreviewBarItemWholePage";
            // 
            // printPreviewBarItemMultiplePages
            // 
            this.printPreviewBarItemMultiplePages.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewBarItemMultiplePages.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItemMultiplePages.Caption = "Multiple Pages";
            this.printPreviewBarItemMultiplePages.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
            this.printPreviewBarItemMultiplePages.Enabled = false;
            this.printPreviewBarItemMultiplePages.Glyph = global::DevExpress.DevAV.Properties.Resources.icon_pages_16;
            this.printPreviewBarItemMultiplePages.Hint = "Multiple Pages";
            this.printPreviewBarItemMultiplePages.Id = 27;
            this.printPreviewBarItemMultiplePages.Name = "printPreviewBarItemMultiplePages";
            // 
            // printPreviewBarItemScale
            // 
            this.printPreviewBarItemScale.ActAsDropDown = true;
            this.printPreviewBarItemScale.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewBarItemScale.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItemScale.Caption = "Scale";
            this.printPreviewBarItemScale.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
            this.printPreviewBarItemScale.Enabled = false;
            this.printPreviewBarItemScale.Hint = "Scale";
            this.printPreviewBarItemScale.Id = 17;
            this.printPreviewBarItemScale.ImageIndex = 25;
            this.printPreviewBarItemScale.Name = "printPreviewBarItemScale";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1045, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 553);
            this.barDockControlBottom.Size = new System.Drawing.Size(1045, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1045, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // printPreviewRepositoryItemComboBox1
            // 
            this.printPreviewRepositoryItemComboBox1.AutoComplete = false;
            this.printPreviewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.printPreviewRepositoryItemComboBox1.DropDownRows = 11;
            this.printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1";
            // 
            // ReportPreviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.documentViewerCore);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ReportPreviewControl";
            this.Size = new System.Drawing.Size(1045, 584);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printPreviewRepositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraPrinting.Preview.DocumentViewer documentViewerCore;
        private XtraPrinting.Preview.DocumentViewerBarManager documentViewerBarManager1;
        private XtraPrinting.Preview.PreviewBar previewBar1;
        private XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItem18;
        private XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem1;
        private XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItem19;
        private XtraPrinting.Preview.ProgressBarEditItem progressBarEditItem1;
        private XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItem1;
        private XtraPrinting.Preview.PrintPreviewStaticItem printPreviewStaticItem2;
        private XtraPrinting.Preview.ZoomTrackBarEditItem zoomTrackBarEditItem1;
        private XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItemWholePage;
        private XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItemScale;
        private XtraPrinting.Preview.PrintPreviewBarItem printPreviewBarItemMultiplePages;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox printPreviewRepositoryItemComboBox1;
    }
}