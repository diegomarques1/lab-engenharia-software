using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class Produto1 : System.Web.UI.Page
    {
        Cliente cliente;
        ProdutoGeral produtoGeral;
        protected void Page_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            produtoGeral = new ProdutoGeral();
            LabelNomeProduto.Text = produtoGeral.getNomeProduto();
            LabelDescricaoProduto.Text = produtoGeral.getDescricaoProduto();
            if (cliente.isLogged())
            {
                ButtonFavoritar.Visible = true;
            }
        }

        protected void AdicionarProdutoPedido(object sender, EventArgs e)
        {
            if (cliente.isLogged())
            {
                Produto produto = new Produto();
                produto.setCodProduto(produtoGeral.getCodProduto());
                produto.setDescricaoProduto(produtoGeral.getDescricaoProduto());
                produto.setNomeProduto(produtoGeral.getNomeProduto());
                produto.setPrecoUnidade(produtoGeral.getPrecoProduto());
                produto.setTipoProduto(produtoGeral.getTipoProduto());
                Pedido pedido = new Pedido();
                pedido.adicionarProduto(produto);
                HttpContext.Current.Response.Redirect("ProdutoAdicionado.aspx");
            }
            else
            {
                HttpContext.Current.Response.Redirect("Login.aspx");
            }
        }

        protected void ButtonFavoritar_Click(object sender, EventArgs e)
        {
            ClasseConexao con = new ClasseConexao();
            con.executarSQL("insert into tblProdutosFavoritos values ("+ produtoGeral.getCodProduto()+", "+cliente.getCodCliente()+")");
            ButtonFavoritar.Text = "Produto adicionado aos favoritos";
            ButtonFavoritar.Enabled = false;
        }
    }
}