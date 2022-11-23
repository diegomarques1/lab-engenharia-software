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
<form runat="server" id="form1">
    <asp:PlaceHolder ID="PHProdutos" runat="server">


    </asp:PlaceHolder>
           
</form>
</main>
</body>
</html>
