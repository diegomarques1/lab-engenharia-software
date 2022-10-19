<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PedidoResumo.aspx.cs" Inherits="iChurras.PedidoResumo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style/PedidoResumo.css"/>
    <title></title>
</head>
<body>
    <main>        
        <form id="form1" runat="server">
        <div id="divPedido">
            <div id="div1">                
                <div id="divListaProdutos">                
                    <asp:Label ID="LabelProdutos" runat="server" Text="Produtos"></asp:Label>
                    <asp:PlaceHolder ID="PHProdutos" runat="server"></asp:PlaceHolder>
                </div>      
                <div id="divPreco">                
                    <asp:Label ID="LabelPreco" runat="server" Text="Preco"></asp:Label>
                </div>
            </div>
            <div id="divEndereco">                
                <asp:Label ID="Label3" runat="server" Text="Endereco"></asp:Label><br />
                <asp:Button ID="ButtonCadastrarEndereco" runat="server" Text="Cadastrar novo endereco" OnClick="ButtonCadastrarNovoEndereco_Click" /><br />
                <asp:RadioButtonList ID="RadioButtonListEndereco" runat="server">
                </asp:RadioButtonList>
                <asp:Label ID="LabelEndereco" runat="server" Text="Digite o endereço:" Visible="False"></asp:Label><br />
                <asp:TextBox ID="TextBoxEndereco" runat="server" Visible="False"></asp:TextBox><br />
                <asp:PlaceHolder ID="PHEnderecos" runat="server"></asp:PlaceHolder>
            </div>      
            <div id="divPagamento">                
                <asp:Label ID="Label4" runat="server" Text="Pagamento"></asp:Label><br />
                <asp:Button ID="ButtonCadastrarCartao" runat="server" Text="Cadastrar novo método de pagamento" /><br />
                <asp:Button ID="ButtonUsarExistente" runat="server" Text="Usar método de pagamento existente" /><br />
                <asp:PlaceHolder ID="PHPagamento" runat="server"></asp:PlaceHolder>
            </div>
        </div>
    </form>
    </main>
</body>
</html>
