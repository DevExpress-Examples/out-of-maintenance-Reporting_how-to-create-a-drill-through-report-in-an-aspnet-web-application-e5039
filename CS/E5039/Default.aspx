<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E5039.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.2.Web, Version=13.2.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function CategoriesReport_CategoryClick(categoryID) {
            popup.SetContentUrl("Products.aspx?CategoryID=" + categoryID);
            popup.Show();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxDocumentViewer ID="dvCategories" runat="server" ReportTypeName="E5039.Reports.CategoriesReport">
        </dx:ASPxDocumentViewer>
        <dx:ASPxPopupControl ID="pcProductReport" runat="server" AllowResize="True" ClientInstanceName="popup"
            CloseAction="CloseButton" Height="600px" Modal="True" PopupHorizontalAlign="WindowCenter"
            PopupVerticalAlign="WindowCenter" Width="800px" ContentUrl="about:blank" HeaderText="Products">
        </dx:ASPxPopupControl>
    </div>
    </form>
</body>
</html>
