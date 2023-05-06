namespace ExercicioAluno;
class Program
{
    static void Main(string[] args)
    /*{
        Aluno aluno1 = new Aluno();
        aluno1.nome = "Fulano da Silva";
        aluno1.nota1 = 4.3;
        aluno1.nota2 = 7.8;

        aluno1.mensagem();
    }*/

     {
        Aluno aluno1 = new Aluno();

        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Seu nome é: " + nome);
        Console.Write("Digite um numero: ");
        aluno1.nota1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite um numero: ");
        aluno1.nota2 = Convert.ToDouble(Console.ReadLine());    

        
        aluno1.mensagem();
    }
}
