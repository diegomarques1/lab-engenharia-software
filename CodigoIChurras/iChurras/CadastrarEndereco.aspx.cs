using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class CadastrarEndereco : System.Web.UI.Page
    {
        Cliente cliente;
        ClasseConexao con;
        protected void Page_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
        }

        protected void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (TextBoxEndereco.Text != null)
            {
                try
                {
                    con = new ClasseConexao();
                    string comando = "INSERT INTO tblEndereco values ('" + TextBoxEndereco.Text + "', " + cliente.getCodCliente() + ")";
                    con.executarSQL(comando);
                    LabelResposta.Text = "Endereco cadastrado com sucesso!";

                }
                catch(Exception erro)
                {
                    LabelResposta.Text = "Erro: "+erro.Message;
                }
            }
            else
            {
                LabelResposta.Text = "Insira um endereço.";
            }
        }
    }
}