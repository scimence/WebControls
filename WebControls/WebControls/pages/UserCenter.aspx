<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserCenter.aspx.cs" Inherits="WebControls.pages.UserCenter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style>
        .MainPannelStyle 
        {
	        background-color: #FFFFFF;
	        background-position: center top;
	        width: 720px;
            height: 500px;
	        margin-left: auto;
	        margin-right: auto;
            padding: 20px;
        }
        .ContentStyle
        {
            padding:50px;
        }
        .tdStyle
        {
            text-align:right;
        }
        .auto-style1 {
            text-align: right;
            height: 31px;
        }
        .auto-style2 {
            height: 31px;
        }
    </style>

</head>
<body style="background-color:gray">
    <form id="form1" runat="server">
        <div class="MainPannelStyle">
    
            <h2 style="color:gray">基本信息</h2>
            <hr />
            <div class="ContentStyle">

                <table border="0" cellspacing="10">
                    <tr>
                        <td class="auto-style1">账号：</td>
                        <td class="auto-style2"> <asp:TextBox ID="TextBoxAccount" runat="server" Width="224px"></asp:TextBox> </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">手机号：</td>
                        <td class="auto-style2" ><asp:TextBox ID="TextBoxPhone" runat="server" Width="224px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdStyle">身份证号：</td>
                        <td><asp:TextBox ID="TextBoxID" runat="server" Width="224px"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td class="tdStyle">支付宝账号：</td>
                        <td><asp:TextBox ID="TextBoxAli" runat="server" Width="224px"></asp:TextBox></td>
                    </tr>
                </table>

                <br /><br />
                <div>
                    <asp:Button ID="ButtonSubmit" runat="server" Text="保存" BackColor="#66CCFF" ForeColor="White" Height="27px" OnClick="ButtonSubmit_Click" Width="60px" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
