using VetorProduto;

class Program
{
    static void Main(string[] args)
    {
        /*
        Declare um vetor de 6 elementos para atender o SCP - Sistema de Controle dos Produtos 
        Calcule o aumento dos preços dos produtos que foram armazenados nos índices pares 
        Retire estoque dos produtos que foram armazenados nos índices ímpares 
        Liste/mostre os dados dos produtos 
        Calcule o subtotal de todos os produtos e apresente novamente para conferir o resultado do cálculo 
        */

        Produto[] vetProduto = new Produto[6];
        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i] = new Produto();
            Console.Write("Informe o código do produto: ");
            vetProduto[i].codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe o nome do produto: ");
            vetProduto[i].nome = Console.ReadLine();

            Console.Write("Informe o preço: R$");
            vetProduto[i].preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a quantidade em estoque: ");
            vetProduto[i].estoque = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].CalcularSubtotal();
        }

        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].MostrarAtributos();
        }

        for (int i = 0; i < vetProduto.Length; i++)
        {
            if (vetProduto[i].codigo % 2 == 0)
            {
                Console.Write("Qual o percentual de aumento?");
                double percent = Convert.ToDouble(Console.ReadLine());
                vetProduto[i].CalcularAumento(percent);
            }

            else
            {
                Console.Write("Qual a quantidade a ser removida do estoque?");
                int retirar = Convert.ToInt32(Console.ReadLine());
                vetProduto[i].RetirarEstoque(retirar);
            }
        }

        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].CalcularSubtotal();
        }

        for (int i = 0; i < vetProduto.Length; i++)
        {
            vetProduto[i].MostrarAtributos();
        }
    }
}
