using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.StockMarketTrader.ViewModel;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevExpress.StockMarketTrader.Tiles {
    public partial class TileTop3Companies : UserControl {
        public TileTop3Companies(Size size) {
            InitializeComponent();
            this.Size = size;
            List<LiveTileViewModel> companies = new List<LiveTileViewModel>() { StockMarketView.defaultViewModel.TopThreeCompanies[0], 
                                                                                StockMarketView.defaultViewModel.TopThreeCompanies[1], 
                                                                                StockMarketView.defaultViewModel.TopThreeCompanies[2] };
            List<LabelControl> labels = new List<LabelControl>() { labelControl1, labelControl2, labelControl3 };
            for(int i = 0; i < 3; i++) {
                string company = companies[i].CompanyIndex;
                string arrow = companies[i].Arrow;
                string percent = companies[i].Persent;
                string priceincreace = companies[i].PriceIncrease;
                string result = String.Format("{0}<br><size=-3>{1} {2}<br>{3} {4}", company, arrow, percent, arrow, priceincreace);
                labels[i].Text = result;
            }
            if(size.Height == size.Width) {
                layoutControlItem2.ContentVisible = false;
                layoutControlItem3.ContentVisible = false;
                layoutControlItem1.Width += 15;
            }
        }
    }
}
