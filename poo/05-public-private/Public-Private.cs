using System;

public class Jogador
{
    private int energia;
    private string nome;
    public Jogador(string nome)
    {
        energia = 100;
        this.nome = nome;
    }
    public int getEnergia()
    {
        return energia;
    }
    public string getNome()
    {
        return nome;
    }

    public void setEnergia(int e)
    {
        if(e<0)
        {
            if(energia + e < 0)
            {
                energia = 0;
            } else 
            {
                energia += e;
            }
        } else if(e>0) 
        {
            if(energia + e > 100)
            {
                energia = 100;
            } else 
            {
                energia += e;
            }
        }
    }


}
public class ClassStatic
{
    static void Main()
    {
 
        Jogador j1 = new Jogador("Bruno");
        j1.setEnergia(-150);
        
        Console.WriteLine("Nome do Inimigo: {0}", j1.getNome());
        Console.WriteLine("Eneria: {0}", j1.getEnergia());
        Console.WriteLine();
        
    }
}


