using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.WriteLine("Quantidade de funcionarios");
            int qtd_funcionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd_funcionarios; i++)
            {
                Console.WriteLine("1-Horista 2-Mensalista 3-Comissionado");
                int tipo = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome");
                string nome = Console.ReadLine();

                Console.WriteLine("Matricula");
                string matricula = Console.ReadLine();

                if (tipo == 1)
                {
                    Console.WriteLine("Informe horas");
                    decimal horas = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Informe o valor das horas");
                    decimal valor_horas = decimal.Parse(Console.ReadLine());

                    Horista horista = new Horista(
                        nome,
                        matricula,
                        horas,
                        valor_horas
                        );

                    funcionarios.Add(horista);
                }

                else if (tipo == 2)
                {
                    Console.WriteLine("Informe o salario fixo");
                    decimal salario_fixo = decimal.Parse(Console.ReadLine());

                    Mensalista mensalista = new Mensalista(
                        nome,
                        matricula,
                        salario_fixo
                        );
                    funcionarios.Add(mensalista);
                }

                else if (tipo == 3)
                {
                    Console.WriteLine("Informe o salario fixo");
                    decimal salario_fixo = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Informe vendas");
                    decimal vendas = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Informe percentual de vendas");
                    decimal percentual_vendas = decimal.Parse(Console.ReadLine());

                    Comissionado comissionado = new Comissionado(
                        nome,
                        matricula,
                        salario_fixo,
                        percentual_vendas,
                        vendas
                        );
                    funcionarios.Add(comissionado);
                }

            }
            decimal total_folha = 0;

            foreach (Funcionario funcionario in funcionarios)
            {

                Console.WriteLine($"Nome: {funcionario.Nome} Tipo ({funcionario.GetType().Name}) Salario: {funcionario.CalcularSalario().ToString("C2")}");

                total_folha += funcionario.CalcularSalario();
            }

            Console.WriteLine($"Total da folha: {total_folha.ToString("C2")}");

        }
    }
}
