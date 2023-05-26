namespace exerc2;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email{get;set;}
    public string? Telefone{get;set;}
    
    public virtual string MostraDados(){
        string tudo = "Nome: " + this.Nome + "  " + "Email: " + this.Email + "  " + "Telefone: " + this.Telefone + "  ";
        return tudo;
    }

    
}
