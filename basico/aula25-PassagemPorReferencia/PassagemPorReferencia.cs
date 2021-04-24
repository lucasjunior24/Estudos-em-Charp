using System;

class PassagemPorReferencia
{
    static void Main()
    {
        int num = 60;
        int n = 60;

        dobrarPorRef(ref num);
        Console.WriteLine(num);
        dobrarPorValor(n);
        Console.WriteLine(n);
        
    }
    static void dobrarPorRef(ref int v)
    {
        v*=2;
    }
    static void dobrarPorValor(int valor)
    {
        valor*=2;
    }

}