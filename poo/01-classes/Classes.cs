using System;

public class Classes
{
    static void Main()
    {
        
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;

        Console.WriteLine("Energia do jogador 1: {0}%", j1.energia);
    }
    
}

public class Jogador
{
    public int energia = 100;
    public bool vivo = true;
}


