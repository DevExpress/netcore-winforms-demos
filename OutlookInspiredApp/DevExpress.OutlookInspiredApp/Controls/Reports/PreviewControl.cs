using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;

namespace DevExpress.DevAV {
    public partial class ReportPreviewControl : XtraUserControl {
        public ReportPreviewControl() {
            InitializeComponent();
        }
        public DocumentViewer DocumentViewer {
            get { return documentViewerCore; }
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            DocumentViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            DocumentViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public object DocumentSource {
            get { return documentViewerCore.DocumentSource; }
            set {
                if(!ReferenceEquals(documentViewerCore.DocumentSource, value)) {
                    documentViewerCore.DocumentSource = value;
                }
            }
        }
    }
}