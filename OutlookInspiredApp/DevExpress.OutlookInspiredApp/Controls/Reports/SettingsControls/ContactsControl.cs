using System;
using System.Windows.Forms;

namespace DevExpress.DevAV {
    public partial class ContactsControl : UserControl {
        Action<bool> callback;
        bool defaultValue;
        public ContactsControl() {
            InitializeComponent();
        }
        public ContactsControl(Action<bool> callback, bool defaultValue)
            : this() {
            this.callback = callback;
            this.defaultValue = defaultValue;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(defaultValue) btnIncludeContacts.Checked = true;
            else btnExcludeContacts.Checked = true;
        }
        void btnIncludeContacts_CheckedChanged(object sender, EventArgs e) {
            if(callback != null) callback(true);
        }
        void btnExcludeContacts_CheckedChanged(object sender, EventArgs e) {
            if(callback != null) callback(false);
        }
    }
}