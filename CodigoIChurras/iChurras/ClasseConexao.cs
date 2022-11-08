using System;
using System.Data;
using System.Data.SqlClient;

namespace iChurras
{
    class ClasseConexao
    {

        SqlConnection conexao = new SqlConnection();

        private SqlConnection conectar()
        {
            try
            {
                String strConexao = "Persist Security Info=True; Integrated Security = SSPI; Initial Catalog=iChurras; Data Source=" + Environment.MachineName;
                conexao.ConnectionString = strConexao;
                conexao.Open();
                return conexao;
            }
            catch (Exception erro)
            {
                desconectar();
                return null;
            }
        }

        public void desconectar()
        {
            try
            {
                if ((conexao.State == ConnectionState.Open))
                {
                    conexao.Close();
                    conexao.Dispose();
                }
            }
            catch (Exception erro) { }
        }

        public DataSet retornarSQL(String comando_sql)
        {
            try
            {
                conectar();
                SqlDataAdapter adaptador = new SqlDataAdapter(comando_sql, conexao);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                return ds;
            }
            catch (Exception erro)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public object ValorSQL(String comando_sql)
        {
            try
            {
                SqlCommand lSqlCommand = new SqlCommand(comando_sql, conexao);
                conectar();
                lSqlCommand.CommandText = comando_sql;             
                object result = lSqlCommand.ExecuteScalar();
                return result;
            }
            catch (Exception erro)
            {
                return null;
            }
            finally
            {
                desconectar();
            }
        }
        public void executarSQL(String comando_sql)
        {
            try
            {
                conectar();
                SqlCommand comand = new SqlCommand(comando_sql, conexao);
                comand.ExecuteNonQuery();
            }
            catch (Exception erro)
            { 

            }
            finally
            {
                desconectar();
            }
        }
    }
}
