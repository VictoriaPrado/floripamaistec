using M1S02.DadosBancarios.Enum;

namespace M1S02.DadosBancarios
{
    public class ContaBancaria
        // Exercício 3
    {
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0; 
        public TipoContaEnum tipoConta;

        // Resposta Exercício 04
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
            }
            else
            {
                saldo = saldo + valor;
            }
        }

        // Resposta Exercício 05
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");

            }
            else if (valor > saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");

            }
            else
            {
                saldo = saldo - valor;
            }
        }

        // Resposta Exercício 06
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {saldo}");
        }
    }
}
