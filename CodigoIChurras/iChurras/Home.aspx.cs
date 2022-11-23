using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace iChurras
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ClasseConexao con;
        DataSet dataset;
        Cliente cliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
            con = new ClasseConexao();
            dataset = new DataSet();
            String comando;
            Button b;
            Label l;
            if (cliente.isLogged())
            {
                PHProdutos.Controls.Add(new LiteralControl("<h2> Favoritos </h2>"));
                PHProdutos.Controls.Add(new LiteralControl("<div style=\"width: 100%; float: inline-start\">"));
                comando = "select NomeProduto from tblProdutos inner join tblProdutosFavoritos on tblProdutos.CodProduto = tblProdutosFavoritos.CodProduto where tblProdutosFavoritos.CodCliente = " + cliente.getCodCliente();
                dataset = con.retornarSQL(comando);
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    b = new Button();
                    b.Text = "Ver detalhes";
                    b.ID = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                    b.CssClass = "buttonProduto";
                    b.Click += new EventHandler(this.ButtonProduto_Click);
                    l = new Label();
                    l.Text = b.ID;
                    PHProdutos.Controls.Add(new LiteralControl("<div class=\"divProduto\">"));
                    PHProdutos.Controls.Add(new LiteralControl("<div class=\"divImagemProduto\">"));
                    PHProdutos.Controls.Add(new LiteralControl("<img src=\"\" class=\"imagemProduto\" />"));
                    PHProdutos.Controls.Add(new LiteralControl("</div>"));
                    PHProdutos.Controls.Add(new LiteralControl("<div class=\"divTextoProduto\">"));
                    PHProdutos.Controls.Add(l);
                    PHProdutos.Controls.Add(new LiteralControl("</div>"));
                    PHProdutos.Controls.Add(new LiteralControl("<div class=\"divButtonProduto\">"));
                    PHProdutos.Controls.Add(b);
                    PHProdutos.Controls.Add(new LiteralControl("</div>"));
                    PHProdutos.Controls.Add(new LiteralControl("</div>"));
                }
                PHProdutos.Controls.Add(new LiteralControl("</div>"));
            }
            PHProdutos.Controls.Add(new LiteralControl("<div style=\"width: 100%; float: inline-end\">"));
            comando = "select NomeProduto from tblProdutos";
            dataset = con.retornarSQL(comando);
            PHProdutos.Controls.Add(new LiteralControl("<h2> Cardapio </h2>"));
            for (int  i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                b = new Button();
                b.Text = "Ver detalhes";
                b.ID = dataset.Tables[0].Rows[i].ItemArray[0].ToString();
                b.CssClass = "buttonProduto";
                b.Click += new EventHandler(this.ButtonProduto_Click);
                l = new Label();
                l.Text = b.ID;
                PHProdutos.Controls.Add(new LiteralControl("<div class=\"divProduto\">"));
                PHProdutos.Controls.Add(new LiteralControl("<div class=\"divImagemProduto\">"));
                PHProdutos.Controls.Add(new LiteralControl("<img src=\"\" class=\"imagemProduto\" />"));
                PHProdutos.Controls.Add(new LiteralControl("</div>"));
                PHProdutos.Controls.Add(new LiteralControl("<div class=\"divTextoProduto\">"));
                PHProdutos.Controls.Add(l);
                PHProdutos.Controls.Add(new LiteralControl("</div>"));
                PHProdutos.Controls.Add(new LiteralControl("<div class=\"divButtonProduto\">"));
                PHProdutos.Controls.Add(b);
                PHProdutos.Controls.Add(new LiteralControl("</div>"));
                PHProdutos.Controls.Add(new LiteralControl("</div>"));
            }
            PHProdutos.Controls.Add(new LiteralControl("</div>"));
        }

        protected void ButtonProduto_Click(object sender, EventArgs e)
        {
            ProdutoGeral produtoGeral = new ProdutoGeral();
            con = new ClasseConexao();
            dataset = new DataSet();
            String comando = "select * from tblProdutos where CodProduto = '" + ((Button)sender).ID + "'";
            dataset = con.retornarSQL(comando);
            produtoGeral.setCodProduto(Convert.ToInt32(dataset.Tables[0].Rows[0].ItemArray[0].ToString()));
            produtoGeral.setNomeProduto(dataset.Tables[0].Rows[0].ItemArray[1].ToString());
            produtoGeral.setPrecoProduto(float.Parse(dataset.Tables[0].Rows[0].ItemArray[2].ToString()));
            produtoGeral.setDescricaoProduto(dataset.Tables[0].Rows[0].ItemArray[3].ToString());
            produtoGeral.setTipoProduto(Convert.ToInt32(dataset.Tables[0].Rows[0].ItemArray[4].ToString()));
            HttpContext.Current.Response.Redirect("Produto.aspx");
        }        
    }
}