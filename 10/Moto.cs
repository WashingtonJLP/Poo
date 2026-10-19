using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Moto : Veiculo
    {
        private int cilindradas;

        public Moto(string placa, int horasEstacionado, int cilindradas) : base(placa, horasEstacionado)
        {
            this.cilindradas = cilindradas;
        }

        public override double CalcularValor()
        {
            return -1;
        }

        public override double CalcularDesconto()
        {
            return -1;
        }

        public override void ExibirDados()
        {

        }
    }
}
