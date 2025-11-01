using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoConstrutorAluno
{
    public class Aluno
    {
        public static long RA { get; set;}
        public string? Nome { get; set; }
        public static long Contador { get; set; }


        static Aluno(){
            RA = 0;
            Contador = 1570482413000;
        }

        public Aluno(string nome)
        {
            Contador += 1;
            RA = Contador;
            Nome = nome;
        }
        
        public void Exibir()
        {
            Console.WriteLine($"RA: {RA}\tNome: {Nome}");
        }
    }
}