using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Cidade
    {
        private string descricao;
        private Estado estado;

        public Cidade(string descricao, Estado estado)
        {
            this.descricao = descricao;
            this.estado = estado;
        }

        public string DESCRICAO
        {
            get { return descricao; }
        }

        public Estado ESTADO
        {
            get { return estado; }
        }
       
    }
}
