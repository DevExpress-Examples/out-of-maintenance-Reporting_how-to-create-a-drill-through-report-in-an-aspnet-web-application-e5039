﻿<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Products.aspx.vb" Inherits="E5039.Products" %>

<%@ Register Assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxDocumentViewer ID="dvProducts" runat="server" oninit="dvProducts_Init">
		</dx:ASPxDocumentViewer>
	</div>
	</form>
</body>
</html>