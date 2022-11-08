<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AcompanhamentoPedido.aspx.cs" Inherits="iChurras.AcompanhamentoPedido" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" type="text/css" href="style/AcompanhamentoPedido.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divPrincipal">
            <div style="width: 100%; height: 15%">
                <h2> Acompanhamento do pedido </h2>
            </div>
            <div id="divInformacoes" >
                <br />
                <asp:Label ID="LabelEndereco" runat="server" Text="Endereco de entrega: "></asp:Label> 
                <br />
                <br />
                <br />
                <asp:Label ID="LabelEntrega" runat="server" Text="Previsao de chegada: "></asp:Label>
                <br />
                <br />
                <br />
                <asp:Label ID="LabelCodigo" runat="server" Text="Código para recebimento: "></asp:Label> 
                <br />
                <br />
                <br />
                <asp:Label ID="LabelStatus" runat="server" Text="Status: "></asp:Label>
            </div>
            <div id="divResumo"> 
                <h3> Resumo do pedido</h3>
                <asp:PlaceHolder ID="PHProdutos" runat="server"></asp:PlaceHolder>
            </div>
            <div id="divAvaliacao">
                <div style="height: 100%; width: 50%; float:left">                    
                    <asp:Label ID="LabelAvaliacao" runat="server" Text="Deixe sua avaliação: " Visible="False"></asp:Label>
                    <br />
                    <asp:RadioButtonList ID="RadioButtonListAvaliacao" runat="server" Visible="False">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:RadioButtonList>
                    
                </div>
                <div style="height: 100%; width: 49%; float:right">      
                    <asp:Button ID="ButtonConfirmarAvaliacao" runat="server" Text="Confirmar avaliação" style="margin:50px " Height="26px" OnClick="ButtonConfirmarAvaliacao_Click" Visible="False" Width="208px" />
                </div>
            </div>
        </div>
        <asp:Button ID="ButtonVoltar" runat="server" Text="Voltar à página inicial" style="float:left; margin-left: 5%" Width="250px" OnClick="ButtonVoltar_Click" />
        <asp:Button ID="ButtonConfirmar" runat="server" Text="Confirmar recebimento" style="float:right; margin-right: 5%" Width="250px" OnClick="ButtonConfirmar_Click" />
    </form>
</body>
</html>
