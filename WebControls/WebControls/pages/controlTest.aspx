<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="controlTest.aspx.cs" Inherits="WebControls.pages.DateTime" %>

<%@ Register Assembly="WebControls" Namespace="WebControls.control.DropdownList" TagPrefix="cc2" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<%@ Register assembly="WebControls" namespace="WebControls.control.formDemo1" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<cc1:FormDemo1 ID="FormDemo11" runat="server">
        </cc1:FormDemo1>--%>

        <cc1:FormDemo1 ID="FormDemo1" runat='server' PaymentMethodText='标题信息'></cc1:FormDemo1>

    </div>
    </form>
</body>
</html>
