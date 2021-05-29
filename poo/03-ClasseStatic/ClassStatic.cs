using System;

static public class Jogador
{
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true; 
        nome = n;
    }
    static public void info()
    {
        Console.WriteLine("Nome do jogador 1: {0}", nome);
        Console.WriteLine("Nome do jogador 2: {0}", energia);
        Console.WriteLine();
    }
}
class Inimigo
{
    static public bool alerta;
    public string nome;
    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }
    public void info()
    {
        Console.WriteLine("Nome do Inimigo: {0}", nome);
        Console.WriteLine("Tipo de alerta: {0}", alerta);
        Console.WriteLine();
    }
}

public class ClassStatic
{
    static void Main()
    {
 
        Jogador.iniciar("Lucas");
        Jogador.info();

        Inimigo n1 = new Inimigo("Coringa");
        Inimigo n2 = new Inimigo("Lex Luthor");
        Inimigo n3 = new Inimigo("Venon");

        Inimigo.alerta = true;
        n3.nome = "Pinguim";

        n1.info();
        n2.info();
        n3.info();
        
    }
}


