<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarEndereco.aspx.cs" Inherits="iChurras.CadastrarEndereco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <asp:Label ID="Label1" runat="server" > Endereço: </asp:Label>
            <br />
                <asp:TextBox ID="TextBoxEndereco" runat="server"></asp:TextBox>
            <br />
                <asp:Button ID="ButtonCadastrar" runat="server" Text="Cadastrar" OnClick="ButtonCadastrar_Click" />
            <br />
                <asp:Label ID="LabelResposta" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
