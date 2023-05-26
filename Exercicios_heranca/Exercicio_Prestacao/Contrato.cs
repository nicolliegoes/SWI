namespace Exercicio_Prestacao;
class Contrato
{

    public double Valorpretacao{get;set;}
    public double Prazo{get;set;}
    public virtual double calcularPrestacao(){
        return Valorpretacao/Prazo;
    }
}
