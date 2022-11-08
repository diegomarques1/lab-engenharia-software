<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarCartao.aspx.cs" Inherits="iChurras.CadastrarCartao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:Label ID="Label1" runat="server" > Número do cartão: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxNumCartao" runat="server" MaxLength="16"></asp:TextBox>
            <br />
                <asp:Label ID="Label2" runat="server" > Código de segurança: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxNumSeguranca" runat="server" MaxLength="3"></asp:TextBox>
            <br />
                <asp:Label ID="Label3" runat="server" > Nome do proprietário: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxNome" runat="server"></asp:TextBox>
            <br />
                <asp:Label ID="Label4" runat="server" > Validade do cartão: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxValidade" runat="server" MaxLength="5"></asp:TextBox>
            <br />
                <asp:Button ID="ButtonCadastrar" runat="server" Text="Cadastrar" OnClick="ButtonCadastrar_Click" />
            <br />
                <asp:Label ID="LabelResposta" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
