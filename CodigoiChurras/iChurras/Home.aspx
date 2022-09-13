<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="iChurras.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style/Home.css"/>
    <title></title>
</head>
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
<body>
    <a>        
        <div class="divProduto">
            <div class="divImagemProduto">
                <img src="" class="imagemProduto" />
            </div>
            <div class="divTextoProduto"> 
                <asp:Label ID="Label1" runat="server" Text="Produto1"></asp:Label>       
            </div>              
        </div>
    </a>        
        <div class="divProduto">
            <div class="divImagemProduto">
                <img src="" class="imagemProduto" />
            </div>
            <div class="divTextoProduto"> 
                <asp:Label ID="Label2" runat="server" Text="Produto2"></asp:Label>       
            </div>              
        </div>
    <asp:GridView ID="GridView1" runat="server" Height="16px" Visible="False" Width="16px"></asp:GridView>
</body>
</html>
