using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoComposicao
{
    public class Banco
    {
        public List<ContaPoupanca> Poup { get; set; } = new List<ContaPoupanca>();
        public List<ContaCorrente> Conta { get; set; } = new List<ContaCorrente>();

        public void IniciarBanco()
        {
            Console.WriteLine("Banco inicializado..........");
            // As listas já estão inicializadas, não precisa criar novas aqui.
        }

        public void AbrirConta(double saldoInicial, double ChequeEspecialInicial)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Depositar(saldoInicial, ChequeEspecialInicial);
            Conta.Add(conta);
            Console.WriteLine("Conta corrente aberta com sucesso!");
        }

        public void AbrirPoupanca(double saldoInicial)
        {
            ContaPoupanca poupanca = new ContaPoupanca();
            poupanca.Depositar(saldoInicial);
            Poup.Add(poupanca);
            Console.WriteLine("Conta poupança aberta com sucesso!");
        }
        
        //decretar falencia
    }
}