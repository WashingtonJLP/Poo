using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor f1 = new Vendedor("Jose Armando", "115115", 3000, 5);

            f1.ExibirDados();
            f1.RegistrarVenda(100000);
            f1.RegistrarVenda(50000);
            Console.WriteLine("Salario total");
            Console.WriteLine(f1.CalcularSalario());

            Administrativo f2 = new Administrativo("Maria", "115116", 1500, "Administrativo");

            f2.ExibirDados();
            Console.WriteLine("Salario total");
            Console.WriteLine(f2.CalcularSalario());

        }

    }
}
