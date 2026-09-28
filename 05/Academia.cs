using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Academia
    {
        private List<Funcionario> funcionarios;

        public Academia()
        {
           this.funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }

       public  double CalcularFolha()
        {
            double soma = 0;

            foreach (Funcionario funcionario in funcionarios)
            {
                soma += funcionario.CalcularSalario();
            }

            return soma;
        }

    }
}
