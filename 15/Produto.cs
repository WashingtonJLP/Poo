using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Produto : IComparable<Produto>
    {
        private string codigo;
        private string nome;
        private double preco;
        private int quantidade;

        public Produto(string codigo, string nome, double preco): this (codigo, nome, preco, 0)
        {
            
        }
        public Produto(string codigo, string nome, double preco, int quantidade) 
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public int CompareTo(Produto other)
        {
            return this.nome.CompareTo(other.nome);
        }
    }
}
