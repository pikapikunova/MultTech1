<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auth.aspx.cs" Inherits="MultTech1.Auth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="FirstStyle.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">

         <h4 id="til">
            <asp:Label ID="Label3" runat="server" Text="Добро пожаловать!" CssClass="heading1"></asp:Label>
        </h4>

        <div id="general">
        <asp:Label ID="Label1" runat="server" Text="Логин"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Пароль"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
            
        <asp:Button ID="Button1" runat="server" Text="Вход" Height="36px" Width="135px" OnClick="Button1_Click" />
            <br />
            <br />
            </div>
    <div id="extra">
        <asp:Label ID="Label4" runat="server" Text="Если у вас ещё нет личного кабинета, вы можете"></asp:Label>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#EADD46" NavigateUrl="~/Regist.aspx">Зарегистрироваться</asp:HyperLink>
        </div>
            </div>
    </form>
    </body>
</html>
