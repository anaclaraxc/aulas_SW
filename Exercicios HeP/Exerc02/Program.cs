namespace Exerc2;

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
        pj.Cnpj = 19886543910;
        pj.Inscricao = 17576246900;  
        Console.WriteLine(" ");
        Console.WriteLine("Tipo do contrato: " + pf.Tipo + " |" + " *Idade: " + pf.Idade + " |" + " *CPF: " + pf.Cpf);    
        Console.WriteLine(" ");
        Console.WriteLine("Tipo do contrato: " + pj.Tipo + " |" + " *CNPJ: " + pj.Cnpj + " |" + " *Inscrição estadual: " + pj.Inscricao);       
    }
}
