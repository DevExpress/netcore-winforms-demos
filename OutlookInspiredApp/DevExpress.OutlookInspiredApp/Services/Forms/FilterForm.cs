namespace DevExpress.DevAV {
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.Utils;

    public partial class FilterForm : DevExpress.XtraEditors.XtraForm {
        public FilterForm() {
            InitializeComponent();
            Icon = AppHelper.AppIcon;
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            Bounds = PlacementHelper.Arrange(Size, Owner.Bounds, ContentAlignment.MiddleCenter);
        }
        protected override void OnControlAdded(ControlEventArgs e) {
            base.OnControlAdded(e);
            if(e.Control is UserControl) {
                AcceptButton = Find(e.Control, (btn) => btn.Text == "OK");
                CancelButton = Find(e.Control, (btn) => btn.Text == "Cancel");
            }
        }
        IButtonControl Find(Control control, Predicate<Control> predicate) {
            foreach(Control child in control.Controls) {
                if(child is IButtonControl && predicate(child)) 
                    return (IButtonControl)child;
                IButtonControl nested = Find(child, predicate);
                if(nested != null)
                    return nested;
            }
            return null;
        }
    }
}