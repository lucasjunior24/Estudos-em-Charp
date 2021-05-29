using System;


class argumentoParams
{
    static void Main()
    {
        int v1, v2, r;

        Console.Write("Digite o primeiro numero: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        soma(v1, v2);
    }
    static void soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
    }
}
