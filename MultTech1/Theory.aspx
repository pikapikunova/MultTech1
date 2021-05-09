<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Theory.aspx.cs" Inherits="MultTech1.Theory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="TheoryTestStyle.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="general">
        <h1>
             <asp:Label ID="Label1" runat="server" Text="Добро пожаловать в раздел теории!"></asp:Label>
        </h1>

        <div>

            <br />
            <asp:MultiView ID="MultiView1" runat="server">

            </asp:MultiView>

            <br />

            <asp:Button ID="Button2" runat="server" Text="Назад" OnClick="Button2_Click1" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Вперёд" />

            <br />

        </div>
             <div>
         <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#596A71" NavigateUrl="~/LKStudent.aspx">Вернуться на главную</asp:HyperLink>
        
             </div>
            </div>
    </form>
    
    
</body>
</html>
