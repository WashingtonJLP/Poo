using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Recepcionista: Funcionario
    {
        private string turno;

        public Recepcionista(string nome, string matricula, double salarioBase, string turno): base (nome, matricula, salarioBase)
        {
            this.turno = turno;
        }

    }
}
