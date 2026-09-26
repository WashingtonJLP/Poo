using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Endereco
    {
        private string logradouro;
        private string numero;
        private string bairro;
        private Cidade cidade;

        public Endereco(string logradouro, string numero, string bairro, Cidade cidade)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public string EnderecoCompleto()
        {
            return this.logradouro + ", " + this.numero + ", " + this.bairro + " - " + cidade.DESCRICAO + " - " + cidade.ESTADO.DESCRICAO;
        }

    }
}
