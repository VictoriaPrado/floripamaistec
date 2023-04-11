using M1S02.DadosBancarios;
using M1S02.DadosBancarios.Enum;

ContaBancaria conta = new ContaBancaria();
conta.numero = 1234;
conta.agencia = 5678;
conta.nomeDoTitular = "Victoria Prado";
conta.tipoConta = TipoContaEnum.POUPANCA;

// testando método depositar
conta.Depositar(200);

// testando método sacar 
conta.Sacar(50);

// testando método exibir saldo
conta.ExibirSaldo();
