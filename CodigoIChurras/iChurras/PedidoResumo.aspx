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
                    <asp:Label ID="LabelPrecoProdutos" runat="server" ></asp:Label><br />
                    <asp:Label ID="LabelPrecoFrete" runat="server" ></asp:Label><br />
                    <asp:Label ID="LabelPrecoTotal" runat="server" Visible="False"></asp:Label><br />
                </div>
            </div>
            <div id="divEndereco">                
                <asp:Label ID="Label3" runat="server" Text="Endereco"></asp:Label><br />
                <asp:Button ID="ButtonCadastrarEndereco" runat="server" Text="Cadastrar novo endereco" OnClick="ButtonCadastrarNovoEndereco_Click" /><br />
                <asp:RadioButtonList ID="RadioButtonListEndereco" runat="server" style="float: left">
                </asp:RadioButtonList><br />
                <asp:Label ID="LabelEndereco" runat="server" Text="Digite o endereço:" Visible="False"></asp:Label><br />
                <asp:TextBox ID="TextBoxEndereco" runat="server" Visible="False"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="ButtonCalcularFrete" runat="server" Text="Calcular frete" OnClick="ButtonCalcularFrete_Click" /><br />
                <asp:PlaceHolder ID="PHEnderecos" runat="server"></asp:PlaceHolder>
                <asp:Label ID="LabelTempo" runat="server"></asp:Label>
            </div>      
            <div id="divPagamento">                
                <asp:Label ID="Label4" runat="server" Text="Pagamento"></asp:Label><br />
                <asp:Button ID="ButtonCadastrarCartao" runat="server" Text="Cadastrar novo método de pagamento" OnClick="ButtonCadastrarCartao_Click" /><br />
                <asp:RadioButtonList ID="RadioButtonListPagamento" runat="server" style="float: left">
                </asp:RadioButtonList>
            </div>
        </div>
            <asp:Button ID="ButtonVoltarMenu" runat="server" Text="Voltar ao menu" style="float: left; margin-left: 5%" Width="250px" OnClick="ButtonVoltarMenu_Click"/>
            <asp:Button ID="ButtonFinalizarPedido" runat="server" Text="Finalizar pedido" OnClick="ButtonFinalizarPedido_Click"  style="float: right; margin-right: 5%" Width="250px"/>
    </form>
    </main>
</body>
</html>
