namespace Exercicio_Prestacao;
class Contrato
{

    public double Valorpretacao{get;set;}
    public virtual double calcularPrestacao(){
        return Valorpretacao/12;
    }
}
