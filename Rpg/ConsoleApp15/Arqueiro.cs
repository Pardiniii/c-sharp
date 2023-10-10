using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Arqueiro : Heroi
    {
        int quantidadeFlechas;

        public Arqueiro(int hp, int ataque, int defesa, int forca, int agilidade, int sorte) : base(hp, ataque, defesa, forca, agilidade, sorte)
        {
            this.quantidadeFlechas = 500;
        }

        public override void Atacar(Personagem personagem)
        {
            if(quantidadeFlechas > 0)
            {
                quantidadeFlechas--;
                personagem.ReceberAtaque(Ataque * 1.5);
                if (personagem.HP <= 0)
                {
                    this.AdicionarContadorMorto();
                }
            } else
            {
                throw new Exception("Arqueiro não tem flechas");
            }
        }

        public override double ObterTesouro()
        {
            int numeroSorte = new Random().Next(0, this.Sorte);
            return (this.Agilidade + numeroSorte) * this.ContadorMortos;
        }
    }
}
