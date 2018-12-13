using System;
using System.Windows.Forms;

namespace DevExpress.DevAV {
    public partial class YearsControl : UserControl {
        Action<string> callback;
        string defaultValue;
        public YearsControl() {
            InitializeComponent();
            AddYearItems();
        }
        public YearsControl(Action<string> callback, string defaultValue)
            : this() {
            this.defaultValue = defaultValue;
            this.callback = callback;
        }
        void AddYearItems() {
            var yearItems = new DevExpress.XtraEditors.Controls.CheckedListBoxItem[5];
            int startYear = (DateTime.Now.Year - yearItems.Length) + 1;
            for(int i = 0; i < yearItems.Length; i++) {
                string year = (startYear + i).ToString();
                yearItems[i] = new DevExpress.XtraEditors.Controls.CheckedListBoxItem(year, year);
            }
            this.checkedComboBoxEdit1.Properties.Items.AddRange(yearItems);
            this.checkedComboBoxEdit1.EditValueChanged += checkedComboBoxEdit1_EditValueChanged;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            checkedComboBoxEdit1.EditValue = defaultValue;
        }
        void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e) {
            if(callback != null) callback((string)checkedComboBoxEdit1.EditValue);
        }
    }
}