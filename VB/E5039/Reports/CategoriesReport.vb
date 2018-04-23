Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace E5039.Reports
	Partial Public Class CategoriesReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub lbCategoryName_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) Handles lbCategoryName.HtmlItemCreated
			e.ContentCell.Attributes.Add("onclick", String.Format("parent.CategoriesReport_CategoryClick('{0}')", e.Brick.Value))
			e.ContentCell.Style.Add("cursor", "pointer")
		End Sub

	End Class
End Namespace
