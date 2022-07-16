public class ContaCorrente 
{
    public  string Titular = "Sabrina"; //Isso é um atributo
    public int Agencia;
    public int Numero;
    public double Saldo; 
    public double Depositar;

    public ContaCorrente (string Titular, int Agencia, 
    int Numero, double Saldo){
        this.Titular = Titular; 
        this.Agencia = Agencia;
        this.Numero = Numero;
        this.Saldo = Saldo;
    }
   public bool Sacar (double valorSaque){
    if (this.Saldo >= valorSaque){
       this.Saldo = this.Saldo - valorSaque;
       return true;
    }
       return false;  
   }
   public bool Depositar (double valorDeposito){
    if (this.Depositar > 0){
        return true;
    }
        return false;
   }
}