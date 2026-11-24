using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Veiculo
    {
        private string placa;
        private string modelo;

        public Veiculo(string placa, string modelo)
        {
            this.placa = placa;
            this.modelo = modelo;
        }

        public string Placa
        {
            get { return placa; }
        }

        public string Modelo
        {
            get { return modelo; }
        }
    }
}
