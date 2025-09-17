using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        public int Codigo = 500 { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        
        public void MostrarProduto(){
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tPreço: {Preco:c}");
        }
    }
}