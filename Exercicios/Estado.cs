using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Estado
    {
        private string descricao;

        public Estado(string descricao) 
        {
            this.descricao = descricao;
        }
         public string DESCRICAO
            {
             get { return descricao; }
            }
        
    }
}
