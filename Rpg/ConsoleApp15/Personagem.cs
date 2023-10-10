using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public abstract class Personagem
    {
        double hp;
        int ataque;
        int defesa;
        int forca;
        int agilidade;
        int sorte;
        int contadorMortos;

        public int Ataque {
            get
            {
                return ataque;
            }
        }

        public double HP
        {
            get { return hp; }
        }

        public int Forca {  get { return forca; } }
        public int Inteligencia { get { return Inteligencia; } }
        public int Agilidade { get { return agilidade; } }
        public int Sorte { get { return sorte; } }

        public int ContadorMortos
        {
            get { return contadorMortos; }
        }

        public Personagem(double hp, int ataque, int defesa, int forca, int agilidade, int sorte)
        {
            this.hp = hp;
            this.ataque = ataque;
            this.defesa = defesa;
            this.forca = forca;
            this.agilidade = agilidade;
            this.sorte = sorte;
        }

        public abstract void Atacar(Personagem personagem);

        public void ReceberAtaque(double dano)
        {
            this.hp = this.hp - dano;
        }

        public void AdicionarContadorMorto()
        {
            contadorMortos++;
        }
    }
}
