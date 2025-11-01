using AgregacaoVetorConta;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c = new Conta();
        c.Numero = 1;
        c.Saldo = 10000;

        c.vetTitulares = new List<Cliente>();

        for(int i = 0; i < 3; i++){

            Cliente objetoCliente = new Cliente();
            Console.Write("Digite o nome: ");
            objetoCliente.Nome = Console.ReadLine();
            Console.Write("Digite o RG: ");
            objetoCliente.RG = Convert.ToInt32(Console.ReadLine());

            c.vetTitulares.Add(objetoCliente);
        }
        Console.WriteLine("\n\nApresentação dos sócios: ");
        foreach (var cliente in c.vetTitulares)
        {
            cliente.Mostrar();
        }
    }
}