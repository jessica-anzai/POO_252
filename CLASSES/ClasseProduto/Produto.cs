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
        public string? nome;
        public double preco;
        public int estoque;
        public double subtotal;

        public void MostrarAtributos(){
            Console.WriteLine($"Código: {codigo}\tNome: {nome}\tPreço: R${preco}\tEstoque: {estoque}\tSubtotal: {subtotal}");
        }

        public void CalcularAumento(double aumento){
            preco += preco*aumento/100;
        }
        public void RetirarEstoque(int retirar){
            estoque-=retirar;
        }
        public void CalcularSubtotal(){
            subtotal = preco*estoque;
        }
    }
}