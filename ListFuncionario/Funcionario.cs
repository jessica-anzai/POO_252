using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListFuncionario //pasta
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        public void MostrarAtributos(){
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salário: R${salario}");
        }

        public void CalcularAumento(double acrescimo){//acrescimo de 5%
            salario = salario + (salario*acrescimo/100);
        }

    }
}