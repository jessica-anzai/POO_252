using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicao
{
    public class ContaCorrente
    {
        public double Saldo { get; private set; }
        public double ChequeEspecial { get; set; }

        public void Depositar(double valor, double valor2)
        {
            Saldo += valor;
            ChequeEspecial += valor2;
        }
        public void Sacar(double valor)
        {
            Saldo -= valor;
        }
        public void GerarExtrato()
        {
            Console.WriteLine($"---Extrato Conta Corrente---");
            Console.WriteLine($"Saldo: {Saldo:c}\tCheque Especial: {ChequeEspecial}");
        }
    }
}