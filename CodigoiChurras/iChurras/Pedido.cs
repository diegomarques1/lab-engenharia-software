using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChurras
{
    public class Pedido
    {
        public static int qntdProdutos;
        private static Node first, last;
        private static Cliente cliente;
        public Pedido()
        {
            Cliente cl = new Cliente();
            cliente = cl;
        }
        public void adicionarProduto(Produto produto)
        {
            Node node = new Node();
            Node noAux;
            node.setProduto(produto);
            if (isEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                noAux = first;
                while (noAux.getProx() != null)
                {
                    noAux = noAux.getProx();
                }
                noAux.setProx(node);
                node.setAnterior(noAux);
            }
            qntdProdutos++;
        }
        public Produto buscarProduto(int indice)
        {
            Node noAux = first;
            for(int i = 0; i < indice && i < qntdProdutos && noAux.getProx() != null; i++)
            {
                noAux = noAux.getProx();
            }
            return noAux.getProduto();
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
    }
}