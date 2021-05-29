using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
}

public class Construtores
{
    static void Main()
    {
        Console.Write("Digite o nome do jogador 1: ");
        string nome = Console.ReadLine();
        Jogador j1 = new Jogador(nome);
        Jogador j2 = new Jogador("Luan");
        // Jogador j3 = new Jogador();

        j1.energia = 50;

        Console.WriteLine("Nome do jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do jogador 2: {0}", j2.nome);

        // Console.WriteLine("Energia do jogador 1: {0}%", j1.energia);
    }
    
}


