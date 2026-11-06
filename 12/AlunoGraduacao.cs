using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class AlunoGraduacao : Aluno
    {
        public AlunoGraduacao(string nome, string matricula, double[] notas) : base(nome, matricula, notas)
        {

        }

        public override string Situacao()
        {
            return Media() >= 6 ? "Aprovado" : "Reprovado";
        }
    }
}
