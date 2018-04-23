Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports E5039.Reports
Imports DevExpress.XtraReports.Web

Namespace E5039
	Partial Public Class Products
		Inherits System.Web.UI.Page
		Protected Sub dvProducts_Init(ByVal sender As Object, ByVal e As EventArgs)
			Dim documentViewer As ASPxDocumentViewer = TryCast(sender, ASPxDocumentViewer)

			Dim categoryID As Integer = Int32.Parse(Request.QueryString("CategoryID"))
			Dim report As New ProductsReport()
			report.Parameters("CategoryID").Value = categoryID
			documentViewer.Report = report
		End Sub
	End Class
End Namespace