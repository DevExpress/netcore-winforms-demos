using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using System.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.StockMarketTrader {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            WindowsFormsSettings.ForceDirectXPaint();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            WindowsFormsSettings.SetDPIAware();
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8.5F, FontStyle.Regular);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetStyle(LookAndFeelStyle.Skin, false, false, "The Bezier");
            Application.Run(new StockMarketView());
        }
    }
}
