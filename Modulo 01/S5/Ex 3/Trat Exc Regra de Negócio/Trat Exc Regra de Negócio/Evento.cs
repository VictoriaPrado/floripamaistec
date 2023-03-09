using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trat_Exc_Regra_de_Negócio
{
    internal class Evento
    {
        int quantidadeLugares;
        int quantidadeIngressosVendidos;

        public Evento()
        {
        }
        public int QuantidadeLugares { get; set; }
        public int QuantidadeIngressosVendidos { get; set; }

        public void ingressoVendido() 
        {
            Console.WriteLine("Ingresso vendido com sucesso");
        }
    }

}
