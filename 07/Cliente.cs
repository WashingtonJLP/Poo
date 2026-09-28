using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Cliente
    {
        protected string nome;
        protected string email;
        private static int totalClientesCriados = 0;

        public Cliente(string nome, string email)
        {
            this.nome = nome;
            this.email = email;

            totalClientesCriados++;
        }

        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\n" +
                $"Email: {email}");
        }

        public static int ObterTotalClientes()
        {
            return totalClientesCriados;
        }
    }
}
