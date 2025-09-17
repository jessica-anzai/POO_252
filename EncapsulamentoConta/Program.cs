using EncapsulamentoConta;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        c1.Numero = 2;

        Conta c2 = new Conta();
        Console.Write("Informe o número: ");
        c2.Numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Informe o titular: ");
        c2.Titular = Console.ReadLine();
        Console.Write("Informe o saldo: ");
        c2.Saldo = Convert.ToDouble(Console.ReadLine());
        
        c2.MostrarAtributos();

    }
}