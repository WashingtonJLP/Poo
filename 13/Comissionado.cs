using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Comissionado: Funcionario
    {
        private decimal salario_fixo;
        private decimal percentual_vendas;
        private decimal vendas;

        public Comissionado(string nome, string matricula, decimal salario_fixo, decimal percentual_vendas, decimal vendas) : base(nome, matricula)
        {
            this.salario_fixo = salario_fixo;
            this.percentual_vendas = percentual_vendas;
            this.vendas = vendas;
        }

        public override decimal CalcularSalario()
        {
            return this.salario_fixo + ((this.vendas * percentual_vendas) / 100);
        }
    }
}