namespace Exercicio_Contrato;
class Contrato_Pessoa_Fisica:contrato
{
    public string? Cpf {get; set;}
    public int Idade {get; set;}

    public string MostraDados(){
        return " ";
    }
}