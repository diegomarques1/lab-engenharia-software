using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class CadastrarCartao : System.Web.UI.Page
    {
        Cliente cliente;
        ClasseConexao con;
        protected void Page_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
        }

        protected void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (TextBoxNumCartao.Text != null && TextBoxValidade.Text != null && TextBoxNumSeguranca.Text != null && TextBoxNome.Text != null)
            {
                try
                {
                    con = new ClasseConexao();
                    string comando = "INSERT INTO tblCartao values ('" + TextBoxNumCartao.Text + "', '"+TextBoxNome.Text + "', '" + TextBoxNumSeguranca.Text + "', '" + TextBoxValidade.Text +"', " + cliente.getCodCliente() + ")";
                    con.executarSQL(comando);
                    LabelResposta.Text = "Cartão cadastrado com sucesso!";

                }
                catch(Exception erro)
                {
                    LabelResposta.Text = "Erro: "+erro.Message;
                }
            }
            else
            {
                LabelResposta.Text = "Preencha todos os campos.";
            }
        }
    }
}