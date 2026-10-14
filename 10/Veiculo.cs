using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal abstract class Veiculo
    {
        protected string placa;
        protected int horasEstacionado;
        private static int totalVeiculos = 1;

        public Veiculo(string placa, int horasEstacionado)
        {
            this.placa = placa;
            this.horasEstacionado = horasEstacionado;

            totalVeiculos++;
        }

        public abstract double CalcularValor();
        public abstract double CalcularDesconto();
        public abstract void ExibirDados();

        public static int ObterTotalVeiculos()
        {
            return totalVeiculos;
        }

    }
}
