using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChurras
{
    public class Produto
    {
        private int codProduto, tipoProduto;
        private float precoUnidade;
        private String nomeProduto, descricaoProduto;
        public void setCodProduto(int codigo)
        {
            codProduto = codigo;
        }
        public int getCodProduto()
        {
            return codProduto;
        }
        public void setNomeProduto(String nome)
        {
            nomeProduto = nome;
        }
        public String getNomeProduto()
        {
            return nomeProduto;
        }
        public void setPrecoUnidade(float preco)
        {
            precoUnidade = preco;
        }
        public float getPrecoProduto()
        {
            return precoUnidade;
        }
        public void setDescricaoProduto(String escricao)
        {
            descricaoProduto = escricao;
        }
        public String getDescricaoProduto()
        {
            return descricaoProduto;
        }
        public void setTipoProduto(int tipo)
        {
            tipoProduto = tipo;
        }
        public int getTipoProduto()
        {
            return tipoProduto;
        }
    }
}