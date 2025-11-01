using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(double salario) : base(salario){
            //base sobe para a classe base
        }
        public override double CalcularBonificacao(){
            return Salario * 15 / 100;
        }

    }
}