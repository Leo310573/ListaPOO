using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai3
{
    internal class Quadrado
    {
        private double d1;
        private double l2;
        private double resultado;

        public Quadrado()
        {
            this.d1 = 0;
            this.l2 = 0;

        }
        public Quadrado(double d1, double l2)
        {
            this.d1 = d1;
            this.l2 = l2;

        }
        public void setD1(double d1)
        {
            this.d1 = d1;
        }
        public void setL2(double l2)
        {
            this.l2 = l2;
        }
        public double getD1()
        {
            return this.d1;
        }
        public double getL2()
        {
            return this.l2;
        }
        public double getResultado()
        {
            return this.resultado;
        }
        public void operacaolado()
        {
            this.l2 = this.d1 / Math.Sqrt(2);
        }
        public void operacao()
        {
            this.resultado = Math.Pow(l2, 2);
        }
    }
}
