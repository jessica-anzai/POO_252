using AgregacaoConta;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cliente = new Cliente();

        cliente.Nome = "Bia";
        cliente.RG = 100;

        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Saldo = 1000;
        c1.Titular = cliente;

        c1.MostrarAtributos();

        Conta c2 = new Conta();
        c2.Numero = 2;
        c2.Saldo = 2000;
        c2.Titular = new Cliente();
        c2.Titular.Nome = "Ana";
        c2.Titular.RG = 123;

        c2.MostrarAtributos();
    }
}