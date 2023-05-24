namespace Exercicio_Contrato;
class Program
{
    static void Main(string[] args)
    {
        Contrato_Pessoa_Juridica PJ = new Contrato_Pessoa_Juridica();
        Contrato_Pessoa_Fisica PF = new Contrato_Pessoa_Fisica ();

        PJ.Nome = "Louis";
        PJ.Email = "LouisEmpresas@gmail.com";
        PJ.Telefone = "98765432";
        PJ.Cnpj = "98. 765. 432/0001-10.";
        PJ.IE = "12 123456 ";
        PJ.NomeEmpresa = "Louis Empresas";

        PF.Nome = "Vicente";
        PF.Email = "Vicente.Santos@gmail.com";
        PF.Telefone = "952346789";
        PF.Cpf = "748.595.783/09";
        PF.Idade = 34; 


        Console.WriteLine("Nome da pessoa juridica: " + PJ.Nome + " Usuario do email: " + PJ.Email + " Com o telefone: " + PJ.Telefone + " Possuindo o Cnpj: " + PJ.Cnpj + " Possuindo o IE: " + PJ.IE + " Sendo o nome da empresa: " + PJ.NomeEmpresa + (PJ.MostraDados()));
        Console.WriteLine("Nome da pessoa fisica: " + PF.Nome + " Usuario do email: " + PF.Email + " Com o telefone: " + PF.Telefone + " Possuindo o Cpf: " + PF.Cpf + " Tendo: " + PF.Idade + "anos" + (PF.MostraDados()));
}
}
