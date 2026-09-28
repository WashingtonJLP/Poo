using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Academia a1 = new Academia();

            Instrutor i1 = new Instrutor("Carlos", "I001", 2000, 50);

            Recepcionista r1 = new Recepcionista("Ana", "R001", 1800, "Noite");

            i1.RegistrarAulas();
            i1.RegistrarAulas();
            i1.RegistrarAulas();

            a1.AdicionarFuncionario(i1);
            a1.AdicionarFuncionario(r1);
           
            Console.WriteLine(a1.CalcularFolha());

        }
    }
}
