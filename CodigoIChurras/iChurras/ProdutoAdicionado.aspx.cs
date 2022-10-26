using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class ProdutoAdicionado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonResumo_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("Home.aspx");
        }

        protected void ButtonVoltar_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("PedidoResumo.aspx");
        }
    }
}