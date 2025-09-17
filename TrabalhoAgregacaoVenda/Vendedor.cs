using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Vendedor
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Comissao { get; set; }

        public void MostrarVendedor(){
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tComissão: {Comissao}");
        }
    }
}