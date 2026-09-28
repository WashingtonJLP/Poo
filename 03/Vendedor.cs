using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Vendedor: Funcionario
    {
        private double totalVendas;
        private double percentualComissao;

        public Vendedor(string nome, string matricula, double salarioBase, double percentualComissao): base (nome, matricula, salarioBase)
        {
            this.percentualComissao = percentualComissao;
        }

        public void RegistrarVenda(double valorvenda)
        {
            totalVendas += valorvenda;
        }

        public override double CalcularSalario()
        {
            double comissaoVendedor = (totalVendas * percentualComissao) / 100;
            return salarioBase + comissaoVendedor;
        
        }
    }
}
