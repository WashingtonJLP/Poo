using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Mensalista: Funcionario
    {
        private decimal salario_fixo;


        public Mensalista(string nome, string matricula, decimal salario_fixo): base(nome, matricula) 
        {
          this.salario_fixo = salario_fixo;
        }

        public override decimal CalcularSalario() 
        {
            return this.salario_fixo;
        }
    }
}
