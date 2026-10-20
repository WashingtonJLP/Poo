using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Caminhao : Veiculo
    {
        private const double VALOR_HORA = 12;
        private const double DESCONTO_8 = 0.08;
        private const double DESCONTO_15 = 0.15;
        private const double TAXA_EIXOS = 2.50;
        private const double QTD_EIXOS_SEM_ADICIONAL = 2.0;
        private int eixos;

        public Caminhao(string placa, int horasEstacionado, int eixos) : base(placa, horasEstacionado)
        {
            this.eixos = eixos;
        }

        public override double CalcularValor()
        {
            double valorTotal = horasEstacionado * VALOR_HORA;

            return this.eixos > 2 ? (((this.eixos - QTD_EIXOS_SEM_ADICIONAL) * TAXA_EIXOS) * horasEstacionado) + valorTotal : valorTotal;
        }

        public override double CalcularDesconto()
        {
            if (horasEstacionado < 12)
            {
                return 0.00;
            }

            else if (horasEstacionado <= 23)
            {
                return CalcularValor() * DESCONTO_8;
            }

            else { return CalcularValor() * DESCONTO_15; }
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Horas estacionado: {horasEstacionado}");
            Console.WriteLine($"Quantidade de Eixo {this.eixos}");
            Console.WriteLine($"Valor bruto:{CalcularValor().ToString("C2")}");
            Console.WriteLine($"Desconto: {CalcularDesconto().ToString("C2")}");
            Console.WriteLine($"Valor final {(CalcularValor() - CalcularDesconto()).ToString("C2")}");
        }
    }
}
