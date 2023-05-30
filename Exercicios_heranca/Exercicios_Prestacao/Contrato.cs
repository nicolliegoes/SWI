namespace Exercicios_Prestacao;
class Contrato
{
    public int Prazo{get;set;}
    public double Valor{get;set;}

    public virtual double CalcularPrestacao(){
        return Valor/Prazo;
    }
}
