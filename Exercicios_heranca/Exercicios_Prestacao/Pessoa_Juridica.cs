namespace Exercicios_Prestacao;
class Pessoa_Juridica:Contrato
{
    public override double CalcularPrestacao()
    {
        return base.CalcularPrestacao() + 3.0;
    }
}