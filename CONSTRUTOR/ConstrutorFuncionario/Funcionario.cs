using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorFuncionario
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Salario { get; set; }
        public static int Contador {get ; private set;}

        public Funcionario(){
            Contador+=1;
        }

        public Funcionario(int codigo, string nome, double salario){
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
            Contador+=1;
        }

        public Funcionario (int codigo, double salario){
            Codigo = codigo;
            Salario = salario;
            Contador+=1;
        }

        public void MostrarAtributos(){
            Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalário: {Salario:c2}");
        }
    }
}