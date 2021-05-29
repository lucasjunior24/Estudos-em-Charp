using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Constructor da classe Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Constructor da classe Derivada1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Constructor da classe Derivada2");
    }
}

class OrdemExecucao
{
    static void Main()
    {
        Derivada2 derivada2 = new Derivada2();
    }
}