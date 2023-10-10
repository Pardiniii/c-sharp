using ConsoleApp15;

Monstro monstro = new Monstro(50, 50, 20, 5, 5);
Guerreiro guerreiro = new Guerreiro(40, 70, 30, 80, 10, 2);
Mago mago = new Mago(30, 100, 20, 30, 10, 20, 10);
Arqueiro arqueiro = new Arqueiro(10, 20, 30, 40, 60, 40);

List<Monstro> monstros = new List<Monstro>
{
    monstro
};

List<Heroi> herois = new List<Heroi>
{
    guerreiro, mago, arqueiro
};

ControladorPersonagem controlador = new ControladorPersonagem(herois, monstros);

controlador.ExecutarTurno();
controlador.ExecutarTurno();
controlador.ExecutarTurno();
controlador.ExecutarTurno();
controlador.ExecutarTurno();
controlador.ExecutarTurno();