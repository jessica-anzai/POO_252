using ClasseProduto;

//Console.WriteLine("");
internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();
        Console.WriteLine("--- CADASTRO DE PRODUTOS ---");
        Console.WriteLine("");
        Console.WriteLine("Insira o código:");
        p.codigo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o nome: ");
        p.nome = Console.ReadLine();
        Console.WriteLine("Informe o preço: ");
        p.preco = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o estoque disponível: ");
        p.estoque = Convert.ToInt32(COnsole.ReadLine());
        Console.WriteLine("");
    }
}