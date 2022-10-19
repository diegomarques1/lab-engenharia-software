using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChurras
{
    public class Pedido
    {
        public static int qntdProdutos = 0;
        private static Node first, last;
        private static Cliente cliente;
        private static float preco = 0;
        public Pedido()
        {
            cliente = new Cliente();
        }
        public void adicionarProduto(Produto produto)
        {
            Node node;
            if (isEmpty())
            {
                node = new Node();
                node.setProduto(produto);
                first = node;
                last = node;
                qntdProdutos++;
            }
            else
            {
                if ((node = buscarNode(produto)) != null){
                    node.adicionarUnidade();
                }
                else
                {
                    node = new Node();
                    node.setProduto(produto);
                    last.setProx(node);
                    node.setAnterior(last);
                    qntdProdutos++;
                }
            }
            preco += produto.getPrecoProduto();
        }

        public void removerProduto(Produto produto)
        {
            Node node;
            if (!isEmpty())
            {
                node = buscarNode(buscarProduto(produto.getNomeProduto()));
                if(node.getQuantidade() > 1)
                {
                    node.removerUnidade();
                }
                else
                {
                    if (node.getProx() != null)
                    {
                        node.getProx().setAnterior(node.getAnterior());
                    }
                    if (node.getAnterior() != null)
                    {
                        node.getAnterior().setProx(node.getProx());
                    }
                    qntdProdutos--;
                }                
                preco -= produto.getPrecoProduto();
            }
        }
        public Produto buscarProduto(int indice)
        {
            if (indice > qntdProdutos)
            {
                return null;
            }
            Node noAux = first;
            for (int i = 0; i < indice && i < qntdProdutos && noAux.getProx() != null; i++)
            {
                noAux = noAux.getProx();
            }
            return noAux.getProduto();
        }
        public Produto buscarProduto(string nomeProduto)
        {
            Node noAux = first;
            while (!noAux.getProduto().getNomeProduto().Equals(nomeProduto) && noAux != null)
            {
                noAux = noAux.getProx();
            }
            if (noAux == null)
            {
                return null;
            }
            return noAux.getProduto();
        }
        public Node buscarNode(Produto produto)
        {
            if (isEmpty())
            {
                return null;
            }
            Node noAux = first;
            while (noAux != null && noAux.getProduto().getNomeProduto() != produto.getNomeProduto())
            {
                noAux = noAux.getProx();
            }
            if (noAux == null)
            {
                return null;
            }
            return noAux;
        }
        public int Count()
        {
            return qntdProdutos;
        }
        public bool isEmpty()
        {
            if (qntdProdutos == 0)
            {
                return true;
            }
            return false;
        }
        public float getPreco()
        {
            return preco;
        }
    }
}