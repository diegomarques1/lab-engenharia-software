using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChurras
{
    
    public class Cliente
    {
        private static int codCliente;
        private static String nomeCliente, loginCliente, senhaCliente, emailCliente, telefoneCliente;
        public void setCodCliente(int codigo)
        {
            codCliente = codigo;
        }
        public int getCodCliente()
        {
            return codCliente;
        }
        public void setNome(String nome)
        {
            nomeCliente = nome;
        }
        public String getNome()
        {
            return nomeCliente;
        }
        public void setLoginCliente(String login)
        {
            loginCliente = login;
        }
        public String getLoginCliente()
        {
            return loginCliente;
        }
        public void setSenha(String senha)
        {
            senhaCliente = senha;
        }
        public String getSenha()
        {
            return senhaCliente;
        }
        public void setEmail(String email)
        {
            emailCliente = email;
        }
        public String getEmail()
        {
            return emailCliente;
        }
        public void setTelefone(String telefone)
        {
            telefoneCliente = telefone;
        }
        public String getTelefone()
        {
            return telefoneCliente;
        }
    }
}