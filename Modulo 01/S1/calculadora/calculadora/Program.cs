// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Importação de bibliotecas

// Nome da classe

// Declaração método

// Declaração de variáveis
int opcao = 0, num1 = 0, num2 = 0;
float resultado = 0;

// Entradas
Console.WriteLine("Escolha uma operação: \n\n" +
    "1 - Soma\n2 - Subtração\n3 - Multriplicação\n4 - Divisão\n\n" +
    "5 - Sair\n\nDigite a opção escolhida: ");

opcao = int.Parse(Console.ReadLine());

// Processamento
switch (opcao)
{
    // bloco de instruções da estrutura condicional
    case 1:
        Console.WriteLine("Operação somar.");
        Console.Write("Digite o número 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número 2: ");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 + num2;
        break;
    case 2:
        Console.WriteLine("Operação subtração.");
        Console.Write("Digite o número 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número 2: ");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 - num2;
        break;
    case 3:
        Console.WriteLine("Operação multiplicação.");
        Console.Write("Digite o número 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número 2: ");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 * num2;
        break;
    case 4:
        Console.WriteLine("Operação divisão.");
        Console.Write("Digite o número 1: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o número 2: ");
        num2 = int.Parse(Console.ReadLine());
        resultado = num1 / num2;
        break;
    case 5:
        Console.WriteLine("Saindo do sistema.");
        break;
}

Console.WriteLine("Resultado da operação: " + resultado);

// Saídas