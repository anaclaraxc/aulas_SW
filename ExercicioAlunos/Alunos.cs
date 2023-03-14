namespace ExercicioAlunos;
class Alunos
{
    public string nome="";
    public double nota1, nota2;

    //MÉDIA -> retornar um double (por exemplo um número como 8.9)
    public double obterMedia(){
        double media = (nota1 + nota2)/2;
        return media;
    }

    //SITUAÇÃO -> retornar uma string ("Aprovado" ou "reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="APROVADO";
        }else{
            situacao="REPROVADO";
        }
        return situacao;
    }

    //MENSAGEM -> não retornar nada.Só mostra na tela os detalhes (nome, média e situação)
    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadoSituacao+" com média: "+mediaCalculada);
    }
} 