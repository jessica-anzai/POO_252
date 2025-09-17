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
        p.estoque = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        p.MostrarAtributos();
        Console.WriteLine("");
        Console.WriteLine("Informe o valor do aumento: ");
        double aum = Convert.ToDouble(Console.ReadLine());
        p.CalcularAumento(aum);
        Console.WriteLine("");
        Console.WriteLine("Produto alterado - aumento no preço");
        p.MostrarAtributos();
        Console.WriteLine("");
        Console.WriteLine("Quantos itens deseja retirar do estoque?");
        int retirar = Convert.ToInt32(Console.ReadLine());
        p.RetirarEstoque(retirar);
        Console.WriteLine($"{retirar} retirados com sucesso!");
        Console.WriteLine("");
        p.MostrarAtributos();
        p.CalcularSubtotal();
        p.MostrarAtributos();
    }
}