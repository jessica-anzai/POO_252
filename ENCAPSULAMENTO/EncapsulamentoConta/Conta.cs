using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta //namepace é uma pasta
{
    public class Conta //tipo de dados meu de programador
    {
        //declaração dos atributos
        private int numero;
        private string? titular;
        private double saldo;

        //métodos
        public int Numero{ //Numero com n maíusculo = propriedade /propriedade é
                           // a representação dos métodos de encapsulamento
            set{
                if (value > 0){
                    numero = value; //numero com n minúsculo = atributo
                }
                else{
                    Console.WriteLine("Número de conta inválido!!");
                }

            }
            get{
                return numero;
            }
        }

        public string? Titular{
            set{
                titular = value;
            }
            get{
                return titular;
            }
        }

        /*public double Saldo{
            set{
                saldo = value;
            }
            get{
                return saldo;
            }
        }*/

        //declaração dos metodos
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Número: {numero}\tTitular: {titular}\tSaldo: {saldo:c}");
        }
    }
}