using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacao revistinha = new RevistaEmQuadrinhos("Turma da Monica", 100, "Vermelho", 39.90 , "Cebolinha");

            Console.WriteLine(revistinha.PrecoCusto());
        }
    }
}
