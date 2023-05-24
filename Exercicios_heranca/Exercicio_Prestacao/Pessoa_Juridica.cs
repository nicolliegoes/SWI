namespace Exercicio_Prestacao;
class Pessoa_Juridica:Contrato
{
    public override double calcularPrestacao()
    {
        return base.calcularPrestacao()+ 3;
    }
}
