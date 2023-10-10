public class Conta
{
    double saldo;

    public Conta()
    {
        this.saldo = 0;
    }

    public void AdicionarSaldo(double valor)
    {
        this.saldo += valor;
    }

    public void RemoverSaldo(double valor)
    {
        this.saldo -= valor;
    }

    public double ObterSaldo()
    {
        return saldo;
    }
}
