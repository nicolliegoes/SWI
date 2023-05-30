namespace Exercicios_Prestacao;
class Pessoa_Fisica:Contrato
{
    public int Idade{get;set;}

    public override double CalcularPrestacao()
    {
        double Parcela = base.CalcularPrestacao();
        double Adiciona = 0.0;

        if(Idade<=30)
        Adiciona = 1.0;
        else if(Idade<=40)
        Adiciona = 2.0;
        else if(Idade<=50)
        Adiciona = 3.0;
        else if(Idade > 50)
        Adiciona = 4.0;

        return Adiciona + Parcela;
    }
}
