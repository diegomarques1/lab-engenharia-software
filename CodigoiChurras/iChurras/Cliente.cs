using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChurras
{
    
    public class Cliente
    {
        private int codCliente;
        private String nome, loginCliente, senha, email, telefone;
        public void setCodCliente(int codCliente)
        {
            this.codCliente = codCliente;
        }
        public int getCodCliente()
        {
            return codCliente;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return nome;
        }
        public void setLoginCliente(String loginCliente)
        {
            this.loginCliente = loginCliente;
        }
        public String getLoginCliente()
        {
            return loginCliente;
        }
        public void setSenha(String senha)
        {
            this.senha = senha;
        }
        public String getSenha()
        {
            return senha;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return email;
        }
        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }
        public String getTelefone()
        {
            return telefone;
        }
    }
}