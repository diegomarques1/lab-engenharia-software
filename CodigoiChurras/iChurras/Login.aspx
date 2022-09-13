<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="iChurras.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"> Usuário: </asp:Label>
            <asp:TextBox ID="TextBoxUser" runat="server" Width="117px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server"> Senha: </asp:Label>
            <asp:TextBox ID="TextBoxSenha" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="ConcluirLogin" />
        </p>
            <asp:Label ID="LabelResposta" runat="server"> </asp:Label>
        <asp:GridView ID="GridView1" runat="server" Height="250px" Width="500px">
        </asp:GridView>
    </form>
</body>
</html>
