<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Produto.aspx.cs" Inherits="iChurras.Produto1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style/Produtos.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="divProduto">            
            <div class="divTextoProduto">
                <div style="height:90%; width:100%">
                    <div class="divImagemProduto">
                        <img src="" class="imagemProduto" />
                    </div>
                    <asp:Label ID="LabelNomeProduto" runat="server" Text="Nome Produto"></asp:Label>    
                    <br />
                    <br />
                    <asp:Label ID="LabelDescricaoProduto" runat="server" Text="Descricao"></asp:Label>
                </div>
                <div style="height:10%; width: 100%">
                    <asp:Button ID="ButtonFavoritar" runat="server" Text="Favoritar produto" style="float:right" OnClick="ButtonFavoritar_Click" Visible="False" />
                </div>
            </div>
            <div class="divButtonProduto"> 
                <asp:Button CssClass="buttonProduto" ID="ButtonProduto2" runat="server" Text="Adicionar ao pedido" OnClick="AdicionarProdutoPedido" />
            </div>
        </div>
    </form>
</body>
</html>
