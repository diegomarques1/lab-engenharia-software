using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class AcompanhamentoPedido : System.Web.UI.Page
    {
        Pedido pedido;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label l;
            pedido = new Pedido();
            LabelCodigo.Text = "Código para recebimento: " + pedido.getCodRecebimento();
            LabelEntrega.Text = "Previsão de entrega: " + pedido.getPrevisaoEntrega().ToString("HH:mm");
            LabelEndereco.Text = "Endereço de entrega: " + pedido.getEndereco();
            switch (pedido.getEstadoPedido())
            {
                case 0:
                    LabelStatus.Text = "Status: Em preparação";
                    break;
                case 1:
                    LabelStatus.Text = "Status: Saiu para entrega";
                    break;
                case 2:
                    LabelStatus.Text = "Status: Entregue";
                    break;
            }
            for (int i = 0; i < pedido.Count(); i++)
            {
                l = new Label();
                l.Text = pedido.buscarNode(pedido.buscarProduto(i)).getQuantidade().ToString() + "x "+ pedido.buscarProduto(i).getNomeProduto();
                PHProdutos.Controls.Add(l);
                PHProdutos.Controls.Add(new LiteralControl("<br />"));
            }
        }

        protected void ButtonVoltar_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("Home.aspx");
        }

        protected void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            LabelAvaliacao.Visible = true;
            RadioButtonListAvaliacao.Visible = true;
            ButtonConfirmarAvaliacao.Visible = true;
            ButtonConfirmar.Enabled = false;
            ClasseConexao con = new ClasseConexao();
            con.executarSQL("update tblPedidos set estadoPedido = "+ 2 +" where CodPedido = " + pedido.getCodPedido());
            pedido.setEstadoPedido(2);
        }

        protected void ButtonConfirmarAvaliacao_Click(object sender, EventArgs e)
        {
            ClasseConexao con = new ClasseConexao();
            con.executarSQL("update tblPedidos set avaliacao = " + (RadioButtonListAvaliacao.SelectedIndex + 1) + " where CodPedido = " + pedido.getCodPedido());
            LabelAvaliacao.Text = "Avaliação enviada!";
            RadioButtonListAvaliacao.Visible = false;
            ButtonConfirmarAvaliacao.Visible = false;
        }
    }
}