using System;

class Veiculo
{
    private bool ligado;
    public int velMax;
    private int rodas;

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }

    public void ligar()
    {
       ligado=true;
    }
    public void desligar()
    {
       ligado=false;
    }
    public string getLigado(){
        return ligado ? "Sim" : "Não"; 
    }

    public int getRodas()
    {
        return rodas;
    }
    public int setRodas(int rodas)
    {
        if(rodas < 0)
        {
            this.rodas = 0;
        } 
        else if(rodas > 40)
        {
            this.rodas = 40;
        }
        else 
        {
            this.rodas = rodas;
        }
        return rodas;
    }
    
}

class Carro : Veiculo {
    public string nome;
    public string cor;
    public Carro(string nome, string cor) : base(4)
    {
        desligar();
        velMax= 120;
        this.nome = nome;
        this.cor = cor;
        info();
    }
    public void info()
    {
        Console.WriteLine();
        Console.WriteLine("Nome: ........... {0}", nome);
        Console.WriteLine("Cor: ............ {0}", cor);
        Console.WriteLine("Vel. Maxima: .... {0}km", velMax);
        Console.WriteLine("Ligado? ......... {0}", getLigado());
        Console.WriteLine("Rodas: ........... {0}", getRodas());
    }
}
class CarroCombate : Carro 
{
    public int monicao;

    public CarroCombate() : base("Carro de Combate", "Verde")
    {
        monicao = 100;
        setRodas(6);
        Listmonicao();
        
    }
    public void Listmonicao()
    {
        Console.WriteLine("Monição: ........... {0}", monicao);
    }
} 
public class CadeiaDeHeranca
{
    static void Main()
    {
 
        Carro c1 = new Carro("Mustangue", "Vermelho");
        CarroCombate cCombate = new CarroCombate();

    }
}


