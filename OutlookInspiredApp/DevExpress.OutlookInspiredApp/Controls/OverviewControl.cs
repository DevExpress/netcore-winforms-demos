using DevExpress.DevAV.ViewModels;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Modules {
    public partial class OverviewControl : XtraUserControl {
        public OverviewControl() {
            InitializeComponent();
            descriptionLabel.AutoSizeInLayoutControl = false;
            descriptionLabel.Text = "<image=#UISuperHero><br>"
                + string.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", ColorHelper.TextColor.ToArgb())
                + string.Format("<color=#{0:x6}><size=-18>And deliver compelling user-experiences on the WinForms platform<br>", ColorHelper.DisabledTextColor.ToArgb())
                + "with award-winning DevExpress Controls and Libraries.";
            descriptionLabel.HyperlinkClick += descriptionLabel_HyperlinkClick;
        }
        void descriptionLabel_HyperlinkClick(object sender, Utils.HyperlinkClickEventArgs e) {
            viewModel.SelectedModuleType = ModuleType.Employees;
            var form = FindForm();
            if(form != null)
                form.Close();
        }
        MainViewModel viewModel;
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            if(viewModel == null && AppHelper.MainForm != null) {
                viewModel = (AppHelper.MainForm as ISupportViewModel).ViewModel as MainViewModel;
                if(viewModel != null)
                    BindCommands();
            }
        }
        void BindCommands() {
            ((WindowsUIButton)buttonsPanel.Buttons[0]).BindCommand(() => viewModel.GetStarted(), viewModel);
            ((WindowsUIButton)buttonsPanel.Buttons[1]).BindCommand(() => viewModel.GetSupport(), viewModel);
            ((WindowsUIButton)buttonsPanel.Buttons[2]).BindCommand(() => viewModel.BuyNow(), viewModel);
        }
        internal void SetDescription(string description) {
            descriptionLabel.Appearance.Image = null;
            descriptionLabel.Text = "<image=#UISuperHero><br>"
                + string.Format("<color=#{0:x6}><size=+24>Become a UI Superhero<br>", ColorHelper.TextColor.ToArgb())
                + string.Format("<color=#{0:x6}><size=-18>{1}", ColorHelper.DisabledTextColor.ToArgb(), description);
        }
    }
}