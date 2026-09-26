using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class RevistaEmQuadrinhos : Publicacao
    {
        private string personagemPrincipal;
        private static double custoPagina = 0.25;

        public RevistaEmQuadrinhos(string titulo, int numpaginas, string cor, double precoVenda, string personagemPrincipal) : base(titulo, numpaginas, cor, precoVenda)
        {
            this.personagemPrincipal = personagemPrincipal;
        }

        public double CUSTOPAGINA
        {
            set { custoPagina = value; }
        }
        public override double PrecoCusto()
        {
            return custoPagina * NUMPAGINAS;
        }
    }
}
