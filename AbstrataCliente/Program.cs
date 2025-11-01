using AbstrataCliente;
internal class Program
{
    private static void Main(string[] args)
    {

        //instancia correta, mas quando usamos a palavra abstract NÃO EXECUTARÁ
        Cliente c = new Cliente();
    }
}