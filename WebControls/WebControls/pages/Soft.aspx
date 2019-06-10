<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Soft.aspx.cs" Inherits="WebControls.pages.Soft" %>

<%--<%@ Register src="../control/Pannel.ascx" tagname="Panel" tagprefix="co" %>--%>
<%@ Register Src="../control/SoftIteam/SoftIteam.ascx" TagPrefix="co" TagName="SoftIteam" %>

<%--<head  runat="server">
    <link href="~/css/SoftIteamStyle.css" rel="stylesheet" type="text/css" />
</head>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/control/SoftIteam/SoftIteamStyle.css" rel="stylesheet" type="text/css" />   

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <co:SoftIteam runat="server" id="SoftIteam0" Tittle="easyIcon软件" Note="easyIcon是一款简单易用的Icon制作工具" Size="1.27 MB" ImageUrl="~/res/pic/0.png" LinkUrl="https://scimence.gitee.io/easyicon/note.html" OnClick="Button_Click" />
        <co:SoftIteam runat="server" id="SoftIteam1" Tittle="360浏览器" Note="安全、快速、可阅读打印pdf的浏览器" Size="48.9 MB" ImageUrl="~/res/pic/1.png" LinkUrl="https://browser.360.cn/ee/" OnClick="Button_Click" />
        <co:SoftIteam runat="server" id="SoftIteam2" Tittle="微信" Note="免费社交平台" Size="36.3 MB" ImageUrl="~/res/pic/2.png" LinkUrl="https://pc.weixin.qq.com" OnClick="Button_Click"/>
        <co:SoftIteam runat="server" id="SoftIteam3" Tittle="360压缩" Note="双核解压缩软件，永久免费、安全急速" Size="11.2 MB" ImageUrl="~/res/pic/3.png" LinkUrl="http://yasuo.360.cn" OnClick="Button_Click"/>
        <co:SoftIteam runat="server" id="SoftIteam4" Tittle="爱奇艺视屏" Note="一款专注视屏播放的客户端软件，你可以在线享受爱奇艺官网所有正版视屏" Size="39.7 MB" ImageUrl="~/res/pic/4.png" LinkUrl="https://scimence.gitee.io/easyicon/note.html" OnClick="Button_Click"/>
        <co:SoftIteam runat="server" id="SoftIteam5" Tittle="酷狗音乐" Note="很受欢迎的免费音乐下载、播放软件" Size="43.5 MB" ImageUrl="~/res/pic/5.png" LinkUrl="https://scimence.gitee.io/easyicon/note.html" OnClick="Button_Click"/>
    </form>
</body>
</html>
