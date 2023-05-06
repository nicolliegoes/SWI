namespace EMSPRETIMO_BANCARIO;
class Banco
{
    public double saldo {get;set;}

    public double limite {get;set;}

    public double meses {get;set;}

    //Método para realizar um depósito
        public void depositar(double valor){
        this.saldo += valor;
    }


//Método para realizar um saque
        public void saque (double valor){
        this.saldo -= valor;
    }

//Metodo para realizar emprestimos com juros
    public double juros(){
        return  this.saldo = this.limite * 0.06;
    
    }


//Método para realizar emprestimos sem juros
public double emprestimo(){
        return this.saldo = this.limite / this.meses;
    }




}



