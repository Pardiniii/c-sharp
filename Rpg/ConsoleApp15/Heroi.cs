using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public abstract class Heroi : Personagem
    {
        public Heroi(int hp, int ataque, int defesa, int forca, int agilidade, int sorte) : 
            base(hp, ataque, defesa, forca, agilidade, sorte)
        {
        }

        public abstract double ObterTesouro();
    }
}
