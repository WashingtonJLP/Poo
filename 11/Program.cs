using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filme filme1 = new Filme("Horizonte Final", 120, true);
            Filme filme2 = new Filme("Código Perdido", 95, false);

            Serie serie1 = new Serie("Cidade Digital", 480, 8);
            Serie serie2 = new Serie("Último Servidor", 720, 12);

            Documentario documentario1 =
                new Documentario("Brasil Selvagem", 90, true);

            Documentario documentario2 =
                new Documentario("Além do Oceano", 110, false);


            List<Conteudo> conteudos = new List<Conteudo>()
            {
                filme1,
                filme2,
                serie1,
                serie2,
                documentario1,
                documentario2
            };


            double custoTotal = 0;
            double maiorCusto = 0;
            int totalMinutos = 0;

            Conteudo conteudoMaisCaro = null;


            foreach (Conteudo conteudo in conteudos)
            {
                conteudo.ExibirDados();

                Console.WriteLine("========================");

                double custo = conteudo.CalcularCusto();

                custoTotal += custo;
                totalMinutos += conteudo.ObterDuracao();

                if (custo > maiorCusto)
                {
                    maiorCusto = custo;
                    conteudoMaisCaro = conteudo;
                }
            }


            double mediaDuracao =
                (double)totalMinutos / conteudos.Count;


            Console.WriteLine("===== RESUMO =====");

            Console.WriteLine(
                $"Custo total: {custoTotal.ToString("C2")}"
            );

            Console.WriteLine(
                $"Maior custo: {maiorCusto.ToString("C2")}"
            );

            Console.WriteLine(
                $"Média de duração: {mediaDuracao:F2} minutos"
            );

            Console.WriteLine(
                $"Total de conteúdos: {Conteudo.ObterTotalConteudos()}"
            );

            Console.WriteLine("========================");
            Console.WriteLine("Conteúdo mais caro:");

            conteudoMaisCaro.ExibirDados();
        }
    }
}