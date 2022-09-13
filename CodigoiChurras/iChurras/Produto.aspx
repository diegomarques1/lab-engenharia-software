<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produto.aspx.cs" Inherits="iChurras.Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>    
    <link rel="stylesheet" type="text/css" href="style/Produtos.css"/>
    <title></title>
</head>
<body>
    <div id="ProdutoInformacoes">
        <div id="ProdutoImagem">
            <asp:Image ID="ImagemProduto" runat="server" />
        </div>
        <div id="ProdutoNome">
            <asp:Label ID="LabelNomeProduto" runat="server"></asp:Label>
        </div>
        <div id="ProdutoDescricao">
            <asp:Label ID="LabelDescricaoProduto" runat="server"></asp:Label>
        </div>
    </div>
</body>
</html>
