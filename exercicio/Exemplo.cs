namespace exercicio;
class Exemplo
{
    //ATRIBUTOS
    public string nome="";
    public int idade=0;
    public bool vacinado=false;

    //METODOS
    public void mostramsg(){
        Console.WriteLine("Oieeee sua linda");
    }

    public void pegaNome(string texto){
        Console.WriteLine("Oieeee sua linda: " + texto);
    }

    public string mensagem(){
        return "Devolvendo um texto";
    }

    public int somar(int a, int b){
    return a+b;
    }

}