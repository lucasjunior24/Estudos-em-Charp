using System;

class Calculos
{
    public int v1;
    public int v2;
    public Calculos(int v1, int v2)
    {
        // this faz referencia ao objeto Calculos, sua class de origem
        this.v1 = v1;
        this.v2 = v2;
    }
    public int Somar()
    {
        return v1 + v2;
    }
}

public class This
{
    static void Main()
    {
 
        Calculos c = new Calculos(2, 6);

        Console.WriteLine(c.Somar());
        Console.WriteLine();
        
    }
}


