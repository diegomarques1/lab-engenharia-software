using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChurras
{
    public class ProdutoGeral
    {
        private static int codProduto, tipoProduto;
        private static float precoProduto;
        private static String nomeProduto, descricaoProduto;
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
        public void setPrecoProduto(float preco)
        {
            precoProduto = preco;
        }
        public float getPrecoProduto()
        {
            return precoProduto;
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