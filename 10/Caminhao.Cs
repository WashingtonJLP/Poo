using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Caminhao : Veiculo
    {
        private int eixos;

        public Caminhao(string placa, int horasEstacionado, int eixos) : base(placa, horasEstacionado)
        {
            this.eixos = eixos;
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
