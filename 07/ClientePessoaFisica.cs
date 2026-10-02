using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class ClientePessoaFisica: Cliente
    {
        private const int TAMANHO_CPF_FORMATADO = 14;
        private string cpf;

        public ClientePessoaFisica(string nome, string email, string cpf): base (nome, email)
        {
            if (cpf.Length == TAMANHO_CPF_FORMATADO) 
            {
                this.cpf = cpf;
            }
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\n" +
                              $"Email: {email}\n" +
                              $"CPF: {cpf}");
        }
    }
}
