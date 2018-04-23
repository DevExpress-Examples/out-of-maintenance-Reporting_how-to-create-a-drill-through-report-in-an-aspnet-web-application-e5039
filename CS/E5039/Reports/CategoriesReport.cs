using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace E5039.Reports {
    public partial class CategoriesReport : DevExpress.XtraReports.UI.XtraReport {
        public CategoriesReport() {
            InitializeComponent();
        }

        private void lbCategoryName_HtmlItemCreated(object sender, HtmlEventArgs e) {
            e.ContentCell.Attributes.Add("onclick", String.Format("parent.CategoriesReport_CategoryClick('{0}')", e.Brick.Value));
            e.ContentCell.Style.Add("cursor", "pointer");
        }

    }
}
