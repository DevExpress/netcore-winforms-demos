namespace DevExpress.DevAV {
    using System;
    using System.Drawing;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;
    using DevExpress.Internal;
    using DevExpress.Utils.Taskbar;

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            TaskbarAssistant.Default.Initialize();
                        DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
                // Global Appearance Settings
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultRibbonStyle = XtraEditors.DefaultRibbonControlStyle.Office2019;
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(LookAndFeel.SkinStyle.Office2019Colorful);
                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
                DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", AppHelper.GetDefaultSize());
                // Global Behavior Settings
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
                DevExpress.XtraEditors.WindowsFormsSettings.CustomizationFormSnapMode = Utils.Controls.SnapMode.OwnerControl;
                DevExpress.XtraEditors.WindowsFormsSettings.ColumnFilterPopupMode = XtraEditors.ColumnFilterPopupMode.Excel;
                DevExpress.XtraEditors.WindowsFormsSettings.AllowSkinEditorAttach = Utils.DefaultBoolean.True;
                //
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using(new StartUpProcess()) {
                    using(StartUpProcess.Status.Subscribe(new DemoStartUp())) {
                        Application.Run(new MainForm());
                    }
                }
        }
    }
}