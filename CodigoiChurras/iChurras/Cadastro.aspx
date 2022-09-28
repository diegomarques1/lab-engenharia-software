<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="iChurras.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:Label ID="Label1" runat="server"> Nome: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
            <br />
                <asp:Label ID="Label2" runat="server"> E-mail: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            <br />
                <asp:Label ID="Label3" runat="server"> Telefone: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxTelefone" runat="server"></asp:TextBox>
            <br />
                <asp:Label ID="Label4" runat="server"> Senha: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxSenha" runat="server"></asp:TextBox>
            <br />
                <asp:Label ID="Label5" runat="server" > Confirme sua senha: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxSenha2" runat="server"></asp:TextBox>
            <br />
                <asp:Button ID="ButtonCadastrar" runat="server" Text="Cadastrar" OnClick="ButtonCadastrar_Click" />
            <br />
                <asp:Label ID="LabelResposta" runat="server"></asp:Label>
            <br />
                <asp:Label ID="LabelNomeCliente" runat="server"></asp:Label>
            <br />
                <asp:Label ID="LabelTelefoneCliente" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
