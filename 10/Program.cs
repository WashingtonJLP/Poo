using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("ABC-1234", 5, true);
            Carro carro2 = new Carro("DEF-5678", 12, false);

            Moto moto1 = new Moto("GHI-9012", 4, 300);
            Moto moto2 = new Moto("JKL-3456", 12, 600);

            Caminhao caminhao1 = new Caminhao("MNO-7890", 10, 2);
            Caminhao caminhao2 = new Caminhao("PQR-1234", 24, 5);

            List<Veiculo> veiculos = new List<Veiculo>()
            {
                carro1,
                carro2,
                moto1,
                moto2,
                caminhao1,
                caminhao2
            };

            double totalArrecadado = 0;
            double maiorValorPago = 0;
            Veiculo veiculoComMaiorValorPago = null;
            int veiculosMaisDezHoras = 0;
            int totalHoras = 0;

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.ExibirDados();
                Console.WriteLine("========================");

                double valorFinal = veiculo.CalcularValor() - veiculo.CalcularDesconto();

                totalArrecadado += valorFinal;
                totalHoras += veiculo.ObterHorasEstacionado();

                if (valorFinal > maiorValorPago)
                {
                    maiorValorPago = valorFinal;
                    veiculoComMaiorValorPago = veiculo;
                }

                if (veiculo.ObterHorasEstacionado() > 10)
                {
                    veiculosMaisDezHoras++;
                }
                
            }

            Console.WriteLine("=========================");
            Console.WriteLine($"Total arrecadado pelo estacionamento: {totalArrecadado.ToString("C2")}");
            Console.WriteLine("=========================");
            Console.WriteLine($"Maior valor final pago: {maiorValorPago.ToString("C2")}");
            Console.WriteLine("=========================");
            Console.WriteLine("Veículo que pagou o maior valor:");
            veiculoComMaiorValorPago.ExibirDados();
            Console.WriteLine("=========================");
            Console.WriteLine($"Quantidade de veiculos que ficaram estacionados mais de 10 horas: {veiculosMaisDezHoras}");
            Console.WriteLine("=========================");
            Console.WriteLine($"Media de horas estacionada {(totalHoras/veiculos.Count)}");
            Console.WriteLine("=========================");
            Console.WriteLine($"Total de veiculos criados {Veiculo.ObterTotalVeiculos()}");

            


        }
    }
}
