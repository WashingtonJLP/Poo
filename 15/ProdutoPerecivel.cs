using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class ProdutoPerecivel : Produto, IAlertavel
    {
        private DateTime data_validade;

        public ProdutoPerecivel(string codigo, string nome, double preco,
            int quantidade, DateTime data_validade)
            : base(codigo, nome, preco, quantidade)
        {
            this.data_validade = data_validade;
        }

        public bool VenceEm(int dias)
        {
            DateTime data_limite = DateTime.Today.AddDays(dias);

            if (data_validade >= DateTime.Today &&
                data_validade <= data_limite)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Alerta()
        {
            int dias = (data_validade - DateTime.Today).Days;

            return $"ATENÇÃO: {Nome} vence em {dias} dias ({data_validade:dd/MM/yyyy})";
        }
    }
}