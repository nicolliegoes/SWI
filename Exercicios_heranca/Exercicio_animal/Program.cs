namespace Exercicio_animal;
class Program
{
    static void Main(string[] args)
    {
        homem Liam = new homem();
        cao Kiara = new cao();
        gato Kitty = new gato();



        Console.WriteLine("O homem faz:" + Liam.Fala());
        Console.WriteLine("O cao faz:" + Kiara.Fala());
        Console.WriteLine("O gato faz:" + Kitty.Fala());
    }
}
