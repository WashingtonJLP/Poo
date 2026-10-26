using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Serie : Conteudo
    {
        private int episodios;

        private const double VALOR_POR_EPISODIO = 2.50;
        private const double DESCONTO = 0.10;

        public Serie(string titulo, int duracaoMinutos, int episodios)
            : base(titulo, duracaoMinutos)
        {
            this.episodios = episodios;
        }

        public override double CalcularCusto()
        {
            double valor = episodios * VALOR_POR_EPISODIO;

            return episodios > 10
                ? valor - (valor * DESCONTO)
                : valor;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine("Tipo: Série");
            Console.WriteLine($"Episódios: {episodios}");
            Console.WriteLine($"Duração: {duracaoMinutos} minutos");
            Console.WriteLine($"Custo: {CalcularCusto().ToString("C2")}");
        }
    }
}