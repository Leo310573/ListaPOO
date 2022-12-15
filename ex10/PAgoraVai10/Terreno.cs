using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai10
{
    internal class Terreno
    {
        private double a1;
        private double b2;
        private string resultado;
        private double r;

        public Terreno()
        {
            this.a1 = 0;
            this.b2 = 0;
            this.r = 0;
            
        }
        public Terreno(double a1, double b2, double r)
        {
            this.a1 = a1;
            this.b2 = b2;
            this.r = r; 
            
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
            this.r = this.a1 * this.b2;
        }
        public void tg()
        {
            if (this.r >= 100)
            {
                this.resultado = "Terreno grande";
            }
        }
        public void tp()
        {
            if (this.r <= 99)
            {
                this.resultado = "Terreno pequeno";
            }
        }
        public string getResultado()
        {
            return this.resultado;
        }
    }
}
