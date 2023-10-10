CaixaEletronico caixa = new CaixaEletronico();

Pessoa pessoa = new Pessoa("João");

caixa.Depositar(pessoa, 200);
caixa.Sacar(pessoa, 100);
caixa.ChecarSaldo(pessoa);