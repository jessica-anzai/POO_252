using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public int RG { get; set; }

        public void Mostrar(){
            Console.WriteLine($"Nome: {Nome}\tRG: {RG}");
        }
    }
}