using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal abstract class  Forma
    {
        protected string nome;

        public Forma(string nome) 
        {
            this.nome = nome;
        }
        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

        public abstract void ExibirDados();
        

    }
}
