namespace projetoconta;
class Conta
{
  public int Numero {get; set;}
   private double Saldo {get;set;}

   public double Limite {get; private set;}
   public void AjustarLimite(double valor)
    this.Limite = valor;

   public void Depositar(double valor){
    this.Saldo += valor;
   }
   public void Sacar(double valor){
    this.Saldo -= valor;
   }
   public double MostrarSaldo(){
    return this.Saldo + this.Limite;
   }
}

