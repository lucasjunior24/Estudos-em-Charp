using System;

class Matrizes
{
    static void Main()
    {
        int [,] n = new int [3,5];
        int [,] num = new int [2,2]{{10,20}, {30,40}};
        // 3 linhas e 5 colunas

        n[0,0] = 111;
        n[0,1] = 222;
        n[0,2] = 333;
        n[0,3] = 444;
        n[0,4] = 555;

        n[1,0] = 11;
        n[1,1] = 22;
        n[1,2] = 33;
        n[1,3] = 44;
        n[1,4] = 55;

        n[2,0] = 1;
        n[2,1] = 2;
        n[2,2] = 3;
        n[2,3] = 4;
        n[2,4] = 5;

        Console.WriteLine(n[0,0]);
        Console.WriteLine(num[1,1]);
    }
}