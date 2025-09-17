using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoConstrutorAluno
{
    public class Aluno
    {
        public long RA { get; set; }
        public string? Nome { get; set; }
        public static long Contador { get; set; } = 0;


        public Aluno()
        {
            RA = 15704824130000;
            Contador += 1;
            RA += Contador;
        }

        public Aluno(string nome)
        {
            RA = 15704824130000;
            Contador += 1;
            RA += Contador;
            Nome = nome;
        }
        public void Exibir()
        {
            Console.WriteLine($"RA: {RA}\tNome: {Nome}");
        }
    }
}