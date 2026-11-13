using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Polinomio
    {
        private double[] coeficientes;


        public Polinomio(params double[] coeficientes)
        {
            this.coeficientes = new double[coeficientes.Length];

            for (int i = 0; i < coeficientes.Length; i++)
            {
                this.coeficientes[i] = coeficientes[i];
            }
        }

    
        public Polinomio(Polinomio outro)
        {
            coeficientes = new double[outro.coeficientes.Length];

            for (int i = 0; i < outro.coeficientes.Length; i++)
            {
                coeficientes[i] = outro.coeficientes[i];
            }
        }

   
        public static Polinomio Monomio(double coef, int grau)
        {
            double[] valores = new double[grau + 1];

            valores[0] = coef;

            return new Polinomio(valores);
        }

     
        public double Avaliar(double x)
        {
            double resultado = 0;

            foreach (double coef in coeficientes)
            {
                resultado = resultado * x + coef;
            }

            return resultado;
        }

      
        public Polinomio Derivada()
        {
            if (coeficientes.Length <= 1)
            {
                return new Polinomio(0);
            }

            double[] derivada = new double[coeficientes.Length - 1];

            int grau = coeficientes.Length - 1;

            for (int i = 0; i < derivada.Length; i++)
            {
                derivada[i] = coeficientes[i] * (grau - i);
            }

            return new Polinomio(derivada);
        }

     
        public static Polinomio operator +(Polinomio p, Polinomio q)
        {
            int tamanho = Math.Max(
                p.coeficientes.Length,
                q.coeficientes.Length);

            double[] resultado = new double[tamanho];

            int deslocamentoP = tamanho - p.coeficientes.Length;
            int deslocamentoQ = tamanho - q.coeficientes.Length;

            for (int i = 0; i < p.coeficientes.Length; i++)
            {
                resultado[i + deslocamentoP] += p.coeficientes[i];
            }

            for (int i = 0; i < q.coeficientes.Length; i++)
            {
                resultado[i + deslocamentoQ] += q.coeficientes[i];
            }

            return new Polinomio(resultado);
        }

        
        public static Polinomio operator *(Polinomio p, Polinomio q)
        {
            double[] resultado = new double[
                p.coeficientes.Length + q.coeficientes.Length - 1];

            for (int i = 0; i < p.coeficientes.Length; i++)
            {
                for (int j = 0; j < q.coeficientes.Length; j++)
                {
                    resultado[i + j] +=
                        p.coeficientes[i] * q.coeficientes[j];
                }
            }

            return new Polinomio(resultado);
        }

       
        public override bool Equals(object obj)
        {
            if (obj is Polinomio)
            {
                Polinomio outro = (Polinomio)obj;

                if (coeficientes.Length != outro.coeficientes.Length)
                {
                    return false;
                }

                for (int i = 0; i < coeficientes.Length; i++)
                {
                    if (coeficientes[i] != outro.coeficientes[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            int hash = 17;

            foreach (double coef in coeficientes)
            {
                hash = hash * 31 + coef.GetHashCode();
            }

            return hash;
        }

        public override string ToString()
        {
            string resultado = "";
            int grau = coeficientes.Length - 1;

            for (int i = 0; i < coeficientes.Length; i++)
            {
                double coef = coeficientes[i];
                int expoente = grau - i;

                if (coef == 0)
                {
                    continue;
                }

                if (resultado != "")
                {
                    if (coef > 0)
                    {
                        resultado += " + ";
                    }
                    else
                    {
                        resultado += " - ";
                    }
                }
                else if (coef < 0)
                {
                    resultado += "-";
                }

                double valor = Math.Abs(coef);

                if (valor != 1 || expoente == 0)
                {
                    resultado += valor;
                }

                if (expoente > 0)
                {
                    resultado += "x";

                    if (expoente > 1)
                    {
                        resultado += "^" + expoente;
                    }
                }
            }

            if (resultado == "")
            {
                return "0";
            }

            return resultado;
        }
    }
}