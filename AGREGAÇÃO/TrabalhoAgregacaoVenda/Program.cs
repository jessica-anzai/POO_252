using TrabalhoAgregacaoVenda;

internal class Program
{
    private static void Main(string[] args)
    {
        Vendedor v = new Vendedor(1, "Ana");
        Vendedor v1 = new Vendedor(2, "Carlos");
        v.MostrarAtributo();
        v1.MostrarAtributo();

        Comprador c = new Comprador(1, "Beatrice", 4000);
        Comprador c1 = new Comprador(2, "Daniel", 5500);
        c.MostrarAtributo();
        c1.MostrarAtributo();

        Produto p = new Produto("Água", 2.50);
        Produto p1 = new Produto("Pão", 1.50);
        p.MostrarAtributo();
        p1.MostrarAtributo();

        Venda ven = new Venda();
        ven.Comp = c1;
        ven.Vend = v;
        ven.vetProd.Add(p);
        ven.vetProd.Add(p1);
        ven.CalcularTotal();
        ven.MostrarAtributo();
        v.MostrarAtributo();
        v1.MostrarAtributo();
        c.MostrarAtributo();
        c1.MostrarAtributo();
        

    }
}