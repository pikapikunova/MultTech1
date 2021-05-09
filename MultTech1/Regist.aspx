<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="MultTech1.Regist" %>

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
        <h1>
            <asp:Label ID="Label6" runat="server" Text="Регистрация"></asp:Label>
            </h1>

        <div id="general">
            <asp:Label ID="Label1" runat="server" Text="Имя"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator class ="check" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Введите имя" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Фамилия"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator class ="check" ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Введите фамилию"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Отчетсво"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator class ="check" ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Введите отчество"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Логин"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator class ="check" ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Введите логин"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Пароль"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator class ="check" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Введите пароль" ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Студент</asp:ListItem>
                <asp:ListItem>Преподаватель</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator class="check" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Выберите тип доступа" ControlToValidate="RadioButtonList1"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator class ="check" ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Логин введён некорректно" ValidationExpression="[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}"></asp:RegularExpressionValidator>
            <br />
            <asp:RegularExpressionValidator class="check" ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Имя введено некорректно" ValidationExpression="^([а-яА-Я]+)"></asp:RegularExpressionValidator>
            <br />
            <asp:RegularExpressionValidator class="check" ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Фамилия введена некорректно" ValidationExpression="^([а-яА-Я]+)"></asp:RegularExpressionValidator>
            <br />
            <asp:RegularExpressionValidator class="check" ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox3" ErrorMessage="Отчество введено некорректно" ValidationExpression="^([а-яА-Я]+)"></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Зарегистрироваться" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="Label7" runat="server"></asp:Label>
            <br />
            <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Auth.aspx" ForeColor="#EADD46">Вернуться на главную</asp:HyperLink>
        </p>
        </div>
            </div>
        
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
