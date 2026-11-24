using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Produto
    {
        string codigo;
        string nome;
        decimal preco;
        int quantidade;

        public Produto(string codigo, string nome, decimal preco, int quantidade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public virtual decimal ValorEstoque()
        {
            return preco * quantidade;
        }

        public string NOME
        {
            get { return nome; }
        }

        public string CODIGO
        {
            get { return codigo; }
        }

        public int QUANTIDADE
        {
            get { return quantidade; }
        }


    }
}
