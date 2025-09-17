using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario //pasta
{
    public class Funcionario
    {
        private int codigo;
        private string? nome;
        private double salario;

        public int Codigo{
            set{
                if (value > 0) codigo = value;
                else Console.WriteLine("Código inválido!!");
            }
            get{
                return codigo;
            }
        }
        public string? Nome{
            set{
                nome = value;
            }
            get{
                return nome;
            }
        }
        public double Salario{
            set{
                if (value > 0){
                    salario = value;
                }
                else{
                    Console.WriteLine("Salário inválido!!");
                }
            }
            get{
                return salario;
            }
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Código: {codigo}\tNome: {nome}\tSalário: {salario:c}");
        }

        public void CalcularAumento(double acrescimo){
            salario = salario + (salario*acrescimo/100);
        }

    }
}