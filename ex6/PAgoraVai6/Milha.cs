using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai6
{
    internal class Milha
    {
        private double valor1;
        private double resultado;

        public Milha()
        {
            this.valor1 = 0;
            this.resultado = 0;
        }
        public Milha(double valor1, double resultado)
        {
            this.valor1 = valor1;
            this.resultado = resultado;
        }

        public void setValor(double valor1)
        {
            this.valor1 = valor1;
        }
        public double getValor()
        {
            return this.valor1;
        }
        public void operacao()
        {
            resultado = this.valor1 * 1852;
        }
        public double getResultado()
        {
            return this.resultado;
        }

    }
}
