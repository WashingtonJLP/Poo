using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo("Circulo", 10);
            Quadrado q1 = new Quadrado("Quadro" ,5);
            Retangulo r1 = new Retangulo("Retangulo", 6 , 7);

            List<Forma> formas;
            formas = new List<Forma>();

            formas.Add(c1);
            formas.Add(q1);
            formas.Add(r1);

            foreach (Forma forma in formas)
            {
                forma.ExibirDados();
            }

        }
    }
}
