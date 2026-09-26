using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Livro: Publicacao
    {
        private double custoPagina;

        public Livro(string titulo, int numpaginas, string cor, double precoVenda, double custoPagina): base (titulo,numpaginas, cor, precoVenda)
        {
            this.custoPagina = custoPagina;
        }

        public override double PrecoCusto()
        {
            return custoPagina * NUMPAGINAS;
        }
    }
}
