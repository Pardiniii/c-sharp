using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Guerreiro : Heroi
    {
        public Guerreiro(int hp, int ataque, int defesa, int forca, int agilidade, int sorte) : base(hp, ataque, defesa, forca, agilidade, sorte)
        {
        }

        public override void Atacar(Personagem personagem)
        {
            personagem.ReceberAtaque(this.Ataque);
            personagem.ReceberAtaque(this.Ataque);
            if (personagem.HP <= 0)
            {
                this.AdicionarContadorMorto();
            }
        }

        public override double ObterTesouro()
        {
            int numeroSorte = new Random().Next(0, this.Sorte);
            return (this.Forca + numeroSorte) * this.ContadorMortos;
        }
    }
}
