using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class EntregaInternacional : Entrega
    {
        private double pesoKg;
        private double taxaImportacao;
        private const double VALOR_INICIAL = 50.00;
        private const double PRECO_POR_KM = 0.30;
        private const double PRECO_POR_KG = 5.00;

        public EntregaInternacional(int codigo, double distanciaKm, double pesoKg, double taxaImportacao) : base(codigo, distanciaKm)
        {
            this.pesoKg = pesoKg;
            this.taxaImportacao = taxaImportacao;
        }

        public override double CalcularFrete()
        {
            double total = (distanciaKm * PRECO_POR_KM) + (pesoKg * PRECO_POR_KG) + VALOR_INICIAL;
            double taxa = (total * taxaImportacao) / 100;

            if (pesoKg > 20)
            {
                return total + taxa + 100;
            }

            else { return total + taxa; }
        }

        public override int CalcularPrazo()
        {
            int prazo = 10;

            if (distanciaKm > 3000)
            {
                prazo += 3;
            }

            if (pesoKg > 20)
            {
                prazo += 2;
            }

            return prazo;
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

