using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemaExemplo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

    }
}
