using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class PedidoResumo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            String texto = "";
            for(int i = 0; i < pedido.Count(); i++)
            {
                texto += (i+1)+"°: " + pedido.buscarProduto(i).getNomeProduto()+"\n - ";
            }
            Label1.Text = texto;
        }
    }
}