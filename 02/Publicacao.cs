using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Publicacao
    {
        private string titulo;
        private int numpaginas;
        protected string cor;
        protected double precoVenda;
        public Publicacao(string titulo, int numpaginas, string cor, double precoVenda) 
        {
            this.titulo = titulo;
            this.numpaginas = numpaginas;
            this.cor = cor;
            this.precoVenda = precoVenda;
        }

        public void ColocarPrecoVenda(double preco) 
        {
            precoVenda = preco;
        }

        public int NUMPAGINAS 
        {
            get { return numpaginas; }
        }

        public  virtual double PrecoCusto() 
        {
            return 0;
        }
    }

    
}
