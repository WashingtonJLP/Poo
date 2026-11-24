
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAlugavel> alugueis = new List<IAlugavel>();

            Console.Write("Quantos veículos deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Carro");
                Console.WriteLine("2 - Moto");
                Console.Write("Escolha o tipo: ");
                int tipo = int.Parse(Console.ReadLine());

                Console.Write("Placa: ");
                string placa = Console.ReadLine();

                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();

                Console.Write("Valor da diária: ");
                decimal valorDiaria = decimal.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    Carro carro = new Carro(placa, modelo, valorDiaria);
                    alugueis.Add(carro);
                }
                else if (tipo == 2)
                {
                    Moto moto = new Moto(placa, modelo, valorDiaria);
                    alugueis.Add(moto);
                }
                else
                {
                    Console.WriteLine("Tipo inválido!");
                }
            }

            Console.WriteLine();
            Console.Write("Quantos dias de aluguel? ");
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("===== RESUMO DOS ALUGUÉIS =====");

            decimal totalGeral = 0;

            foreach (IAlugavel aluguel in alugueis)
            {
                decimal valor = aluguel.CalcularAluguel(dias);

                Console.WriteLine(
                    $"Tipo: {aluguel.GetType().Name} | " +
                    $"Valor: {valor:C2}"
                );

                totalGeral += valor;
            }

            Console.WriteLine();
            Console.WriteLine($"Total geral: {totalGeral:C2}");
        }
    }
}