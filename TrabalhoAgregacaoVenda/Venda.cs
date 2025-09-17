using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp {get; set;}
        public Vendedor Vend { get; set; }
        public List<Produto> vetProd { get; set; }

        public void MostrarAtributos()
        {
            for (int i = 1; i <= vetProd.Length; i++)
            {
                Console.WriteLine($"Comprador: {Comp}\tVendedor: {Vend}\tProduto: {vetProd[i]}");
            }
        }
    }
}