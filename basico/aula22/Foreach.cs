using System;
class Foreach
{
    static void Main()
    {
        int [] num = new int [3]{11,22,33};

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine(num[i]);
        }

        foreach (var n in num)
        {
            Console.WriteLine(n);
        }
    }
}