using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class ControladorPersonagem
    {
        List<Heroi> herois;
        List<Monstro> monstros;

        public ControladorPersonagem(List<Heroi> herois, List<Monstro> monstro)
        {
            this.herois = herois;
            this.monstros = monstro;
        }

        public void ExecutarTurno()
        {
            foreach(Personagem personagem in herois)
            {
                int indexAleatorio = new Random().Next(0, monstros.Count);
                Personagem personagemSofrido = monstros[indexAleatorio];

                personagem.Atacar(personagemSofrido);
            }

            foreach (Personagem personagem in monstros)
            {
                int indexAleatorio = new Random().Next(0, herois.Count);
                Personagem personagemSofrido = herois[indexAleatorio];

                personagem.Atacar(personagemSofrido);
            }
        }
    }
}
