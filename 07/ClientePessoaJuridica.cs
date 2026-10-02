using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class ClientePessoaJuridica : Cliente
    {
        private string cnpj;
        private string razaoSocial;

        public ClientePessoaJuridica(string nome, string email, string cnpj, string razaoSocial) : base(nome, email)
        {
            this.cnpj = cnpj;
            this.razaoSocial = razaoSocial;
        }
        public override void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\n" +
                  $"Email: {email}\n" +
                  $"Cnpj: {cnpj}\n" +
                  $"Razão Social {razaoSocial}");
        }
    }
}
