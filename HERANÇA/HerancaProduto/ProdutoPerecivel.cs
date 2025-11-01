using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class ProdutoPerecivel : Produto
    {
        private string? dtValidade;
        public string? DtValidade
        {
            get { return dtValidade; }
            set { dtValidade = value; }
        }
        private string? dtFabricacao;
        public string? DtFabricacao
        {
            get { return dtFabricacao; }
            set { dtFabricacao = value; }
        }
        private int lote;
        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        

        public override void Mostrar(){
            Console.WriteLine($"Código: {codigo}\tNome: {nome}\tPreço: {preco:c}\tData de Validade: {dtValidade}\tData de Fabricação: {dtFabricacao}\tLote: {Lote}");
        }
    }
}