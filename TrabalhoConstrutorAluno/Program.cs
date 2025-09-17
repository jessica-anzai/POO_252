using TrabalhoConstrutorAluno;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        /*
        classe aluno: RA, Nome, Contador(static)
        dois construtores, um vazio/padrão e outro com o parâmetro nome

        Use o construtor static para inicializar a variável contador
        nos outros construtores incremente o contador e o armazene no atributo RA

        faça instâncias e apresente os atributos
        */

        Aluno a = new Aluno();
        a.Exibir();

        Aluno a1 = new Aluno("Ana");
        a1.Exibir();


    }
}