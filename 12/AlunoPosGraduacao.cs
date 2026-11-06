using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class AlunoPosGraduacao : Aluno
    {
        private double frequencia;

        public AlunoPosGraduacao(string nome, string matricula, double[] notas, double frequencia) : base(nome, matricula, notas)
        {
            this.frequencia = frequencia;
        }

        public override string Situacao()
        {
            if (Media() >= 7 && frequencia >= 85)
            {
                return "Aprovado";
            }
            else if (frequencia < 85)
            {
                return "Reprovado por frequência";
            }
            else
            {
                return "Reprovado por média";
            }
        }
    }
}
