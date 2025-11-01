using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstrataCliente
{
    public abstract class Cliente
    {
        protected int codigo;
        protected string? nome;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        
    }
}