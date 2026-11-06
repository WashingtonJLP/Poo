using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Aluno
    {
        private string nome;
        private string matricula;
        private double[] notas;

        public Aluno(string nome) : this(nome, "", new double[0])
        {
        }

        public Aluno(string nome, string matricula, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }
        public double Media()
        {
            double soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            return soma / notas.Length;
        }
        public virtual string Situacao()
        {
            return "";
        }

        public string Nome
        {
            get { return nome; }
        }

    }
}
