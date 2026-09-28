using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente c1 = new ContaCorrente("802", "Junio Lima", 5 );

          
            c1.DepositarValor(1000);
            Console.WriteLine(c1.CalculaSaldoDisponivel());
            c1.Sacar(5);
            Console.WriteLine(c1.CalculaSaldoDisponivel()); 

            ContaPoupanca c2 = new ContaPoupanca("804","Joao", 50);
            c2.DepositarValor(1000);
            c2.AplicarRendimento();
            Console.WriteLine(c2.CalculaSaldoDisponivel()); 

        }
    }
}
