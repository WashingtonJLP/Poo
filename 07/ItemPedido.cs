using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class ItemPedido
    {
        private const int QUANTIDADE_MAXIMA = 100;
        private static int totalItensCriados;
        private string nomeProduto;
        private double precoUnitario;
        private int quantidade;

        public ItemPedido(string nomeProduto, double precoUnitario, int quantidade)
        {
            this.nomeProduto = nomeProduto;
            this.precoUnitario = precoUnitario;

            if (quantidade > QUANTIDADE_MAXIMA)
            {
                this.quantidade = QUANTIDADE_MAXIMA;
            }
            else
            {
                this.quantidade = quantidade;
            }

            totalItensCriados++;
        }

        public double CalcularSubtotal()
        {
            return precoUnitario * quantidade;
        }

        public void ExibirItem()
        {
            Console.WriteLine($"Nome do Produto {nomeProduto} \n" +
                $"Preço unitario {precoUnitario}\n" +
                $"Quantidade {quantidade}");
        }

        public static int ObterTotalItensCriado()
        {
            return totalItensCriados;
        }

        

    }
}
