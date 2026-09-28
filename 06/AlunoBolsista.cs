using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class AlunoBolsista: Aluno
    {
        private double percentualBolsa;

        public AlunoBolsista(string nome, string matricula, double mensalidade, double percentualBolsa): base(nome, matricula, mensalidade)
        {
            if (percentualBolsa >= 0 && percentualBolsa <= 100)
            {
                this.percentualBolsa = percentualBolsa;
            }
            else { Console.WriteLine("Informe um valor valido válido um percentual de bolsa entre 0 e 100."); }
          

        }

        public override double CalcularMensalidade()
        {
            if (percentualBolsa == 0)
            {
                return mensalidade;
            }

            else
            {
                double desconto = (mensalidade * percentualBolsa) / 100;
                return mensalidade - desconto;
            }
        }
    }
}
