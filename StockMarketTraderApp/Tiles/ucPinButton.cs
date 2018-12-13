using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DevExpress.StockMarketTrader.Tiles {
    public partial class ucPinButton : UserControl {
        Font underline;
        Font noUnderline;
        public ucPinButton() {
            InitializeComponent();
            labelControl1.Appearance.ForeColor = Color.White;
            pictureBox1.Image = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.Live-Tile.png"));
            labelControl1.MouseEnter += new EventHandler(labelControl1_MouseEnter);
            labelControl1.MouseLeave += new EventHandler(labelControl1_MouseLeave);
            pictureBox1.MouseEnter += new EventHandler(labelControl1_MouseEnter);
            pictureBox1.MouseLeave += new EventHandler(labelControl1_MouseLeave);
            labelControl1.Click += new EventHandler(labelControl1_Click);
            pictureBox1.Click += new EventHandler(labelControl1_Click);
            underline = new Font(labelControl1.Font, FontStyle.Underline);
            noUnderline = new Font(labelControl1.Font, FontStyle.Regular);
        }
        public event EventHandler OnButtonClick;
        void labelControl1_Click(object sender, EventArgs e) {
            if(OnButtonClick != null) OnButtonClick(this, e);            
        }

        void labelControl1_MouseLeave(object sender, EventArgs e) {
            labelControl1.Appearance.ForeColor = Color.White;
            labelControl1.Appearance.Font = noUnderline;
        }

        void labelControl1_MouseEnter(object sender, EventArgs e) {
            labelControl1.Appearance.ForeColor = Color.DarkOrange;
            labelControl1.Appearance.Font = underline;
        }
    }
}
