using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Quadrado : Forma
    {
        private double lado;

        public Quadrado(string nome, double lado) : base(nome)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome {nome}\n" +
                    $"Lado: {lado}");

            Console.WriteLine($"Area do {nome}");
            Console.WriteLine(CalcularArea());

            Console.WriteLine($"Perimetro do {nome}");
            Console.WriteLine(CalcularPerimetro());
        }
    }
}
