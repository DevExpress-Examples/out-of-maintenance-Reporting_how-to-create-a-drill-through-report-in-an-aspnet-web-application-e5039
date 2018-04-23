using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E5039.Reports;
using DevExpress.XtraReports.Web;

namespace E5039 {
    public partial class Products : System.Web.UI.Page {
        protected void dvProducts_Init(object sender, EventArgs e) {
            ASPxDocumentViewer documentViewer = sender as ASPxDocumentViewer;

            int categoryID = Int32.Parse(Request.QueryString["CategoryID"]);
            ProductsReport report = new ProductsReport();
            report.Parameters["CategoryID"].Value = categoryID;
            documentViewer.Report = report;
        }
    }
}