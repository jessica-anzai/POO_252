using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoEncapsulamentoEstudante
{
    public class Estudante
    {
        /*criar a classe estudante (nome, media), implementar o encapsulamento
        dos atributos com validações e o metodo ExibirDetalhes(), a nota só pode
        estar dentro dos valor de 0 a 10, realize no mínimo 2 instâncias.

        Desenvolver os métodos
        - bool EstaAprovado(). true/false regra media >= 6
        - void ExibirInformacoes(), usar writeline e acrescentar o status, onde sera
        chamado o metodo anterior.
        */
        public string? Nome { get; set; }
        public double Nota { get; set; }

        public bool SituacaoAluno()
        {
            if (Nota >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Exibir()
        {
            string status = SituacaoAluno() ? "Aprovado" : "Reprovado";
            Console.WriteLine($"Nome: {Nome}\tNota: {Nota}\tSituação: {status}");
        }
    }
}