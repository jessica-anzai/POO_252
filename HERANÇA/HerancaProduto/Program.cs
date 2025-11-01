using HerancaProduto;
internal class Program
{
    private static void Main(string[] args)
    {
        ProdutoPerecivel pp = new ProdutoPerecivel();
        pp.Codigo = 1;
        pp.Nome = "Café 500g";
        pp.Preco = 37.50;
        pp.DtFabricacao="20/09/2025";
        pp.DtValidade="20/02/2026";
        pp.Lote = 123;

        Produto p = new Produto();
        p.Codigo = 2;
        p.Nome = "Filtro para Café 102";
        p.Preco = 8.50;

        pp.Mostrar();
        p.Mostrar();

    }
}