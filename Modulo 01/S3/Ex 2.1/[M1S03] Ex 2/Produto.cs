using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _M1S03__Ex_2
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso, preco;
        public Produto(string nome, string cor)

        {
            this.nome = nome;
            this.cor = cor;
        }

        public Produto()
        {
        }

        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acessando o método vender da classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }

        protected void alteraAtributosPrivados(double peso, double preco)
        {
            peso = this.peso;
            Console.WriteLine("variável peso de escopo da classe: " + peso);
        }
}
