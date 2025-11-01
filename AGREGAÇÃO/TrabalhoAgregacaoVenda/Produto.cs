using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public static int Contador { get; set; }

        static Produto()
        {
            Contador = 500;
        }

        public Produto(string nome,double preco)
        {
            Contador += 1;
            Codigo = Contador;
            Nome = nome;
            Preco = preco;
            
        }

        public void MostrarAtributo()
        {
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tPreço: {Preco}");
        }
    }
}