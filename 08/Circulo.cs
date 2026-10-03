using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Circulo : Forma
    {
        private const double pi = 3.14159;
        private double raio;

        public Circulo(string nome, double raio) : base(nome)
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            return pi * Math.Pow(raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * pi * raio;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome {nome}\n" +
                $"Raio: {raio}");

            Console.WriteLine($"Area do {nome}");
            Console.WriteLine(CalcularArea());

            Console.WriteLine($"Perimetro do {nome}");
            Console.WriteLine(CalcularPerimetro());
        }
    }
}
