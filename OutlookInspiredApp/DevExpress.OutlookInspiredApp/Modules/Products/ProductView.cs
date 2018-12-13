namespace DevExpress.DevAV.Modules {
    using System;
    using DevExpress.DevAV;
    using DevExpress.DevAV.Services;
    using DevExpress.DevAV.ViewModels;

    public partial class ProductView : BaseModuleControl {
        public ProductView()
            : base(typeof(SynchronizedProductViewModel)) {
            InitializeComponent();
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            pdfViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            pdfViewer.ZoomChanged += pdfViewer_ZoomChanged;
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        protected override void OnMVVMContextReleasing() {
            pdfViewer.ZoomChanged -= pdfViewer_ZoomChanged;
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override void OnDisposing() {
            LookAndFeel.StyleChanged -= LookAndFeel_StyleChanged;
            base.OnDisposing();
        }
        protected override void OnInitServices() {
            mvvmContext.RegisterService(new Services.LoadingService(this));
        }
        void pdfViewer_ZoomChanged(object sender, XtraPdfViewer.PdfZoomChangedEventArgs e) {
            RaiseZoomLevelChanged();
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            pdfViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        public ProductViewModel ViewModel {
            get { return GetViewModel<ProductViewModel>(); }
        }
        public ProductCollectionViewModel CollectionViewModel {
            get { return GetParentViewModel<ProductCollectionViewModel>(); }
        }
        void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            QueueUIUpdate();
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UpdateUI(ViewModel.Entity);
        }
        protected override void OnDelayedUIUpdate() {
            UpdateUI(ViewModel.Entity);
        }
        void UpdateUI(Product product) {
            UpdateDocument(product);
            pdfViewer.Visible = (product != null);
        }
        void UpdateDocument(Product product) {
            if(product == null) return;
            if(product.Brochure == null)
                pdfViewer.CloseDocument();
            else
                LoadDocument(product);
        }
        void LoadDocument(Product product) {
            var loadingService = GetService<Services.IWaitingService>();
            using(loadingService.Enter(product.Name)) {
                pdfViewer.LoadDocument(product.Brochure);
                pdfViewer.ZoomMode = XtraPdfViewer.PdfZoomMode.PageLevel;
                RaiseZoomLevelChanged();
            }
        }
        public int ZoomLevel {
            get { return (int)System.Math.Ceiling(pdfViewer.ZoomFactor); }
            set {
                if(value != ZoomLevel) pdfViewer.ZoomFactor = (float)value;
            }
        }
        public event EventHandler ZoomLevelChanged;
        void RaiseZoomLevelChanged() {
            EventHandler handler = ZoomLevelChanged;
            if(handler != null) handler(this, EventArgs.Empty);
        }
    }
}