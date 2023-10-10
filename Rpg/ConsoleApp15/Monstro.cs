using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class Monstro : Personagem
    {
        public Monstro(int ataque, int defesa, int forca, int agilidade, int sorte) : 
            base(50, ataque, defesa, forca, agilidade, sorte) {
        }

        public override void Atacar(Personagem personagem)
        {
            personagem.ReceberAtaque(this.Ataque);
        }
    }
}
