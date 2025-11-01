using EncapsulamentoProduto;

//Console.Write("");
internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();

        p.Codigo = 1;
        p.Nome = "Pão Francês";
        p.Preco = 0.50;

        p.MostrarAtributos();

        if(p.Preco > 10){
            Console.WriteLine($"Preço alto: {p.Preco:c}");
        }
        else{
            Console.WriteLine("Nenhum preço alto");
        }

    }
}