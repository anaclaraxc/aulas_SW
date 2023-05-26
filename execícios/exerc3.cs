namespace exerc3;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        //Instânciando a classe
        Contrato c = new Contrato();
        PessoaFisica pf = new PessoaFisica();
        PessoaJuridica pj = new PessoaJuridica();


        //Fazendo o usuário escolher se é Pessoa Física ou Jurídica
        string? Escolha = string.Empty;

        while(Escolha != "1" && Escolha != "1")
        {
            Console.WriteLine("Digite 1 para pessoa física e 2 para pessoa jurídica.");
            Escolha = Console.ReadLine();

            switch (Escolha)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Contrato de Pessoa Física");
                    Console.WriteLine("");
                    Console.WriteLine("Digite seu nome: ");
                    pf.nome = Console.ReadLine();
                    Console.WriteLine("Digite seu email: ");
                    pf.email = Console.ReadLine();
                    Console.WriteLine("Digite seu telefone: ");
                    pf.telefone = Console.ReadLine();
                    Console.WriteLine("Digite seu CPF: ");
                    pf.CPF = Console.ReadLine();
                    Console.WriteLine("Digite sua idade: ");
                    pf.idade = int.Parse(Console.ReadLine());

                    Console.Clear();
                    Console.WriteLine("Contrato Pessoa Jurídica");
                    Console.WriteLine("Valores");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o valor total que quer parcelar: ");
                    pf.valor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de vezes que quer parcelar");
                    pf.parcelas = int.Parse(Console.ReadLine());               
                    Console.Clear();
                    Console.WriteLine(pf.MostraDados());
                    Console.WriteLine("O valor das parcelas com o acréscimo é: R$" + pf.CalcularPrestação(pf.Valor, pf.Parcelas) + ",00 por " + pf.Parcelas + " meses");
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Contrato de Pessoaa Jurídica");
                    Console.WriteLine("");
                    Console.WriteLine("Digite seu nome: ");
                    pj.nome = Console.ReadLine();
                    Console.WriteLine("Digite seu email: ");
                    pj.email = Console.ReadLine();
                    Console.WriteLine("Digite seu telefone: ");
                    pj.telefone = Console.ReadLine();
                    Console.WriteLine("Digite o nome da Empresa: ");
                    pj.NomeEmpresa = Console.ReadLine();
                    Console.WriteLine("Digite o CNPJ da empresa: ");
                    pj.CNPJ = Console.ReadLine();
                    Console.WriteLine("Digite o IE da empresa:");
                    pj.IE = Console.ReadLine();
                    
                    Console.Clear();
                    Console.WriteLine("Contrato Pessoa Jurídica");
                    Console.WriteLine("Valores");
                    Console.WriteLine("");
                    Console.WriteLine("Digite o valor total que deja parcelar: ");
                    pj.Valor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de vazes que deseja parcelar");
                    pj.Parcelas = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine(pj.MostraDados());
                    Console.WriteLine("O valor das parcelas com o acréscimo é de: R$" + pj.CalcularPrestação(pj.Valor, pj.Parcelas) + ",00 por " + pj.Parcelas + " meses" );
                    break;
            }
        }
    }
}
