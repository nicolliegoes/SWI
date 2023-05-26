namespace Exercicio_Prestacao;
class Program
{
    static void Main(string[] args)
    {
        Pessoa_Fisica PF = new Pessoa_Fisica();
        Pessoa_Juridica PJ = new Pessoa_Juridica();

        PF.Valorpretacao = 200;
        PF.Prazo = 30;
        PF.Idade = 20;

        PJ.Valorpretacao = 300;
        PJ.Prazo = 20;




        Console.WriteLine("A idade da pessoa fisica é: " + PF.Idade + "o valor da pessoa fisica é de: " + PF.Valorpretacao + " sendo no prazo de:" + PF.Prazo + "cada prestacao fica em:" + (calcularPrestacao()));

        
    }
}
