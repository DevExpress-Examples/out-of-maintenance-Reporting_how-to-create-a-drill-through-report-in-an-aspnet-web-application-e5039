Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace E5039.Reports
	Partial Public Class ProductsReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ProductsReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
			productsTableAdapter1.Fill(nWindDataSet1.Products, CType(Parameters("CategoryID").Value, Integer?))
		End Sub

	End Class
End Namespace
