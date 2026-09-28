using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Funcionario
    {
        private string nome;
        private string matricula;
        protected double salarioBase;

        public Funcionario(string nome, string matricula, double salarioBase)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.salarioBase = salarioBase;
        }

        public virtual double CalcularSalario()
        {
            return salarioBase;
        }
    }
}
