using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Preview;
using DevExpress.XtraLayout.Utils;
using System.Windows.Forms;
using DevExpress.Printing;

namespace DevExpress.DevAV {
    public partial class ReportPrintControl : XtraUserControl {
        PrinterImagesContainer imagesContainer;
        PrinterItemContainer printerItemContainer;
        public ReportPrintControl() {
            InitializeComponent();
            imagesContainer = new PrinterImagesContainer();
            CreatePrinterItemContainer();

            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        void CreatePrinterItemContainer() {
            try {
                printerItemContainer = new PrinterItemContainer();
            } catch { }
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            moduleLayout.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            cbPrinters.Properties.LargeImages = imagesContainer.LargeImages;
            cbPrinters.Properties.SmallImages = imagesContainer.SmallImages;
            if(printerItemContainer != null) {
                foreach(PrinterItem item in printerItemContainer.Items)
                    cbPrinters.Properties.Items.Add(new ImageComboBoxItem(item.DisplayName, item, imagesContainer.GetImageIndex(item)));
            }
        }
        public bool PrintEnabled {
            set { btnOptions.Enabled = btnPrint.Enabled = value; }
        }
        public bool SettingsVisible {
            set {
                ItemForSettings.Visibility = value ?
                    LayoutVisibility.Always : LayoutVisibility.Never;
            }
        }
        public void SetSettings(Control control) {
            for(int i = settingsPanel.Controls.Count - 1; i >= 0; i--) 
                settingsPanel.Controls[i].Dispose();
            if(control != null) {
                control.Dock = DockStyle.Fill;
                control.Parent = settingsPanel;
            }
        }
        public string SelectedPrinterName {
            get {
                PrinterItem item = cbPrinters.EditValue as PrinterItem;
                if(item != null)
                    return item.FullName;
                return string.Empty;
            }
            set { cbPrinters.EditValue = FindPrinterItem(value); }
        }
        PrinterItem FindPrinterItem(string value) {
            if(printerItemContainer != null) {
                for(int i = 0; i < printerItemContainer.Items.Count; i++) {
                    if(printerItemContainer.Items[i].FullName != value) continue;
                    return printerItemContainer.Items[i];
                }
            }
            return null;
        }
        public event EventHandler PrintClick;
        public event EventHandler PrintOptionsClick;
        void RaisePrintOptionsClick() {
            if(PrintOptionsClick != null)
                PrintOptionsClick(this, EventArgs.Empty);
        }
        void RaisePrintClick() {
            if(PrintClick != null)
                PrintClick(this, EventArgs.Empty);
        }
        void btnPrint_Click(object sender, EventArgs e) {
            RaisePrintClick();
        }
        void btnOptions_Click(object sender, EventArgs e) {
            RaisePrintOptionsClick();
        }
    }
    [ToolboxItem(false), Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(System.ComponentModel.Design.IDesigner))]
    public class SettingPanel : XtraUserControl { }
}