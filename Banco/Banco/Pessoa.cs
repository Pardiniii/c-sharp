
public class Pessoa
{
    public string nome;
    public Conta conta;

    public Pessoa(string nome)
    {
        this.nome = nome;
        conta = new Conta();
    }
}