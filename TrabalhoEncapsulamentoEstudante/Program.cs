using TrabalhoEncapsulamentoEstudante;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Estudante e = new Estudante();

        e.Nome = "Ana";
        e.Nota = 9.6;

        Estudante e1 = new Estudante();
        e1.Nome = "Bia";
        e1.Nota = 5.9;

        e.Exibir();
        e1.Exibir();

    }
}