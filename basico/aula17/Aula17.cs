using System;

class Aula17
{
    static void Main()
    {
        // int n1, n2, n3, n4;
        int [] n = new int[4];

        // int [] num = new int [3]{31,32,33};
        int [] num = {21,22,23,24};
        string [] carros = {"Opala", "Mercedes", "Ferrari"};


        n[0] = 111;
        n[1] = 222;
        n[2] = 333;

        Console.WriteLine(n[0]); 
        // Console.WriteLine(num[2]); 
        Console.WriteLine(num[3]); 
        Console.WriteLine(carros[2]); 

    }
}