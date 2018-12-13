using System;
using System.Windows.Forms;

namespace DevExpress.DevAV {
    public partial class ImagesControl : UserControl {
        Action<bool> callback;
        bool defaultValue;
        public ImagesControl() {
            InitializeComponent();
        }
        public ImagesControl(Action<bool> callback, bool defaultValue)
            : this() {
            this.callback = callback;
            this.defaultValue = defaultValue;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(defaultValue) btnDisplayImages.Checked = true;
            else btnHideImages.Checked = true;
        }
        void btnDisplayImages_CheckedChanged(object sender, EventArgs e) {
            if(callback != null) callback(true);
        }
        void btnHideImages_CheckedChanged(object sender, EventArgs e) {
            if(callback != null) callback(false);
        }
    }
}