<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LKStudent.aspx.cs" Inherits="MultTech1.LKStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="LKStyle.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h1 id="tit">
            <asp:Label ID="Label1" runat="server" Text="Привет, "></asp:Label>
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            </h1>
        <div>
            <asp:Menu ID="Menu1" runat="server" ForeColor="#596A71">
                <Items>
                    <asp:MenuItem Text="Изучение теории" Value="Изучение теории" NavigateUrl="~/Theory.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Проверь себя" Value="Проверь себя" NavigateUrl="~/Test.aspx"></asp:MenuItem>
                </Items>
            </asp:Menu>
            <br />
        </div>
        <div id="yourData">

            <asp:Label ID="Label3" runat="server" Text="Твои данные"></asp:Label>
            :<br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="surname" HeaderText="surname" SortExpression="surname" />
                    <asp:BoundField DataField="patronymic" HeaderText="patronymic" SortExpression="patronymic" />
                    <asp:BoundField DataField="dateOfTest" HeaderText="dateOfTest" SortExpression="dateOfTest" />
                    <asp:BoundField DataField="marks" HeaderText="marks" SortExpression="marks" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MediaTech1ConnectionString %>" SelectCommand="SELECT ID, name, surname, patronymic, dateOfTest, marks FROM Student"></asp:SqlDataSource>

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Auth.aspx">Выйти</asp:HyperLink>

            </div>
            </div>
    </form>
</body>
</html>
