using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Curso
    {
        private string nome;
        private List<Aluno> alunos;

        public Curso(string nome)
        {
            this.nome = nome;

            alunos = new List<Aluno>(); 
        }

        public void MatricularAluno(Aluno aluno) 
        {
            alunos.Add(aluno);
        }

        public double CalcularTotalMensalidades()
        {
            double soma = 0;

            foreach (Aluno aluno in alunos)
            {
                soma += aluno.CalcularMensalidade();
            }

            return soma;
        }
    }
}
