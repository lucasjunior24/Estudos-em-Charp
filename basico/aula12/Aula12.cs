using System;

class Aula12
{
    static void Main()
    {
        // int media = 0;
        // string res = "Reprovado";
        Console.Write("Digite sua primeira nota: ");
        int nota01 = int.Parse(Console.ReadLine());
        Console.Write("Digite sua segunda nota: ");
        int nota02 = int.Parse(Console.ReadLine());

        int media = (nota01 + nota02) / 2;

        if(media >= 7)
        {
            Console.WriteLine("Aprovado\nMedia: {0}", media);
        } else if (media >= 5)
        {
            Console.WriteLine("Recuperação\nMedia: {0}", media);
        }
        else if (media >= 3)
        {
            Console.WriteLine("Exame Final\nMedia: {0}", media);
        } else {
            Console.WriteLine("Reprovado\nMedia: {0}", media);
        }

        // Console.WriteLine("Resultado: {0}", res);
    }
}