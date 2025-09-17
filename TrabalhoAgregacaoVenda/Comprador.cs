using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAgregacaoVenda
{
    public class Comprador
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Verba { get; set; }

        public void MostrarCliente(){
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tVerba: {Verba:c}");
        }
    }
}