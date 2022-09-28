<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="iChurras.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style/Home.css"/>
    <title></title>
</head>
<body runat="server">
<header>        
        <a href="Login.aspx">
            <div id="ButtonLogin">
                <h4>
                    Login
                </h4>
            </div>
        </a>
         <a href="Cadastro.aspx">
            <div id="ButtonCadastro">
                <h4>
                    Cadastro
                </h4>
            </div>
        </a>
</header>
<main>
<form runat="server">
        <div class="divProduto">
            <div " class="divImagemProduto">                
                <img src="" class="imagemProduto" />
            </div>
            <div class="divTextoProduto"> 
                <asp:Label ID="Label1" runat="server" Text="Produto1"></asp:Label>       
            </div>
            <div class="divButtonProduto"> 
                <asp:Button CssClass="buttonProduto" ID="ButtonProduto1" runat="server" Text="Ver detalhes" OnClick="ButtonProduto1_Click" />
            </div>
        </div>
        <div class="divProduto">
            <div class="divImagemProduto">
                <img src="" class="imagemProduto" />
            </div>
            <div class="divTextoProduto"> 
                <asp:Label ID="Label2" runat="server" Text="Produto2"></asp:Label>       
            </div>
            <div class="divButtonProduto"> 
                <asp:Button CssClass="buttonProduto" ID="ButtonProduto2" runat="server" Text="Ver detalhes" OnClick="ButtonProduto2_Click" />
            </div>
        </div>
</form>
</main>
</body>
</html>
