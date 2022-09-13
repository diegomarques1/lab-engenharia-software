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
            con = new ClasseConexao();
            dataset = new DataSet();
            String comando = "select NomeProduto from tblProdutos";
            dataset = con.retornarSQL(comando);
            GridView1.DataSource = dataset;
            GridView1.DataBind();
            Label1.Text = GridView1.Rows[0].Cells[0].Text;
            Label2.Text = GridView1.Rows[1].Cells[0].Text;
        }
    }
}