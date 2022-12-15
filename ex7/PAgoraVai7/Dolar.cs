using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai7
{
    internal class Dolar
    {
        private double valor1;
        private double valor2;
        private double resultado;

        public Dolar()
        {
            this.valor1 = 0;
            this.valor2 = 0;
            this.resultado = 0;
        }
        public Dolar(double valor1, double valor2, double resultado)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.resultado = resultado;
        }

        public void setValor1(double valor1)
        {
            this.valor1 = valor1;
        }
        public void setValor2(double valor2)
        {
            this.valor2 = valor2;
        }
        public double getValor1()
        {
            return this.valor1;
        }
        public double getValor2()
        {
            return this.valor2;
        }
        public void operacao()
        {
            this.resultado = this.valor1 * this.valor2;
        }
        public double getResultado()
        {
            return this.resultado;
        }
    }
}
