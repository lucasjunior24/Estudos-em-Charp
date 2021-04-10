using System;

class Aula06
{
    static void Main()
    {
        // int n1, n2, n3;
        // n1 = 10;
        // n2 = 20;
        // n3 = 30;
        // Console.WriteLine("n1=\t{0}\nn2=\t{1}\nn3=\t{2}", n1, n2, n3);

        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto.....:{0,15}", produto);
        Console.WriteLine("Valor.......:{0,15:c}", valorCompra); // reais
        Console.WriteLine("Lucro.......:{0,15:p}", lucro); // porcentagem
        Console.WriteLine("Val.Venda...:{0,15:c}", valorVenda);
    }

}