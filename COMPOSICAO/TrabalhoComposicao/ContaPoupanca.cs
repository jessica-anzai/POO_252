using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicao
{
    public class ContaPoupanca
    {
        public double Saldo { get; set; }
        public static int Contador { get; set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void GerarRendimento()
        {
            double rendimento = Saldo * 0.5;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento gerado: {rendimento:c}\tNovo Saldo: {Saldo:c}");
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"---Extrato Poupança---");
            Console.WriteLine($"Saldo: {Saldo:C}");
        }
    }
}