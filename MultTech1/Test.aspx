<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="MultTech1.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="TheoryTestStyle.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

         <div>
             <h1>Проверь себя!</h1>
        </div>
        <div>

        <div>

            <br />
            <asp:MultiView ID="MultiView1" runat="server">

            </asp:MultiView>

            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ответить" Width="165px" />
            <br />

            <br />

            <asp:Button ID="Button2" runat="server" Text="Назад" OnClick="Button2_Click1" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Вперёд" />

            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Закончить попытку" Visible="False" />

            <br />

        </div>

            </div>
         <div>
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/LKStudent.aspx">Вернуться на главную</asp:HyperLink>
        </div>
    </form>
</body>
</html>
