using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();

            Console.Write("Quantos alunos deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("\nG - Graduação");
                Console.WriteLine("P - Pós-graduação");
                Console.Write("Tipo: ");
                string tipo = Console.ReadLine().ToUpper();

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Matrícula: ");
                string matricula = Console.ReadLine();

                double[] notas = new double[3];

                for (int j = 0; j < notas.Length; j++)
                {
                    Console.Write($"Nota {j + 1}: ");
                    notas[j] = double.Parse(Console.ReadLine());
                }

                if (tipo == "G")
                {
                    AlunoGraduacao aluno = new AlunoGraduacao(
                        nome,
                        matricula,
                        notas
                    );

                    alunos.Add(aluno);
                }
                else if (tipo == "P")
                {
                    Console.Write("Frequência (%): ");
                    double frequencia = double.Parse(Console.ReadLine());

                    AlunoPosGraduacao aluno = new AlunoPosGraduacao(
                        nome,
                        matricula,
                        notas,
                        frequencia
                    );

                    alunos.Add(aluno);
                }
            }

            Console.WriteLine("\n--- BOLETIM ---");

            foreach (Aluno aluno in alunos)
            {
                string tipo;

                if (aluno is AlunoGraduacao)
                {
                    tipo = "Grad";
                }
                else
                {
                    tipo = "Pós";
                }

                Console.WriteLine(
                    $"Nome: {aluno.Nome} | Tipo: {tipo} | Média: {aluno.Media():F2} | Situação: {aluno.Situacao()}"
                );
            }
        }
    }
}