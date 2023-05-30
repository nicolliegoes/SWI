namespace Exercicios_Prestacao;
class Program
{
    static void Main(string[] args)
    {
        Pessoa_Fisica PF = new Pessoa_Fisica();
        Pessoa_Juridica PJ = new Pessoa_Juridica();

        PF.Idade = 40;
        PF.Prazo = 6;
        PF.Valor = 300;

        PJ.Prazo = 5;
        PJ.Valor = 200;

        Console.WriteLine("Sua idade é: " + PF.Idade);
        Console.WriteLine("Seu valor é: " + PF.Valor);
        Console.WriteLine("Seu prazo é: " + PF.Prazo);
        Console.WriteLine("O valor da sua prestação é: " + (PF.CalcularPrestacao()));

        Console.WriteLine("Seu valor é: " + PJ.Valor);
        Console.WriteLine("Seu prazo é: " + PJ.Prazo);
        Console.WriteLine("O valor da sua prestação é: " + (PJ.CalcularPrestacao()));
    }
}
