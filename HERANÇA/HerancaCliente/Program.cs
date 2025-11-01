using HerancaCliente;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente c = new Cliente();
        c.Codigo = 1;
        c.Nome = "Ana";

        ClienteFisico cf = new ClienteFisico();
        cf.Codigo = 2;
        cf.Nome = "Bia";
        cf.RG = 123;

        cf.Mostrar();
    }
}