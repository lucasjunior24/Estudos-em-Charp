using System;

class argumentoOut
{
    static void Main()
    {
        int diviv, divis, res, quoc;
        diviv = 10;
        divis = 3;
        quoc = divite(diviv, divis, out res);
        Console.WriteLine("{0}/{1}: quociente = {2} e resto = {3}", diviv, divis, quoc, res);
    }
    static int divite(int dividendo, int divisor, out int resto)
    {
        int quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }
}