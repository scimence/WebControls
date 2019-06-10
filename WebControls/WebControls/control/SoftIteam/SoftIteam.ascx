<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SoftIteam.ascx.cs" Inherits="WebControls.control.SoftIteam" %>

<%--<head runat="server">
    <link href="~/control/SoftIteam/SoftIteamStyle.css" rel="stylesheet" type="text/css" />
</head>--%>

<div class="Iteam" >
    <asp:Image class=Image ID="Icon" runat="server" width="60px" Height="60px"  />
    <div class="PosTittle">
        <asp:Label ID="LabelTittle" runat="server" Text="标题" Font-Bold="True"></asp:Label>
    </div>
    <div class="PosContent">
        <asp:Label ID="LabelContent" runat="server" Text="说明信息说明信息说明信息说明信息" ForeColor="#888888"></asp:Label>
    </div>
    <div class="PosSize">
        <asp:Label ID="LabelSize" runat="server" Text="200KB"></asp:Label>
    </div>
    <div class="PosButton">
        <asp:Button ID="ButtonDetail" runat="server" OnClick="Button_Click" Text="详情" Height="24px" Width="52px" />
    </div>
</div>