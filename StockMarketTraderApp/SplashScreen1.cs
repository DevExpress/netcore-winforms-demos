using System;
using DevExpress.Utils.Design;
using DevExpress.Utils.Svg;
using DevExpress.XtraSplashScreen;

namespace DevExpress.StockMarketTrader {
    public partial class SplashScreen1 : SplashScreen {
        public SplashScreen1() {
            InitializeComponent();
            labelControl1.Text += DateTime.Now.Year.ToString();
            ISvgPaletteProvider palette = SvgPaletteHelper.GetSvgPalette(this.TargetLookAndFeel.ActiveLookAndFeel, DevExpress.Utils.Drawing.ObjectState.Normal);
            SvgImage svg = SvgResources.GetSvgImage("DX Logo");
            pictureBox1.Image = new SvgBitmap(svg).Render(palette);
            svg = SvgResources.GetSvgImage("App Logo");
            pictureBox2.Image = new SvgBitmap(svg).Render(palette);
        }
    }
}