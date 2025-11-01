using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public double TotalBonificacao
        {
            get { return totalBonificacao; }
            private set { totalBonificacao = value; }
        }

        
        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.CalcularBonificacao();
        }


    }
}
//public boid TotalizadorBonificacao(Diretor diretor){
//  this.TotaldeBonificacao += diretor.CalcularBonificacao();}