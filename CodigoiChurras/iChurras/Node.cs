using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iChurras
{
    public class Node
    {
        private Produto produto;
        private Node prox;
        private Node anterior;

        public Node()
        {
            produto = null;
            prox = null;
            anterior = null;
        }
        public Produto getProduto()
        {
            return produto;
        }
        public void setProduto(Produto prod)
        {
            produto = prod;
        }
        public Node getProx()
        {
            return prox;
        }
        public void setProx(Node node)
        {
            prox = node;
        }
        public Node getAnterior()
        {
            return anterior;
        }
        public void setAnterior(Node ant)
        {
            anterior = ant;
        }
    }
}