using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("P (coeficientes do maior grau para o menor): ");

            double[] coeficientesP = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Console.Write("Q (coeficientes do maior grau para o menor): ");

            double[] coeficientesQ = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            Polinomio p = new Polinomio(coeficientesP);
            Polinomio q = new Polinomio(coeficientesQ);

            Console.WriteLine();

            Console.WriteLine($"P = {p}");
            Console.WriteLine($"Q = {q}");

            Polinomio soma = p + q;
            Polinomio produto = p * q;
            Polinomio derivada = p.Derivada();

            Console.WriteLine($"P + Q = {soma}");
            Console.WriteLine($"P * Q = {produto}");
            Console.WriteLine($"P' = {derivada}");

            Console.WriteLine();

            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine($"P({x}) = {p.Avaliar(x)}");
            Console.WriteLine($"Q({x}) = {q.Avaliar(x)}");
        }
    }
}