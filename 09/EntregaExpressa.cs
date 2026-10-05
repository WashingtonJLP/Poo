using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class EntregaExpressa : Entrega
    {
        private double pesoKg;
        private const double VALOR_INICIAL = 20.00;
        private const double PRECO_POR_KM = 0.20;
        private const double PRECO_POR_KG = 3.00;
        private const int TAXA = 25;

        public EntregaExpressa(int codigo, double distanciaKm, double pesoKg) : base(codigo, distanciaKm)
        {
            this.pesoKg = pesoKg;
        }

        public override double CalcularFrete()
        {
            double total = (distanciaKm * PRECO_POR_KM) + (pesoKg * PRECO_POR_KG) + VALOR_INICIAL;

            if (pesoKg > 10)
            {
                return total + TAXA;
            }

            else { return total; }
        }

        public override int CalcularPrazo()
        {
            if (distanciaKm <= 200)
            {
                return 1;
            }

            else if (distanciaKm <= 700)
            {
                return 2;
            }

            else { return 3; }
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Codigo: {codigo}");
            Console.WriteLine($"Distancia: {distanciaKm}");
            Console.WriteLine($"Peso: {pesoKg}");
            Console.Write("Valor do frete: ");
            Console.WriteLine(CalcularFrete().ToString("C2"));
            Console.Write("Prazo de entrega: ");
            Console.WriteLine($"{CalcularPrazo()} dias");
        }
    }
}
