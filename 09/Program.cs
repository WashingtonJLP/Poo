using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EntregaEconomica e1 = new EntregaEconomica(101, 80, 5);
            EntregaEconomica e2 = new EntregaEconomica(102, 650, 12);

            EntregaExpressa e3 = new EntregaExpressa(103, 150, 8);
            EntregaExpressa e4 = new EntregaExpressa(104, 850, 15);

            EntregaInternacional e5 = new EntregaInternacional(105, 2500, 18, 15);
            EntregaInternacional e6 = new EntregaInternacional(106, 4500, 25, 20);

            List<Entrega> entregas = new List<Entrega>()
    {
        e1,
        e2,
        e3,
        e4,
        e5,
        e6
    };

            double totalFretes = 0;
            double maiorFrete = 0;
            int entregasPrazoMaior5 = 0;
            int somaPrazos = 0;

            Entrega entregaMaisCara = null;

            foreach (Entrega entrega in entregas)
            {
                entrega.ExibirDados();

                double frete = entrega.CalcularFrete();
                int prazo = entrega.CalcularPrazo();

                totalFretes += frete;
                somaPrazos += prazo;

                if (frete > maiorFrete)
                {
                    maiorFrete = frete;
                    entregaMaisCara = entrega;
                }

                if (prazo > 5)
                {
                    entregasPrazoMaior5++;
                }

                Console.WriteLine();
            }

            double mediaPrazo = (double)somaPrazos / entregas.Count;

            Console.WriteLine("===== RESUMO =====");

            Console.WriteLine($"Total dos fretes: {totalFretes:C2}");

            Console.WriteLine($"Entregas com prazo maior que 5 dias: {entregasPrazoMaior5}");

            Console.WriteLine($"Média dos prazos: {mediaPrazo:F2} dias");

            Console.WriteLine($"Total de entregas criadas: {Entrega.ObterTotalEntrega()}");

            Console.WriteLine("\nEntrega com o frete mais caro:");
            entregaMaisCara.ExibirDados();
        }
    }
}
