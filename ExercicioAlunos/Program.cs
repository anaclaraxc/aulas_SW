namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {
        Alunos aluno1 = new Alunos();
        aluno1.nome = "Catatau Vieira";
        aluno1.nota1 = 7.4;
        aluno1.nota2 = 4.6;

        aluno1.mensagem();
    }
}
