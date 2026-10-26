using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Filme : Conteudo
    {
        private bool lancamento;

        private const double VALOR_BASE = 12.00;
        private const double TAXA_LANCAMENTO = 5.00;

        public Filme(string titulo, int duracaoMinutos, bool lancamento)
            : base(titulo, duracaoMinutos)
        {
            this.lancamento = lancamento;
        }

        public override double CalcularCusto()
        {
            return lancamento
                ? VALOR_BASE + TAXA_LANCAMENTO
                : VALOR_BASE;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine("Tipo: Filme");
            Console.WriteLine($"Duração: {duracaoMinutos} minutos");
            Console.WriteLine($"Lançamento: {(lancamento ? "Sim" : "Não")}");
            Console.WriteLine($"Custo: {CalcularCusto().ToString("C2")}");
        }
    }
}