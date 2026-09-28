using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class ContaCorrente : Conta
    {
        private double taxasaque;
        private int qtdsaques;
        public ContaCorrente(string numero, string titular, double taxasaque) : base(numero, titular)
        {
            if (taxasaque > 0)
            {
                this.taxasaque = taxasaque;
            }
            else { Console.WriteLine("Taxa saque precisa ser maior que 0"); }

        }
        public bool Sacar(double saque)
        {
            if (saque > 0)
            {
                double totalsaque = (saldo * taxasaque) / 100;
                totalsaque += saque;

                if (totalsaque <= saldo)
                {
                    saldo -= totalsaque;
                    this.qtdsaques++;
                    return true;
                }
                else { return false; }
            }
            else { return false; }
        }
    }
}
