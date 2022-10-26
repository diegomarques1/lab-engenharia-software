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
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdutoGeral produto = new ProdutoGeral();
            LabelNomeProduto.Text = produto.getNomeProduto();
            LabelDescricaoProduto.Text = produto.getDescricaoProduto();
        }

        protected void AdicionarProdutoPedido(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            if (cliente.isLogged())
            {
                ProdutoGeral produtoGeral = new ProdutoGeral();
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
    }
}