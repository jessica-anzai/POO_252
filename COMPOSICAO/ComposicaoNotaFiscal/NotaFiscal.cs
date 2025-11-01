using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class NotaFiscal
    {
        public int NumeroNF { get; set; }
        public string? Data { get; set; }
        public List<ItemNotaFiscal> vetItens { get; set; }

        public NotaFiscal(int nf, string data)
        {//inicializa os atributos da classe
            //no momento da instancia do obj-todo que é NotaFiscal, a instância da relação/associação deve ser realizada/estabelecida
            vetItens = new List<ItemNotaFiscal>();
            NumeroNF = nf;
            Data = data;
        }

        ~NotaFiscal(){ //destrutor retira a referencia de memoria do obj instanciado
            vetItens = null; //o null retira a referencia de memoria
            Console.WriteLine("Destruindo a nota fiscal");
        }


    }
}