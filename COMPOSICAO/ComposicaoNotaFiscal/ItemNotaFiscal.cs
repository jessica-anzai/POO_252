using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoNotaFiscal
{
    public class ItemNotaFiscal
    {
        public int QtdeProduto { get; set; }
        
        public ItemNotaFiscal(int qtdeProduto){
            QtdeProduto = qtdeProduto;
        }

        public void Mostrar(){
            Console.WriteLine($"Quantidade de produtos: {QtdeProduto}");
        }

        ~ItemNotaFiscal(){ //destrutor retira a referencia de memoria do obj instanciado
            //QtdeProduto = null; //o null retira a referencia de memoria
            Console.WriteLine("Destruindo o item da nota fiscal");
        }
    }
}