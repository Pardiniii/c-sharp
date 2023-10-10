
using System.Runtime.CompilerServices;

public class Aluno
{
    int matricula;
    public string nome;
    string nomeDisciplina;
    double notaProva1;
    double notaProva2;
    double notaTrabalho;

    public Aluno(int matricula, string nome, string nomeDisciplina, double notaProva1, double notaProva2, double notaTrabalho)
    {
        this.matricula = matricula;
        this.nome = nome;
        this.nomeDisciplina = nomeDisciplina;
        this.notaProva1 = notaProva1;
        this.notaProva2 = notaProva2;
        this.notaTrabalho = notaTrabalho;
    }

    public double calcularMedia()
    {
        double media = ((this.notaProva1 * 3.5) + (this.notaProva2 * 3.5) + (this.notaTrabalho * 3)) / 10;
        return media;
    }

    public bool estaAprovado()
    {
        double media = this.calcularMedia();

        if (media >= 6) return true;
        return false;
    }
}
