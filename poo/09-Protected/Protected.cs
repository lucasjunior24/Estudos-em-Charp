using System;

class Veiculo
{
    private int velMax;
    public int velAtual;
    protected bool ligado;

    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = true;
    }
    public bool getLigado()
    {
        return ligado;
    }
    public int getVelMax()
    {
        return velMax;
    }
}

class Carro : Veiculo
{
    public string nome;
    public Carro(string nome, int vm) : base(vm)
    {
        this.nome = nome;
        ligado = false;
    }

}

public class Protected
{
    static void Main()
    {
        
        Carro c1 = new Carro("Bonitao", 120);

        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Vel. Maxima: {0}", c1.getVelMax());
        Console.WriteLine("Ligado?: {0}", c1.getLigado());
    }
    
}



