using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class ContaPoupanca: Conta
    {
        private double taxarendimento;

        public ContaPoupanca(string numero, string titular, double taxarendimento) : base(numero, titular)
        {
            if (taxarendimento > 0)
            {
                this.taxarendimento = taxarendimento;
            }
            else { Console.WriteLine("Taxa de rendimento tem que ser maior que zero"); }
        }
        public void AplicarRendimento()
        {
            if (saldo > 0)
            {
                double rendimento = (saldo * taxarendimento) / 100;
                saldo += rendimento;
            }

            else { Console.WriteLine("Saldo menor ou igual a zero, não foi possivel aplicar rendimento"); }
        }
    }
}
