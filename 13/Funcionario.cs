using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal  abstract class Funcionario
    {
        private string nome;
        private string matricula;

        public Funcionario(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public abstract decimal CalcularSalario();
        
    }
}
