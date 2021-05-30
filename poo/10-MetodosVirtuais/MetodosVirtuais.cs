using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Constructor da classe Base");
    }
    virtual public void info() { }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Constructor da classe Derivada1");
    }
    override public void info()
    {
        Console.WriteLine("Derivada1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Constructor da classe Derivada2");
    }
    override public void info()
    {
        Console.WriteLine("Derivada 2");
    }
}

class MetodosVirtuais
{
    static void Main()
    {
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada1;
        Ref.info();
    }
}