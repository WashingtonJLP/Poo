using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Moto: Veiculo, IAlugavel
    {
        decimal valor_Diaria;

        public Moto(string placa, string modelo, decimal valor_Diaria): base(placa, modelo)
        {
            this.valor_Diaria = valor_Diaria;
        }

        public decimal CalcularAluguel(int dias)
        {
            return valor_Diaria * dias;
        }
    }
}
