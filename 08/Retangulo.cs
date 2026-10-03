using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Retangulo : Forma
    {
        private double baseRetangulo;
        private double altura;

        public Retangulo(string nome, double baseRetangulo, double altura) : base(nome)
        {
            this.baseRetangulo = baseRetangulo;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseRetangulo * altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (baseRetangulo + altura);
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Nome {nome}\n" +
                $"Base {baseRetangulo}\n" +
                $"Altura: {altura}");

            Console.WriteLine($"Area do {nome}");
            Console.WriteLine(CalcularArea());

            Console.WriteLine($"Perimetro do {nome}");
            Console.WriteLine(CalcularPerimetro());

          

        }
    }
}

