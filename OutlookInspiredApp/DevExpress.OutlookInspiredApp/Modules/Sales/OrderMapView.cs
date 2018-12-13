namespace DevExpress.DevAV.Modules {
    using System;
    using System.Drawing;
    using System.IO;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Presenters;
    
    using DevExpress.DevAV.ViewModels;
    using DevExpress.Pdf;

    public partial class OrderMapView : BaseModuleControl, IRibbonModule {
        public OrderMapView()
            : base(typeof(OrderMapViewModel)) {
            InitializeComponent();
            //
            Presenter = CreatePresenter();
            //
            BindCommands();
            BindEditors();
            UpdateColors();
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        protected override void OnDisposing() {
            LookAndFeel.StyleChanged -= LookAndFeel_StyleChanged;
            Presenter.Dispose();
            base.OnDisposing();
        }
        public OrderMapViewModel ViewModel {
            get { return GetViewModel<OrderMapViewModel>(); }
        }
        protected OrderRouteMapPresenter Presenter {
            get;
            private set;
        }
        protected virtual OrderRouteMapPresenter CreatePresenter() {
            return new OrderRouteMapPresenter(mapControl, ViewModel, UpdateUI);
        }
        protected virtual void BindCommands() {
            biClose.BindCommand(() => ViewModel.Close(), ViewModel);
            //
            biPrint.ItemClick += (s, e) => Viewer.Print();
            barExportItem.ItemClick += (s, e) => Viewer.SaveDocument("Shipping_" + ViewModel.Entity.InvoiceNumber + ".pdf");
        }
        protected virtual void BindEditors() {
            bindingSource.DataSource = ViewModel;
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            UpdateColors();
        }
        void UpdateColors() {
            ItemForInvoice.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor;
            InvoiceLabel.Appearance.ForeColor = ColorHelper.DisabledTextColor;
        }
        void UpdateUI(Order order) {
            ribbonControl.ApplicationDocumentCaption = order.Customer.Name;
            using(PdfDocumentProcessor processor = new PdfDocumentProcessor()) {
                using(var template = GetShipmentTemplate(order)) {
                    processor.LoadDocument(template);
                    AddWatermark(processor, GetWatermarkText(order));
                    var tmpFile = Path.GetTempFileName();
                    processor.SaveDocument(tmpFile);
                    Viewer.LoadDocument(tmpFile);
                }
            }
        }
        static Stream GetShipmentTemplate(Order order) {
            MemoryStream pdfStream = new MemoryStream();
            //var report = ReportFactory.ShippingDetail(order);
            //report.ExportToPdf(pdfStream);
            return pdfStream;
        }
        static string GetWatermarkText(Order order) {
            switch(order.ShipmentStatus) {
                case ShipmentStatus.Received:
                    return "Shipment Received";
                case ShipmentStatus.Transit:
                    return "Shipment in Transit";
                default:
                    return "Awaiting shipment";
            }
        }
        static void AddWatermark(PdfDocumentProcessor processor, string watermark) {
            var pages = processor.Document.Pages;
            for(int i = 0; i < pages.Count; i++) {
                using(var graphics = processor.CreateGraphics()) {
                    using(Font font = new Font("Segoe UI", 48, FontStyle.Regular)) {
                        RectangleF pageLayout = new RectangleF(
                             -(float)pages[i].CropBox.Width * 0.35f,
                             (float)pages[i].CropBox.Height * 0.1f,
                             (float)pages[i].CropBox.Width * 1.25f,
                             (float)pages[i].CropBox.Height);
                        // Transformation
                        var angle = Math.Asin((double)pageLayout.Width / (double)pageLayout.Height) * 180.0 / Math.PI;
                        graphics.TranslateTransform(-pageLayout.X, -pageLayout.Y);
                        graphics.RotateTransform((float)angle);

                        using(SolidBrush textBrush = new SolidBrush(Color.FromArgb(100, Color.Red)))
                            graphics.DrawString(watermark, font, textBrush, new PointF(50, 50));
                    }
                    graphics.AddToPageForeground(pages[i]);
                }
            }
        }
        #region IRibbonModule
        XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
    }
}