using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using GoogleApi.Entities.Common;
using GoogleApi.Entities.Maps.Directions.Request;
using GoogleApi.Entities.Maps.Directions.Response;
using GoogleApi.Entities.Maps.Common;
using System.Data;

namespace iChurras
{
    public partial class PedidoResumo : System.Web.UI.Page
    {
        ClasseConexao con;
        Cliente cliente;
        Pedido pedido;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            int segundos;
            cliente = new Cliente();
            pedido = new Pedido();
            con = new ClasseConexao();
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
            LabelPrecoProdutos.Text = "Total dos produtos: R$ " + pedido.getPreco();

            string comando = "SELECT endereco FROM tblEndereco where CodCliente = " + cliente.getCodCliente();

            ds = new DataSet();
            ds = con.retornarSQL(comando);
            if (RadioButtonListEndereco.Items.Count != 0)
            {
                DirectionsRequest request = new DirectionsRequest();
                request.Key = "AIzaSyAmzqwp9ceYAUTA7MLaS7s8PQWthABxurU";
                request.Origin = new LocationEx(new Address("R. da Consolação, 1272"));
                request.Destination = new LocationEx(new Address(RadioButtonListEndereco.SelectedValue));
                request.TravelMode = GoogleApi.Entities.Maps.Common.Enums.TravelMode.Bicycling;
                DirectionsResponse response = GoogleApi.GoogleMaps.Directions.Query(request);
                segundos = response.Routes.First().Legs.First().Duration.Value + 900;
                TimeSpan t = TimeSpan.FromSeconds(segundos);
                string answer;
                if (t.Hours != 0)
                {
                    answer = string.Format("{0}horas e {1:D2}minutos", t.Hours, t.Minutes);
                }
                else
                {
                    answer = string.Format("{0:D2}minutos", t.Minutes);
                }
                LabelTempo.Text = answer;
                LabelPrecoFrete.Text = "Frete: R$ " + segundos * 0.007;
                LabelPrecoTotal.Text = "Total: R$ " + (pedido.getPreco() + (segundos * 0.007));
                LabelPrecoTotal.Visible = true;
            }
            RadioButtonListEndereco.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                RadioButtonListEndereco.Items.Add(new ListItem(ds.Tables[0].Rows[i].ItemArray[0].ToString()));
            }
            RadioButtonListEndereco.SelectedIndex = 0;
        }
        protected void BotaoRemove_Click(object sender, EventArgs e)
        {
            Produto produto = pedido.buscarProduto(((Button)sender).ID);
            pedido.removerProduto(produto);
            Server.TransferRequest(Request.Url.AbsolutePath, false);
        }

        protected void ButtonCadastrarNovoEndereco_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("CadastrarEndereco.aspx");
        }
        protected void ButtonCalcularFrete_Click(object sender, EventArgs e)
        {
            
        }
    }
}