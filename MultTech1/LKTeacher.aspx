<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LKTeacher.aspx.cs" Inherits="MultTech1.LKTeacher" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="LKStyle.css"/>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <h1 id="tit">
             <asp:Label ID="Label3" runat="server" Text="Здравствуйте, "></asp:Label>
             <asp:Label ID="Label2" runat="server"></asp:Label>
        </h1>

        <div>
            <br />
            <asp:Menu ID="Menu1" runat="server" ForeColor="#596A71">
                <Items>
                    <asp:MenuItem Text="Редактировать теорию" Value="Редактировать теорию"></asp:MenuItem>
                    <asp:MenuItem Text="Редактировать тест" Value="Редактировать тест"></asp:MenuItem>
                </Items>
            </asp:Menu>
            <br />
        </div>

         <div id="yourData">
             <asp:Label ID="Label4" runat="server" Text="Данные о студентах:"></asp:Label>
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                 <Columns>
                     <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                     <asp:BoundField DataField="surname" HeaderText="surname" SortExpression="surname" />
                     <asp:BoundField DataField="patronymic" HeaderText="patronymic" SortExpression="patronymic" />
                     <asp:BoundField DataField="dateOfTest" HeaderText="dateOfTest" SortExpression="dateOfTest" />
                     <asp:BoundField DataField="marks" HeaderText="marks" SortExpression="marks" />
                 </Columns>
             </asp:GridView>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MediaTech1ConnectionString %>" SelectCommand="SELECT [name], [surname], [patronymic], [dateOfTest], [marks] FROM [Student]"></asp:SqlDataSource>
             <br />
        </div>

         <div>
             <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Auth.aspx">Выйти</asp:HyperLink>
        </div>
    </form>
</body>
</html>
