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
using System.Globalization;

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
                request.Key = "key";
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
                pedido.setFrete((float)(segundos * 0.007));
                pedido.setPrevisaoEntrega(DateTime.Now + t);
            }
            RadioButtonListEndereco.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                RadioButtonListEndereco.Items.Add(new ListItem(ds.Tables[0].Rows[i].ItemArray[0].ToString()));
            }
            RadioButtonListEndereco.SelectedIndex = 0;
            comando = "SELECT NumCartao FROM tblCartao where CodCliente = " + cliente.getCodCliente();
            ds = new DataSet();
            ds = con.retornarSQL(comando);
            RadioButtonListPagamento.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string a = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                RadioButtonListPagamento.Items.Add(new ListItem("XXXX-XXXX-XXXX-"+a.Substring(a.Length-4)));
            }
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

        protected void ButtonFinalizarPedido_Click(object sender, EventArgs e)
        {
            
            con = new ClasseConexao();
            pedido.setEstadoPedido(0);
            string endereco = RadioButtonListEndereco.SelectedValue;
            pedido.setEndereco(endereco);
            string dataPedido = DateTime.Now.ToString("yyyyMMdd HH:mm tt");
            string telefoneCliente = cliente.getTelefone();
            string codRecebimento = "" + telefoneCliente.ElementAt(telefoneCliente.Length - 3) + telefoneCliente.ElementAt(telefoneCliente.Length - 2) + telefoneCliente.ElementAt(telefoneCliente.Length - 1);
            pedido.setCodRecebimento(codRecebimento);
            string previsaoEntrega = (pedido.getPrevisaoEntrega()).ToString("yyyyMMdd HH:mm tt");
            string comandosql = "insert into tblPedidos(estadoPedido,preco,dataPedido,taxaEntrega,codRecebimento,previsaoEntrega,CodCliente,endereco) values ("+0+","+pedido.getPreco().ToString(CultureInfo.InvariantCulture) +",'"+dataPedido+"',"+pedido.getFrete().ToString(CultureInfo.InvariantCulture) +",'"+codRecebimento+"','"+previsaoEntrega+"',"+cliente.getCodCliente()+",'"+endereco+"')";
            con.executarSQL(comandosql);
            int codPedido = (int)con.ValorSQL("select CodPedido from tblPedidos where CodCliente = " + cliente.getCodCliente() + " order by dataPedido DESC");
            pedido.setCodPedido(codPedido);           
            Produto produto;
            for (int i = 0; i< pedido.Count(); i++)
            {
                produto = pedido.buscarProduto(i);
                comandosql = "insert into tblPedidos_Produtos values (" + codPedido + "," + produto.getCodProduto() + "," + pedido.buscarNode(produto).getQuantidade() + ")";
                con.executarSQL(comandosql);
            }
            HttpContext.Current.Response.Redirect("AcompanhamentoPedido.aspx");
        }

        protected void ButtonVoltarMenu_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("Home.aspx");
        }

        protected void ButtonCadastrarCartao_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("CadastrarCartao.aspx");
        }
    }
}