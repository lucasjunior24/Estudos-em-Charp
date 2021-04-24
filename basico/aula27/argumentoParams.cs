using System;

class argumentoParams
{
    static void Main()
    {
        
        soma(3, 4, 3, 4);
    }
    static void soma(params int []n)
    {
        int res = 0;
        if(n.Length < 1)
        {
            Console.WriteLine("Não existem valores a serem somados");
        } else if(n.Length < 2)
        {
            Console.WriteLine("Valores insuficiente para soma, o valor informado é: {0}", n[0]);
        } else {
            for (int i = 0; i < n.Length; i++)
            {
                res+=n[i];
            }
            Console.WriteLine("A soma dos valores é {0}", res);
        }
    }
}