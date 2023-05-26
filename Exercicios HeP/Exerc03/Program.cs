namespace Ex_03;

class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica pf = new ContratoPessoaFisica();
        ContratoPessoaJuridica pj = new ContratoPessoaJuridica();

        pf.Tipo = "Pessoa Física";
        pf.Idade = 50;
        pf.Cpf = 12345678910;
        pj.Tipo = "Pessoa Jurídica";
        pj.Cnpj = 19876543210;
        pj.Inscricao = 13579246810;
        pj.Prazo = 10;
        pf.Prazo = 10;
       

    Console.WriteLine("__________________________________________________________________________________________________________________");
        Console.WriteLine(" ");
        Console.WriteLine("Tipo do contrato: " + pf.Tipo + " |" + " *Idade: " + pf.Idade + " |" + " *CPF: " + pf.Cpf + " |" + " Valor do contrato: " + c.CalcularPrestacao() + " | " + " Prazo de pagamento: "+ pf.Prazo + " |" + " Valor das prestações: " + pf.CalcularPrestacao());
        Console.WriteLine("__________________________________________________________________________________________________________________");
        Console.WriteLine(" ");
        Console.WriteLine("Tipo do contrato: " + pj.Tipo + " |" + " *CNPJ: " + pj.Cnpj + " |" + " *Inscrição estadual: " + pj.Inscricao + " |" + " Valor do contrato: " + c.CalcularPrestacao() + " |" + " Prazo de pagamento: " + pj.Prazo + " |" + " Valor das prestações: " + pj.CalcularPrestacao());
        Console.WriteLine("__________________________________________________________________________________________________________________");
    }
}
