namespace EMSPRETIMO_BANCARIO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Empréstimo Bancário");
        Banco banco = new Banco();

        banco.meses = 12;

        banco.limite = 1000;

        banco.depositar(0);

        banco.saque(0);
        
        //vamos chamar o metódo para consultar juros.
        double saldo = (banco.juros() + banco.emprestimo())* banco.meses;
        //Agora para visualizar:
        Console.WriteLine("Valor total a pagar é: " + saldo);

        
    }
}    
