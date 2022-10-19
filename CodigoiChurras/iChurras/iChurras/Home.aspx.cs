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
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView gv = new GridView();
            con = new ClasseConexao();
            dataset = new DataSet();
            String comando = "select NomeProduto from tblProdutos";
            dataset = con.retornarSQL(comando);
            gv.DataSource = dataset;
            gv.DataBind();
            Label1.Text = gv.Rows[0].Cells[0].Text;
            Label2.Text = gv.Rows[1].Cells[0].Text;
        }

        protected void ButtonProduto1_Click(object sender, EventArgs e)
        {
            ProdutoGeral produtoGeral = new ProdutoGeral();
            GridView gv = new GridView();
            con = new ClasseConexao();
            dataset = new DataSet();
            String comando = "select * from tblProdutos where NomeProduto = '" + Label1.Text+ "'";
            dataset = con.retornarSQL(comando);
            gv.DataSource = dataset;
            gv.DataBind();
            produtoGeral.setCodProduto(Convert.ToInt32(gv.Rows[0].Cells[0].Text));
            produtoGeral.setNomeProduto(gv.Rows[0].Cells[1].Text);
            produtoGeral.setPrecoProduto(float.Parse(gv.Rows[0].Cells[2].Text));
            produtoGeral.setDescricaoProduto(gv.Rows[0].Cells[3].Text);
            produtoGeral.setTipoProduto(Convert.ToInt32(gv.Rows[0].Cells[4].Text));
            HttpContext.Current.Response.Redirect("Produto.aspx");
        }

        protected void ButtonProduto2_Click(object sender, EventArgs e)
        {
            ProdutoGeral produtoGeral = new ProdutoGeral();
            GridView gv = new GridView();
            con = new ClasseConexao();
            dataset = new DataSet();
            String comando = "select * from tblProdutos where NomeProduto = '" + Label2.Text + "'";
            dataset = con.retornarSQL(comando);
            gv.DataSource = dataset;
            gv.DataBind();
            produtoGeral.setCodProduto(Convert.ToInt32(gv.Rows[0].Cells[0].Text));
            produtoGeral.setNomeProduto(gv.Rows[0].Cells[1].Text);
            produtoGeral.setPrecoProduto(float.Parse(gv.Rows[0].Cells[2].Text));
            produtoGeral.setDescricaoProduto(gv.Rows[0].Cells[3].Text);
            produtoGeral.setTipoProduto(Convert.ToInt32(gv.Rows[0].Cells[4].Text));
            HttpContext.Current.Response.Redirect("Produto.aspx");
        }
    }
}