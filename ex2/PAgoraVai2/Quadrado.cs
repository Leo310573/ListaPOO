using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai2
{
    internal class Quadrado
    {
        private double a1;
        private double a2;
        private double resultado;

        public Quadrado()
        {
            this.a1 = 0;
            this.a2 = 0;
            this.resultado = 0; 
        }
        public Quadrado(double a1, double a2, double resultado)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.resultado = resultado; 

        }
        public void setA1(double a1)
        {
            this.a1 = a1;
        }
        public void setA2(double a2)
        {
            this.a2 = a2;
        }
        public double getA1()
        {
            return this.a1;
        }
        public double getA2()
        {
            return this.a2;
        }
        public double getResultado()
        {
            return this.resultado;
        }
        public void Multiplicar()
        {
            this.resultado = this.a1 * this.a2;
        }
    }
}
