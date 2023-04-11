using _M1S04__Ex_1_ao_6.Enum;

Cliente pj = new Cliente("Victoria Prado", DateTime.Parse("1996-11-04"), "Especialista de Produto", EstadoCivil.Solteiro, TipoPessoa.Juridica);

ContaEmpresarial contaEmpresa = new ContaEmpresarial(1234, 26, pj, 9000, 8, 30639225000155);
contaEmpresa.FazerEmprestimo(2500.00M);             //teste para o limite de 30%
contaEmpresa.FazerEmprestimo(2000.00M);
contaEmpresa.Deposito(3000.00M);
contaEmpresa.ExibirSaldo();
contaEmpresa.PagarEmprestimo();
contaEmpresa.ExibirSaldo();


Cliente pf = new Cliente("Victoria Prado", DateTime.Parse("1996-11-04"), "Especialista de Produto", EstadoCivil.Solteiro, TipoPessoa.Fisica);

ContaCorrente contaCorrente = new ContaCorrente(1253, 25, pf);
contaCorrente.Deposito(350.00M);
contaCorrente.Saque(100.00M);
contaCorrente.ExibirSaldo();

ContaPoupanca contaPoupanca = new ContaPoupanca(1253, 25, pf);
contaPoupanca.Deposito(100.00M);
contaPoupanca.Transferencia(contaCorrente, 80.00M);
contaPoupanca.ExibirSaldo();
