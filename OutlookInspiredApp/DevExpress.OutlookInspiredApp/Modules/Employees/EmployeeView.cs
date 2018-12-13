namespace DevExpress.DevAV.Modules {
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraBars.Docking2010;
    using DevExpress.XtraGrid.Views.Tile;
    using DevExpress.XtraLayout.Utils;
    using DevExpress.Utils.Svg;

    public partial class EmployeeView : BaseModuleControl {
        SvgImage svgYes;
        SvgImage svgNo;
        IDictionary<EmployeeTaskPriority, SvgImage> priorityImages;
        public EmployeeView()
            : base(typeof(SynchronizedEmployeeViewModel)) {
            InitializeComponent();
            gvTasks.SetViewFontSize(2, 1);
            gvEvaluations.SetViewFontSize(2, 1);
            BindCommands();
            ViewModel.EntityChanged += ViewModel_EntityChanged;
            officeTabFilter.SelectedItemChanged += OfficeTabFilter_SelectedItemChanged;
            tvEvaluations.ItemCustomize += tvEvaluations_ItemCustomize;
            tvTasks.ItemCustomize += tvTasks_ItemCustomize;
            gcTasks.SizeChanged += (s, e) =>
            {
                if(gcTasks.MainView == tvTasks)
                    tvTasks.RefreshData();
            };

            var asm = typeof(MainForm).Assembly;
            svgYes = SvgImage.FromResources("DevExpress.DevAV.Resources.EvaluationYes.svg", asm);
            svgNo = SvgImage.FromResources("DevExpress.DevAV.Resources.EvaluationNo.svg", asm);
            priorityImages = SVGHelper.CreateTaskPriorityImages(LookAndFeel, "DevExpress.DevAV.Resources.Tasks.");
            buttonPanel.UseButtonBackgroundImages = false;
        }

        void OfficeTabFilter_SelectedItemChanged(object sender, XtraBars.Navigation.NavigationBarItemEventArgs e) {
            bool showTasks = e.Item == navigationItemTasks;
            lciTasks.Visibility = showTasks ? LayoutVisibility.Always : LayoutVisibility.Never;
            lciEvaluations.Visibility = !showTasks ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
        protected override void OnMVVMContextReleasing() {
            ViewModel.EntityChanged -= ViewModel_EntityChanged;
        }
        protected override void OnDisposing() {
            tvTasks.ItemCustomize -= tvTasks_ItemCustomize;
            tvEvaluations.ItemCustomize -= tvEvaluations_ItemCustomize;
            base.OnDisposing();
        }
        public EmployeeViewModel ViewModel {
            get { return GetViewModel<EmployeeViewModel>(); }
        }
        void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            QueueUIUpdate();
        }
        protected override void OnDelayedUIUpdate() {
            UpdateUI(ViewModel.Entity);
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            UpdateUI(ViewModel.Entity);
        }
        SizeF scaleFactor;
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);
            this.scaleFactor = factor;
        }
        void BindCommands() {
            var fluent = mvvmContext.OfType<EmployeeViewModel>();
            fluent.BindCommand(ContactButton(0), x => x.Contacts.Message());
            fluent.BindCommand(ContactButton(1), x => x.Contacts.Phone());
            fluent.BindCommand(ContactButton(2), x => x.Contacts.VideoCall());
            fluent.BindCommand(ContactButton(3), x => x.Contacts.MailTo());
        }
        WindowsUIButton ContactButton(int index) {
            return (WindowsUIButton)buttonPanel.Buttons[index];
        }
        void UpdateUI(Employee employee) {
            if(employee != null) {
                if(!object.Equals(bindingSource.DataSource, employee))
                    bindingSource.DataSource = employee;
                else {
                    employee.ResetBindable();
                    bindingSource.ResetBindings(false);
                }
                tvTasks.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
                tvEvaluations.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle;
                gcTasks.DataSource = employee.AssignedTasks;
                gcEvaluations.DataSource = employee.Evaluations;
            }
            else {
                gcTasks.DataSource = null;
                gcEvaluations.DataSource = null;
            }
            modueLayout.Visible = (employee != null);
        }
        public bool IsHorizontalLayout {
            get { return !colDescription.Visible; }
            set {
                gvEvaluations.OptionsView.ShowPreview = value;
                gvTasks.OptionsView.ShowPreview = value;
                colDescription.Visible = !value;
            }
        }
        void tvEvaluations_ItemCustomize(object sender, XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e) {
            string details = tvEvaluations.GetRowCellValue(e.RowHandle, "Details") as string;
            var raiseImg = e.Item.GetElementByName("RaiseImage");
            var bonusImg = e.Item.GetElementByName("BonusImage");
            bool hasRaise = false;
            bool hasBonus = false;
            if(!string.IsNullOrEmpty(details)) {
                details = details.ToLower().Replace(" ", string.Empty);
                hasRaise = details.Contains("raise:yes");
                hasBonus = details.Contains("bonus:yes");
            }
            raiseImg.ImageOptions.SvgImage = hasRaise ? svgYes : svgNo;
            bonusImg.ImageOptions.SvgImage = hasBonus ? svgYes : svgNo;
        }
        void tvTasks_ItemCustomize(object sender, XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e) {
            var view = sender as TileView;
            var progressBack = e.Item.GetElementByName("ProgressBack");
            var progressFront = e.Item.GetElementByName("ProgressFront");
            var priorityElement = e.Item.GetElementByName("PriorityImage");
            var rowPriority = (EmployeeTaskPriority)view.GetRowCellValue(e.RowHandle, view.Columns["Priority"]);
            int completion = (int)view.GetRowCellValue(e.RowHandle, view.Columns["Completion"]);

            priorityElement.ImageOptions.SvgImage = priorityImages[rowPriority];
            progressBack.Width = (int)(view.GetViewInfo().GetItemSize().Width / (float)scaleFactor.Width) - view.OptionsTiles.ItemPadding.Horizontal;
            progressFront.Width = (int)(progressBack.Width * (completion / 100.0f));
        }
    }
}