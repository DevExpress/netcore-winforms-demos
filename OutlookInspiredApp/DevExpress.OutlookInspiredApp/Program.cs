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
        const string AppName = "DevExpressWinOutlookInspiredApp";
        [STAThread]
        static void Main() {
            TaskbarAssistant.Default.Initialize();
            AppDomain.CurrentDomain.AssemblyResolve += OnCurrentDomainAssemblyResolve;
            DevAVDataDirectoryHelper.LocalPrefix = "WinOutlookInspiredApp";
            //
            bool exit;
            using(DevAVDataDirectoryHelper.SingleInstanceApplicationGuard(AppName, out exit)) {
                if(exit)
                    return;
                // Global Appearance Settings
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
                DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(LookAndFeel.SkinStyle.Office2019Colorful);
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultRibbonStyle = XtraEditors.DefaultRibbonControlStyle.Office2019;
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
        //
        static Assembly OnCurrentDomainAssemblyResolve(object sender, ResolveEventArgs args) {
            string partialName = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower();
            if(partialName == "entityframework" || partialName == "system.data.sqlite" || partialName == "system.data.sqlite.ef6") {
                string path = Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), "Dll", partialName + ".dll");
                return Assembly.LoadFrom(path);
            }
            return null;
        }
    }
}