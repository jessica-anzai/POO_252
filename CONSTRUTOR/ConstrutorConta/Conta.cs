using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero){ // construtor padrão
        Numero = Numero;
        }

        public Conta(int numero, string titular){
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo){
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Número: {Numero}\tTitular: {Titular}\tSaldo {Saldo:c}");
        }
    }
}