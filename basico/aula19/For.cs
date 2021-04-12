using System;

class For
{
    static void Main()
    {
        // for (int i = 0; i < 10; i++) // Para
        // {
        //     Console.WriteLine("Valor: {0}", i+1);
        // }
        // int [] num = new int [10];

        // for (int i = 0; i < num.Length; i++)
        // {
        //     Console.WriteLine("Num na posicao {0}: {1}", i, num[i]);
        // }

        int i = 0;
        while (i<10)
        {
            Console.WriteLine("Oi, {0}", i);
            i++;
        }
    }
}