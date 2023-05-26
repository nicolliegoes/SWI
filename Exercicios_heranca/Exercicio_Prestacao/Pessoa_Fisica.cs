namespace Exercicio_Prestacao;
class Pessoa_Fisica:Contrato
{

    public int Idade{get; set;}


    public override double calcularPrestacao()
    {

        double adicional = 0.0;
        
        if(Idade<=30)
        adicional = 1.0;
        else if(Idade<=40)
        adicional = 2.0;
        else if(Idade<=50)
        adicional = 3.0;
        else if(Idade > 50)
        adicional = 4.0;

        return adicional + calcularPrestacao;
    }

}
