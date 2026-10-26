using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal abstract class Conteudo
    {
        protected string titulo;
        protected int duracaoMinutos;
        private static int totalConteudos = 0;

        public Conteudo(string titulo, int duracaoMinutos)
        {
            this.titulo = titulo;
            this.duracaoMinutos = duracaoMinutos;
            totalConteudos++;
        }

        public abstract double CalcularCusto();

        public abstract void ExibirDados();

        public int ObterDuracao()
        {
            return duracaoMinutos;
        }

        public static int ObterTotalConteudos()
        {
            return totalConteudos;
        }
    }
}