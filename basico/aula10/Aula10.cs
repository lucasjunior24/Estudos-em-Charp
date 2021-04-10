using System;

class Aula10
{
    enum DiasSemana
    {
        Domingo, Segunda, Terca, Quarta, Quinta
    };
    static void Main()
    {
        DiasSemana ds = DiasSemana.Domingo;
        DiasSemana d3 = (DiasSemana)3;
        DiasSemana d0 = (DiasSemana)0;

        int d1 = (int)DiasSemana.Segunda;

        Console.WriteLine(ds);
        Console.WriteLine(d0); // Domingo
        Console.WriteLine(d3); // Quarta

        Console.WriteLine(d1); // index de Segunda
    }
}