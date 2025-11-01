using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }
        public List<Produto> vetProd { get; set; } = new List<Produto>();
        public double Total { get; set; }

        public void CalcularTotal()
        {
            double total = 0;
            foreach (var p in vetProd)
            {
                total += p.Preco;
                Comp.RetirarVerba(p.Preco);
                Vend.CalcularComissao(p.Preco);

            }
            Total = total;
        }

        public void MostrarAtributo()
        {
            Console.WriteLine($"Comprador: {Comp.Codigo} - {Comp.Nome}\tVendedor: {Vend.Codigo} - {Vend.Nome}");
            Console.Write("Produtos: ");
            foreach (var prod in vetProd)
            {
                Console.Write($"{prod.Nome} (R${prod.Preco:F2})  ");
            }
            Console.WriteLine($"\nTotal: R${Total:F2}");
        }
    }
}