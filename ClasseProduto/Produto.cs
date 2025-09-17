using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Console.WriteLine($"");

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int estoque;
        public double subtotal;

        public void MostrarAtributos(){
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Preço: R${preco}");
            Console.WriteLine($"Estoque: {estoque}");
        }

        public void CalcularAumento(){
            //porcentagem
        }
        public void RetirarEstoque(){

        }
        public void CalcularSubtotal(){

        }
    }
}