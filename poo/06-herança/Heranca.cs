using System;

public class Veiculo
{
    private bool ligado;
    public int velMax;
    public int rodas;
    
    public void ligar()
    {
       ligado=true;
    }
    public void desligar()
    {
       ligado=false;
    }
    public string getLigado(){
        if(ligado)
        {
            return "Sim";
        } else 
        {
            return "Não";
        }
    }
    
}

class Carro : Veiculo {
    public string nome;
    public string cor;
    public Carro(string nome, string cor)
    {
        ligar();
        rodas = 4;
        velMax= 120;
        this.nome = nome;
        this.cor = cor;
        info();
    }
    public void info()
    {
        Console.WriteLine("Nome: ........... {0}", nome);
        Console.WriteLine("Cor: ............ {0}", cor);
        Console.WriteLine("Vel. Maxima: .... {0}km", velMax);
        Console.WriteLine("Ligado? ......... {0}", getLigado());
        Console.WriteLine();
    }
}
public class Heranca
{
    static void Main()
    {
 
        Carro c1 = new Carro("Mustangue", "Vermelho");
        Carro c2 = new Carro("Ferrari", "Preto");

    }
}


