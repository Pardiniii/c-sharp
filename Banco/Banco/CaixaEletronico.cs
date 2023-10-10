
using System.Drawing;

public class CaixaEletronico
{
    string extrato;

    public bool Sacar(Pessoa pessoa, double valor)
    {
        if(pessoa.conta.ObterSaldo() >= valor)
        {
            pessoa.conta.RemoverSaldo(valor);
            Console.WriteLine($"Foi removido da conta de {pessoa.nome} R$ {valor}");

            extrato += "Foi sacado R$ " + valor + "\n";

            return true;
        } else
        {
            Console.WriteLine("Você não tem a qualidade de dinheiro para saque");
            return false;
        }
    }

    public bool Depositar(Pessoa pessoa, double valor)
    {
        if(valor > 0)
        {
            pessoa.conta.AdicionarSaldo(valor);
            Console.WriteLine($"Foi adicionado na conta de {pessoa.nome} R$ {valor}");

            extrato += "Foi depositado R$ " + valor + "\n";

            return true;
        } else
        {
            Console.WriteLine("Não é possível adicionar valores negativos");

            return false;
        }        
    }

    public void Emprestimo(Pessoa pessoa1, Pessoa pessoa2, double valor)
    {
        bool deuCerto = this.Sacar(pessoa1, valor);
        if(deuCerto == true)
        {
            this.Depositar(pessoa2, valor);
        }
    }

    public void ChecarSaldo(Pessoa pessoa)
    {
        Console.WriteLine($"O saldo de {pessoa.nome} é R$ {pessoa.conta.ObterSaldo()}");
    }

    public void ImprimirExtrato()
    {
        Console.WriteLine(extrato);
    }
}