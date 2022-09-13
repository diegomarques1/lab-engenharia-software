using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class Cadastro : System.Web.UI.Page
    {
        ClasseConexao con;
        Cliente cliente;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (TextBoxNome.Text != null || TextBoxEmail.Text != null || TextBoxSenha.Text != null || TextBoxSenha2.Text != null || TextBoxTelefone.Text != null)
            {
                String comando = "Insert into tblClientes values ('" + TextBoxNome.Text + "','" + TextBoxEmail.Text + "','" + TextBoxSenha.Text + "','" + TextBoxTelefone.Text + "')";
                con = new ClasseConexao();
                cliente = new Cliente();
                con.executarSQL(comando);
                cliente.setNome(TextBoxNome.Text);
                cliente.setEmail(TextBoxEmail.Text);
                cliente.setSenha(TextBoxSenha.Text);
                cliente.setTelefone(TextBoxTelefone.Text);

            }
            else
            {
                LabelResposta.Text = "Preencha todos os campos.";
            }
        }
    }
}