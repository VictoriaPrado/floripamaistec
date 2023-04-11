using _M1S03__Ex_2;

Produto produto1 = new Produto();

produto1.nome = "calculadora";
produto1.verificarEstoque();
Console.WriteLine("O nome de produto é: " + produto1.nome);

Console.WriteLine("----- Abaixo será valores e ações de uma classe filha")
// instanciar objeto de protudo financeiro:
ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();

classeFilha.nome = "Produto Financeiro";
classeFilha.verificarEstoque();
