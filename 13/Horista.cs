using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Horista: Funcionario
    {
        private decimal horas;
        private decimal valor_hora;

        public Horista(string nome, string matricula, decimal horas, decimal valor_hora): base(nome, matricula)
        {
            this.horas = horas;
            this.valor_hora = valor_hora;
        }

        public override decimal CalcularSalario()
        {
            decimal horasExtra = 0;

            if (horas > 160)
            {
                horasExtra = this.horas - 160;

                return (160.00m * valor_hora) + (((valor_hora * 0.50m) + valor_hora) * horasExtra) ;

            }

            else {return this.horas * valor_hora; }
        }

    }
}
