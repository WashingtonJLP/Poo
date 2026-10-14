using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Carro:Veiculo
    {
        private bool tag;

        public Carro(string placa, int horasEstacionado, bool tag) : base(placa, horasEstacionado)
        {
            this.tag = tag;

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
