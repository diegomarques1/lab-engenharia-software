using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iChurras
{
    public partial class Login : System.Web.UI.Page
    {
        ClasseConexao con;
        Cliente cliente;
        DataSet dataset;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConcluirLogin(object sender, EventArgs e)
        {
            if (TextBoxUser.Text == null || TextBoxSenha.Text == null)
            {
                LabelResposta.Text = "Insira todas as informações.";
            }
            else
            {
                cliente = new Cliente();
                String comando = "EXEC usp_aspLogin '" + TextBoxUser.Text + "', '" + TextBoxSenha.Text + "'";
                con = new ClasseConexao();
                dataset = new DataSet();
                dataset = con.retornarSQL(comando);
                GridView1.DataSource = dataset;
                GridView1.DataBind();
                if (GridView1.Rows[0].Cells[0].Text == "false")
                {
                    LabelResposta.Text = "Usuário ou senha estão incorretos.";
                }
                else
                {
                    cliente.setCodCliente(Convert.ToInt32(GridView1.Rows[0].Cells[0].Text));
                    cliente.setNome(GridView1.Rows[0].Cells[1].Text.ToString());
                    cliente.setEmail(GridView1.Rows[0].Cells[2].Text.ToString());
                    cliente.setTelefone(GridView1.Rows[0].Cells[3].Text.ToString());
                    cliente.logar();
                }
            }
        }
    }
}