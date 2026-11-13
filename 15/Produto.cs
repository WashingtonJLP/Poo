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

        public string Codigo
        {
            get { return codigo; }
        }

        public string Nome
        {
            get { return nome; }
        }

        public double Preco
        {
            get { return preco; }
        }

        public int Quantidade
        {
            get { return quantidade; }
        }

        public Produto(string codigo, string nome, double preco)
            : this(codigo, nome, preco, 0)
        {
        }

        public Produto(string codigo, string nome, double preco, int quantidade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public bool DarBaixa(int quantidade)
        {
            if (quantidade > 0 && quantidade <= this.quantidade)
            {
                this.quantidade -= quantidade;
                return true;
            }

            return false;
        }

        public int CompareTo(Produto other)
        {
            return nome.CompareTo(other.nome);
        }

        public override string ToString()
        {
            return $"{nome} - {quantidade} un - R$ {preco:F2}";
        }
    }
}