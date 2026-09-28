using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Aluno
    {
        private string nome;
        private string matricula;
        protected double mensalidade;

        public Aluno(string nome, string matricula, double mensalidade)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.mensalidade = mensalidade;
        }

        public virtual double CalcularMensalidade()
        {
            return mensalidade;
        }

    }
}
