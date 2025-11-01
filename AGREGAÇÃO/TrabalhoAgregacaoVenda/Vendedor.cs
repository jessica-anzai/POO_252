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

        public Vendedor(int cod, string nome)
        {
            Codigo = cod;
            Nome = nome;

        }

        public void CalcularComissao(double valor)
        {
            Comissao += valor * 0.2;
        }

        public void MostrarAtributo(){
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tComissão: {Comissao}");
        }
    }
}