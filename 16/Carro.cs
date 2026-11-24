using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Carro : Veiculo, IAlugavel
    {

        decimal valor_Diaria;
        public Carro(string placa, string modelo, decimal valor_Diaria) : base(placa, modelo)
        {
            this.valor_Diaria = valor_Diaria;
        }
        public decimal CalcularAluguel(int dias)
        {
            decimal total = this.valor_Diaria * dias;
            return dias >= 7 ? total - (total * 0.10m)  : total;
        }
    }
}
