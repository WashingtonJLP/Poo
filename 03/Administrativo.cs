using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Administrativo : Funcionario
    {
        private string setor;

        public Administrativo(string nome, string matricula, double salarioBase, string setor) : base(nome, matricula, salarioBase)
        {
            this.setor = setor;
        }

      
    }
}
