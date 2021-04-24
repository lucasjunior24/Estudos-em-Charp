using System;

class Metodos
{
    static void Main()
    {
        // for (int i = 0 ; i < 10; i++)
        // {
        //     olaLucas();
        // }
        int v1, v2, r;

        Console.Write("Digite o primeiro numero: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        v2 = Convert.ToInt32(Console.ReadLine());

        // soma(v1, v2);

        // retorno do metodo salvo na variavel r
        r = somaComRetorno(v1, v2);
        Console.WriteLine("A soma de {0} e {1} é: {2}", v1, v2, r);
    }
    static void olaLucas()
    {
        Console.WriteLine("ola Lucas");
    }
    // void sem reterno
    static void soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
    }
    // retorna um enteiro
    static int somaComRetorno(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }
}