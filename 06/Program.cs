using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso c1 = new Curso("Sistemas de informação");

            AlunoRegular ar1 = new AlunoRegular("João", "001", 1000);
            AlunoBolsista ab1 = new AlunoBolsista("Maria", "002", 1000, 30);
            AlunoBolsista ab2 = new AlunoBolsista("Carlos", "003", 800, 40);

            c1.MatricularAluno(ar1);
            c1.MatricularAluno(ab1);
            c1.MatricularAluno(ab2);

            Console.WriteLine(ar1.CalcularMensalidade());
            Console.WriteLine(ab1.CalcularMensalidade());
            Console.WriteLine(ab2.CalcularMensalidade());

            Console.WriteLine(c1.CalcularTotalMensalidades());
        }
    }
}
