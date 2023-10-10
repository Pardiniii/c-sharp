using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Mago : Heroi
    {
        int mana;

        public Mago(int hp, int mana, int ataque, int defesa, int forca, int agilidade, int sorte) : 
            base(hp, ataque, defesa, forca, agilidade, sorte)
        {
            this.mana = mana;
        }

        public override void Atacar(Personagem personagem)
        {
            if(this.mana > 0)
            {
                personagem.ReceberAtaque(this.Ataque * 2);
                if (personagem.HP <= 0)
                {
                    this.AdicionarContadorMorto();
                }
            } else
            {
                throw new Exception("Mago não mana o suficiente");
            }
        }

        public void Atacar(List<Personagem> personagens)
        {
            if (this.mana > 0)
            {
                foreach (Personagem personagem in personagens)
                {
                    personagem.ReceberAtaque(this.Ataque / personagens.Count);
                    if(personagem.HP <= 0)
                    {
                        this.AdicionarContadorMorto();
                    }
                }                
            }
            else
            {
                throw new Exception("Mago não mana o suficiente");
            }

        }

        public override double ObterTesouro()
        {
            int numeroSorte = new Random().Next(0, this.Sorte);
            return (this.Inteligencia + numeroSorte) * this.ContadorMortos;
        }
    }
}
