using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class EntregaEconomica : Entrega
    {
        private double pesoKg;
        private const double VALOR_INICIAL = 8.00;
        private const double PRECO_POR_KM = 0.10;
        private const double PRECO_POR_KG = 1.50;

        public EntregaEconomica(int codigo, double distanciaKm, double pesoKg) : base(codigo, distanciaKm)
        {
            this.pesoKg = pesoKg;
        }

        public override double  CalcularFrete()
        {
            double total = (distanciaKm * PRECO_POR_KM) + (pesoKg * PRECO_POR_KG) + VALOR_INICIAL;

            if (distanciaKm > 500)
            {
                double desconto = total * 0.10;

                return total - desconto;
            }

            else {return total; }
            
        }
        public override int CalcularPrazo()
        {
            if (distanciaKm <= 100)
            {
                return 3;
            }

            else if (distanciaKm <= 500)
            {
                return 5;
            }

            else { return 8; }
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
