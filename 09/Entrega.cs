using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal abstract class Entrega
    {
        protected int codigo;
        protected double distanciaKm;
        private static int totalEntregas;

        public Entrega(int codigo, double distanciaKm)
        {
            this.codigo = codigo;
            this.distanciaKm = distanciaKm;

            totalEntregas++;
        }
        public abstract double CalcularFrete();
        public abstract int CalcularPrazo();
        public abstract void ExibirDados();
        public static int ObterTotalEntrega()
        {
            return totalEntregas;
        }

    }
}
