using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class ProdutoPerecivel:Produto, IDescontavel
    {
        DateTime data_validade;

        public ProdutoPerecivel(string codigo, string nome, decimal preco, int quantidade, DateTime data_validade ): base(codigo, nome, preco, quantidade)
        {
            this.data_validade = data_validade;
        }

        public int DiasParaVencer()
        {
            TimeSpan diferenca = data_validade.Date - DateTime.Today;
            return diferenca.Days;
        }

        public decimal CalcularPrecoFinal()
        {
            int dias = DiasParaVencer();

            if (dias < 0)
            {
                return 0m;
            }
            else if (dias == 0)
            {
                return Preco - (Preco * 0.70m);
            }
            else if (dias <= 3)
            {
                return Preco - (Preco * 0.40m);
            }
            else if (dias <= 7)
            {
                return Preco - (Preco * 0.20m);
            }
            else
            {
                return Preco;
            }
        }
    }
}
