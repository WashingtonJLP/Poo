using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estado e1 = new Estado("Minas Gerais");
            Cidade c1 = new Cidade("Belo Horizonte", e1);
            Endereco end1 = new Endereco("Rua Walter Ianni", "255", "São Gabriel", c1);

            Console.WriteLine(end1.EnderecoCompleto());
        }
    }
}
