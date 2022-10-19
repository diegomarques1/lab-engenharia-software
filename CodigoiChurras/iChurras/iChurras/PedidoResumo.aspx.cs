using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace iChurras
{
    public partial class PedidoResumo : System.Web.UI.Page
    {
        Pedido pedido;
        protected void Page_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            pedido = new Pedido();
            Label l;
            Button b;
            for (int i = 0; i < pedido.Count(); i++)
            {
                Node noAux = pedido.buscarNode(pedido.buscarProduto(i));                
                l = new Label();
                b = new Button();
                b.ID = noAux.getProduto().getNomeProduto();
                b.Text = "-";
                b.Click += new EventHandler(this.BotaoRemove_Click);
                l.Text = noAux.getQuantidade() + "x - " + noAux.getProduto().getNomeProduto();
                PHProdutos.Controls.Add(new LiteralControl("<br />"));                
                PHProdutos.Controls.Add(l);
                PHProdutos.Controls.Add(b);
            }
            LabelPreco.Text = pedido.getPreco().ToString();
        }
        protected void BotaoRemove_Click(object sender, EventArgs e)
        {
            Produto produto = pedido.buscarProduto(((Button)sender).ID);
            pedido.removerProduto(produto);
            Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

        protected void ButtonCadastrarNovoEndereco_Click(object sender, EventArgs e)
        {
            LabelEndereco.Visible = true;
            TextBoxEndereco.Visible = true;
            Button btn = new Button();
            btn.Text = "Cadastrar";
            btn.ID = "CadatrarEndereco";
            btn.Click += new EventHandler(this.ButtonCadastrarEndereco_Click);
            PHEnderecos.Controls.Add(btn);
        }
        protected void ButtonCadastrarEndereco_Click(object sender, EventArgs e)
        {
            LabelEndereco.Text = "ccccccc";
            if (TextBoxEndereco.Text == null)
            {
                
            }
            else
            {
                LabelEndereco.Text = "aaaaa";
                LabelEndereco.Visible = false;
                TextBoxEndereco.Visible = false;
                ListItem LI = new ListItem();
                LI.Value = TextBoxEndereco.Text;
                LI.Text = TextBoxEndereco.Text;
                RadioButtonListEndereco.Items.Add(LI);
            }
        }
    }
}