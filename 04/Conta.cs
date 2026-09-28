using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Conta
    {
        private string numero;
        private string titular;
        protected  double saldo;

        public Conta(string numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = 0;
        }
        public void DepositarValor(double valor) 
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine("Valor adicionado");
            }

            else { Console.WriteLine("Valor precisa ser maior que zero para depositar"); }
        }
        public double CalculaSaldoDisponivel()
        {
            return saldo;
        }
    }
}
