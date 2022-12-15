using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai4
{
    internal class Triangulo
    {
        private double a1;
        private double b2;
        private double resultado;

        public Triangulo()
        {
            this.a1 = 0;
            this.b2 = 0;
            this.resultado = 0;
        }
        public Triangulo(double a1, double b2, double resultado)
        {
            this.a1 = a1;
            this.b2 = b2;
            this.resultado = resultado;
        }


        public void setA1(double a1)
        {
            this.a1 = a1;
        }
        public void setB2(double b2)
        {
            this.b2 = b2;
        }
        public double getA1()
        {
            return this.a1;
        }
        public double getB2()
        {
            return this.b2;
        }
        public void operacao()
        {
            this.resultado = this.b2 * this.a1 / 2;
        }
        public double getResultado()
        {
            return this.resultado;
        }
    }
}
