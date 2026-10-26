using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Documentario : Conteudo
    {
        private bool producaoNacional;

        private const double VALOR_BASE = 10.00;
        private const double DESCONTO_NACIONAL = 0.20;

        public Documentario(
            string titulo,
            int duracaoMinutos,
            bool producaoNacional
        ) : base(titulo, duracaoMinutos)
        {
            this.producaoNacional = producaoNacional;
        }

        public override double CalcularCusto()
        {
            return producaoNacional
                ? VALOR_BASE - (VALOR_BASE * DESCONTO_NACIONAL)
                : VALOR_BASE;
        }

        public override void ExibirDados()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine("Tipo: Documentário");
            Console.WriteLine($"Duração: {duracaoMinutos} minutos");

            Console.WriteLine(
                $"Produção nacional: {(producaoNacional ? "Sim" : "Não")}"
            );

            Console.WriteLine($"Custo: {CalcularCusto().ToString("C2")}");
        }
    }
}