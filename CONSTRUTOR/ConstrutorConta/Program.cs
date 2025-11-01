using ConstrutorConta;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c = new Conta(1);
        c.MostrarAtributos();

        Conta c1 = new Conta(2, "Bia");
        c1.MostrarAtributos();

        Conta c2 = new Conta(3);
        c2.MostrarAtributos();

        Conta c3 = new Conta(4,"Ana",1000);
        c3.MostrarAtributos();

    }
}