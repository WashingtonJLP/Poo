using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Carro : Veiculo
    {
        private bool possuiTag;
        private const double VALOR_HORA = 8.00;
        private const double TAXA_FIXA = 20.00;
        private const double DESCONTO = 0.15;
        public Carro(string placa, int horasEstacionado, bool possuiTag) : base(placa, horasEstacionado)
        {
            this.possuiTag = possuiTag;
        }

        public override double CalcularValor()
        {
            double valorTotal = horasEstacionado * VALOR_HORA;

            return horasEstacionado > 10 ? valorTotal + TAXA_FIXA : valorTotal;
        }

        public override double CalcularDesconto()
        {
            return possuiTag ? CalcularValor() * DESCONTO : 0.00;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Horas estacionado: {horasEstacionado}");
            Console.WriteLine($"Possui Tag {(possuiTag? "Sim" : "Não")}");
            Console.WriteLine($"Valor bruto:{CalcularValor().ToString("C2")}");
            Console.WriteLine($"Desconto: {CalcularDesconto().ToString("C2")}");
            Console.WriteLine($"Valor final {(CalcularValor() - CalcularDesconto()).ToString("C2")}");
        }
    }
}
