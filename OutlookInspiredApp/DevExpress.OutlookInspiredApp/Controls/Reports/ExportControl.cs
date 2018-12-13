using System;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPrinting;

namespace DevExpress.DevAV {
    public partial class ReportExportControl : XtraUserControl {
        DXPopupMenu menuExport;
        public ReportExportControl() {
            InitializeComponent();
            SelectedExport = ExportTarget.Pdf;
            menuExport = new DXPopupMenu();
            AddExportTarget(ExportTarget.Pdf);
            AddExportTarget(ExportTarget.Html);
            AddExportTarget(ExportTarget.Mht);
            AddExportTarget(ExportTarget.Rtf);
            AddExportTarget(ExportTarget.Xls);
            AddExportTarget(ExportTarget.Xlsx);
            AddExportTarget(ExportTarget.Csv);
            AddExportTarget(ExportTarget.Text);
            AddExportTarget(ExportTarget.Image);
            btnExport.DropDownControl = menuExport;
            menuExport.BeforePopup += menuExport_BeforePopup;
            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            btnExport.MenuManager = MenuManagerHelper.FindMenuManager(AppHelper.MainForm);
        }
        void menuExport_BeforePopup(object sender, EventArgs e) {
            foreach(DXMenuCheckItem item in menuExport.Items)
                item.Checked = object.Equals(item.Tag, SelectedExport);
        }
        void AddExportTarget(ExportTarget target) {
            var exportItem = new DXMenuCheckItem()
            {
                Caption = target.ToString(),
                Tag = target
            };
            menuExport.Items.Add(exportItem);
            exportItem.Click += exportItem_Click;
        }
        void exportItem_Click(object sender, EventArgs e) {
            SelectedExport = (ExportTarget)((DXMenuItem)sender).Tag;
        }
        public void SetSettings(Control control) {
            for(int i = settingsPanel.Controls.Count - 1; i >= 0; i--)
                settingsPanel.Controls[i].Dispose();
            if(control != null) {
                control.Dock = DockStyle.Fill;
                control.Parent = settingsPanel;
            }
        }
        public bool ExportEnabled {
            set { btnExport.Enabled = value; }
        }
        public ExportTarget SelectedExport {
            get;
            set;
        }
        public event EventHandler ExportClick;
        void RaiseExportClick() {
            if(ExportClick != null)
                ExportClick(this, EventArgs.Empty);
        }
        void btnExport_Click(object sender, EventArgs e) {
            RaiseExportClick();
        }
    }
}