using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.DevAV {
    public partial class InvoiceSettingsControl : UserControl {
        readonly List<Tuple<string, bool, Action<bool>>> settingList;
        InvoiceSettingsControl() {
            InitializeComponent();
        }
        public InvoiceSettingsControl(List<Tuple<string, bool, Action<bool>>> settingList):this() {
            this.settingList = settingList;
            checkedListBoxControl1.Items.Clear();
            foreach(Tuple<string, bool, Action<bool>> setting in settingList) {
                checkedListBoxControl1.Items.Add(setting.Item1, setting.Item2);
            }
        }
        void checkedListBoxControl1_ItemCheck(object sender, XtraEditors.Controls.ItemCheckEventArgs e) {
            settingList[e.Index].Item3.Invoke(e.State == CheckState.Checked);
        }
    }
}
