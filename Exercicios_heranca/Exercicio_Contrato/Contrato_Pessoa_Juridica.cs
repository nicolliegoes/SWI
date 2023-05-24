namespace Exercicio_Contrato;
class Contrato_Pessoa_Juridica:contrato
{
    public string? Cnpj {get; set;}
    public string? IE {get; set;}
    public string? NomeEmpresa {get; set;}

    public string MostraDados(){
        return " ";
    }
}