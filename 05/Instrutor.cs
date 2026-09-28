using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Instrutor: Funcionario
    {
        private int qtdAulas;
        private double valorAulas;

        public Instrutor(string nome, string matricula, double salarioBase, double valorAulas): base(nome, matricula, salarioBase)
        {
            this.valorAulas = valorAulas;
        }

        public void RegistrarAulas()
        {
            qtdAulas++;
        }

        public override double CalcularSalario()
        {
            double valorTrabalhado = qtdAulas * valorAulas;
            return valorTrabalhado + salarioBase;
        }
    }
}
