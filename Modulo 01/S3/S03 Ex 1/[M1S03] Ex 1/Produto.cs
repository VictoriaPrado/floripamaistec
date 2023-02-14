using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S03__Ex_1
{
    public class Produto
    {
        public string nome;
        public double preço;
        public int quantidade;

        public Produto(string nome, double preço, int quantidade)
        {
            this.nome = nome;
            this.preço = preço;
            this.quantidade = quantidade;
        }

        public Produto()
        {
            nome = "Sem nome";
            preço = 0;
            quantidade = 0;
        }
    }
}
