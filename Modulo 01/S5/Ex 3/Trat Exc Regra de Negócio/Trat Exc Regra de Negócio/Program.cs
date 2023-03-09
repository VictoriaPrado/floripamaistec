using Trat_Exc_Regra_de_Negócio;

Evento evento = new Evento();

evento.QuantidadeIngressosVendidos = 15;
evento.QuantidadeLugares = 10;

if (evento.QuantidadeLugares - evento.QuantidadeIngressosVendidos > 0)
{
    Console.WriteLine("Ingresso validado");
    evento.ingressoVendido();
}
else
{
    throw new IngressoException("Não existem mais lugares dispóníveis para o evento");
}
