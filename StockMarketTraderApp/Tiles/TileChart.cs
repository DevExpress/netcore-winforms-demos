using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.StockMarketTrader.Tiles {
    public partial class TileChart : UserControl {
        public TileChart(Size size) {
            InitializeComponent();
            this.Size = size;
            sparklineEdit1.Properties.DataSource = StockMarketView.defaultViewModel.SparklineTileViewModel.Source;
            sparklineEdit1.Properties.PointValueMember = "Price";
            sparklineEdit1.EditValue = sparklineEdit1.Properties.DataSource;
            string arrow = StockMarketView.defaultViewModel.SparklineTileViewModel.Arrow;
            string company = StockMarketView.defaultViewModel.SparklineTileViewModel.CompanyIndex;
            string percent = StockMarketView.defaultViewModel.SparklineTileViewModel.Persent;
            string result = String.Format("<size=-2>{0}</size><br>{1} {2}", company, arrow, percent);
            labelControl1.Text = result;
            if(size.Width == size.Height) {
                layoutControlItem1.ContentVisible = false;
            }
        }
    }
}
