public class Elevador
{
    int andarAtual;
    int totalAndares;
    double capacidadePeso;
    bool portaAberta;
    double pesoAtual;

    public Elevador(int totalAndares, double capacidadePeso)
    {
        this.totalAndares = totalAndares;
        this.capacidadePeso = capacidadePeso;
    }

    public void Abrir()
    {
        portaAberta = true;
        Console.WriteLine("Porta foi aberta");
    }

    public void Fechar()
    {
        portaAberta = false;
        Console.WriteLine("Porta foi fechada");
    }

    public void AdicionarPessoa(Pessoa pessoa)
    {
        if(portaAberta == true)
        {
            pesoAtual += pessoa.peso;
            Console.WriteLine("Pessoa " + pessoa.nome + " entrou");
        } else
        {
            Console.WriteLine("Porta está fechada");
        }
    }

    public void RemoverPessoa(Pessoa pessoa)
    {
        if(portaAberta == true)
        {
            pesoAtual -= pessoa.peso;
            Console.WriteLine("Pessoa " + pessoa.nome + " saiu");
        } else
        {
            Console.WriteLine("Porta está fechada");
        }
    }

    public void Subir()
    {
        if(portaAberta == false && 
           pesoAtual <= capacidadePeso && 
           andarAtual < totalAndares)
        {
            andarAtual++;
            Console.WriteLine("Elevador subiu para andar " + andarAtual);
        } else
        {
            Console.WriteLine("Não foi possível subir de andar");
        }
    }

    public void Descer()
    {
        if (portaAberta == false &&
           pesoAtual <= capacidadePeso)
        {
            andarAtual--;
            Console.WriteLine("Elevador desceu para andar " + andarAtual);
        } else
        {
            Console.WriteLine("Não foi possível descer de andar");
        }
    }
}