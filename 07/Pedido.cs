using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Pedido
    {
        private const int NUMERO_PEDIDO_INICIAL = 1000;
        private static int totalPedidosCriados;
        private int numero;
        private Cliente cliente;
        private List<ItemPedido> itens;

        public Pedido(Cliente cliente)
        {
            this.cliente = cliente;
            totalPedidosCriados++;
            this.numero = NUMERO_PEDIDO_INICIAL + totalPedidosCriados;
            

            this.itens = new List<ItemPedido>();
        }

        public void AdicionarItem(string nomeProduto, double precoUnitario, int quantidade)
        {
            ItemPedido item = new ItemPedido(nomeProduto, precoUnitario, quantidade);
            itens.Add(item);
        }

        public double CalcularTotalPedido()
        {
            double total = 0;

            foreach (ItemPedido item in itens)
            {
                total += item.CalcularSubtotal();
            }

            return total;
        }

        public void ExibirPedido()
        {
            Console.WriteLine($"Pedido: {numero}");

            cliente.ExibirDados();

            Console.WriteLine("Itens:");

            foreach (ItemPedido item in itens)
            {
                item.ExibirItem();
            }

            Console.WriteLine($"Total: R$ {CalcularTotalPedido():F2}");
            Console.WriteLine("=============================");
        }

        public static int ObterTotalPedidosCriados()
        {
            return totalPedidosCriados;
        }

    }
}
