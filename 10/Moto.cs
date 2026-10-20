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
        private const double VALOR_HORA = 5.00;
        private const double TAXA_CILINDRADA = 3.00;
        private const double DESCONTO_5 = 0.05;
        private const double DESCONTO_10 = 0.10;

        public Moto(string placa, int horasEstacionado, int cilindradas) : base(placa, horasEstacionado)
        {
            this.cilindradas = cilindradas;
        }

        public override double CalcularValor()
        {
            double valorTotal = horasEstacionado * VALOR_HORA;

            return this.cilindradas > 500 ? valorTotal + (horasEstacionado * TAXA_CILINDRADA) : valorTotal;
        }

        public override double CalcularDesconto()
        {
            if (horasEstacionado <= 5)
            {
                return 0.00;
            }

            else if (horasEstacionado <= 10)
            {
                return CalcularValor() * DESCONTO_5;
            }

            else { return CalcularValor() * DESCONTO_10; }
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Horas Estacionado: {horasEstacionado}");
            Console.WriteLine($"Cilindradas: {cilindradas}");
            Console.WriteLine($"Valor bruto: {CalcularValor().ToString("C2")}");
            Console.WriteLine($"Desconto: {CalcularDesconto().ToString("C2")}");
            Console.WriteLine($"Valor final {(CalcularValor() - CalcularDesconto()).ToString("C2")}");
        }
    }
}
