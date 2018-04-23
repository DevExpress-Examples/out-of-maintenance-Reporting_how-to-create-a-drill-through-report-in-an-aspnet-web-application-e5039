using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace E5039.Reports {
    public partial class ProductsReport : DevExpress.XtraReports.UI.XtraReport {
        public ProductsReport() {
            InitializeComponent();
        }

        private void ProductsReport_DataSourceDemanded(object sender, EventArgs e) {
            productsTableAdapter1.Fill(nWindDataSet1.Products, (int?) Parameters["CategoryID"].Value);
        }

    }
}
