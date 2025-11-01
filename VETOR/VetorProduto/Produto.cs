using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetorProduto
{
    public class Produto
    {
        public int codigo, estoque;
        public string? nome;
        public double preco, subtotal;

        public void MostrarAtributos()
        {
            Console.WriteLine($"Código: {codigo}\tNome: {nome}\tPreço: R${preco}\tEstoque: {estoque}\tSubtotal: {subtotal}");
        }

        public void CalcularAumento(double percent)
        {
            preco += preco * (percent / 100);
        }

        public void CalcularSubtotal()
        {
            subtotal = estoque * preco;
        }
        
        public void RetirarEstoque(int retirar)
        {
            estoque -= retirar;
        }
    }
}