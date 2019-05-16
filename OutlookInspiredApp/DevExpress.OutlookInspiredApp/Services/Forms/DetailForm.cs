namespace DevExpress.DevAV {
    using DevExpress.DevAV.Modules;
    using DevExpress.DevAV.ViewModels;

    public partial class DetailForm : DevExpress.XtraBars.Ribbon.RibbonForm, IRibbonModule {
        public DetailForm() {
            InitializeComponent();
            Icon = AppHelper.AppIcon;
            if(mainViewModel == null) {
                mainViewModel = ((ISupportViewModel)AppHelper.MainForm).ViewModel as MainViewModel;
                if(mainViewModel != null)
                    BindCommands(mainViewModel);
            }
        }
        MainViewModel mainViewModel;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            Bounds = DevExpress.Utils.PlacementHelper.Arrange(Size, Owner.Bounds, System.Drawing.ContentAlignment.MiddleCenter);
        }
        protected override void OnShown(System.EventArgs e) {
            base.OnShown(e);
            if(System.Windows.Forms.Form.ActiveForm != this)
                Activate();
        }
        void BindCommands(MainViewModel viewModel) {
            biGetStarted.BindCommand(() => viewModel.GetStarted(), viewModel);
            biGetSupport.BindCommand(() => viewModel.GetSupport(), viewModel);
            biBuyNow.BindCommand(() => viewModel.BuyNow(), viewModel);
            biAbout.BindCommand(() => viewModel.About(), viewModel);
        }
        protected override void OnControlAdded(System.Windows.Forms.ControlEventArgs e) {
            base.OnControlAdded(e);
            EnsureRibbonModule(e.Control);
        }
        void EnsureRibbonModule(object view) {
            IRibbonModule ribbonModule = view as IRibbonModule;
            if(ribbonModule != null) {
                Ribbon.Pages[0].Text = ribbonModule.Ribbon.Pages[0].Text;
                Ribbon.MergeRibbon(ribbonModule.Ribbon);
                Ribbon.StatusBar.MergeStatusBar(ribbonModule.Ribbon.StatusBar);
                Text = string.Format("{1} - {0}", ribbonModule.Ribbon.ApplicationDocumentCaption, "DevAV");
            }
        }
        #region IRibbonModule
        DevExpress.XtraBars.Ribbon.RibbonControl IRibbonModule.Ribbon {
            get { return ribbonControl; }
        }
        #endregion
    }
}