<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProdutoAdicionado.aspx.cs" Inherits="iChurras.ProdutoAdicionado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style/ProdutoAdicionado.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divGeral">
            <asp:Label CssClass="labeldiv" runat="server" Text="Produto adicionado ao pedido"></asp:Label>
            <br />
            <asp:Label CssClass="labeldiv" runat="server" Text="Deseja voltar ao cardápio?"></asp:Label>
            <br />
            <asp:Button CssClass="buttondiv" ID="ButtonResumo" runat="server" Text="Voltar ao cardápio" OnClick="ButtonResumo_Click" />
            <br />
            <asp:Button CssClass="buttondiv" ID="ButtonVoltar" runat="server" Text="Ver pedido" OnClick="ButtonVoltar_Click" />
        </div>
    </form>
</body>
</html>
