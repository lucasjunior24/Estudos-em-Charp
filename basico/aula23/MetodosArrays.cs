using System;

class  MetodosArrays
{
    static void Main()
    {
        int [] vetor1 = new int[5]; 
        int [] vetor2 = new int[5]; 
        int [] vetor3 = new int[5]; 
        int [,] matriz = new int[2,5]{{11,22,01,44,55},{66,77,88,99,22}};

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach (var n in vetor1)
        {
            Console.Write("{0} ", n);
        }
        Console.WriteLine("");
        Console.WriteLine("");

        // public static void int BinarySearch(array, valor);
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine("Valor {0} esta na Posicao {1}", procurado, pos);

        Console.WriteLine("");

        // public static void int Copy(array_Origem, Array_Destino, qtd_elemntos);
        Console.WriteLine("Copy");
        // vetor2 recee elementos do vetor
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (var n in vetor2)
        {
            Console.Write("{0} ", n);
        }

        Console.WriteLine(" ");
        Console.WriteLine("");
        
        // public void CopyTo(Array_Destino, a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        // vetor2 recee elementos do vetor
        vetor1.CopyTo(vetor3, 0);
        foreach (var n in vetor3)
        {
            Console.Write("{0} ", n);
        }
        
        Console.WriteLine("");
        Console.WriteLine("");
        
        // public int GetLowerBound(dimenção);
        Console.WriteLine("GetLongLength");
        // retorna a quantidade de elemtos de um array
        long qtd_elemntosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtd_elemntosVetor);

        Console.WriteLine("");
        
        // public int GetLowerBound(Array_Destino, a_partir_desta_pos);
        Console.WriteLine("GetLowerBound");
        // retorna o menor indice de m arrau ou vetor
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor1 é: {0}", MenorIndiceVetor);
        Console.WriteLine("Menor indice da matriz é: {0}", MenorIndiceMatriz);
        Console.WriteLine("");
        
        // public int GetLowerBound(Array_Destino, a_partir_desta_pos);
        Console.WriteLine("GetUpperBound");
        // retorna o maior indice da arrau ou matriz
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz = matriz.GetUpperBound(0);
        Console.WriteLine("Maior indice do vetor1 é: {0}", MaiorIndiceVetor);
        Console.WriteLine("Maior indice da matriz é: {0}", MaiorIndiceMatriz);
    }
   
}