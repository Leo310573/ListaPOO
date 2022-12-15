using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai11
{
    internal class IMC
    {
        private double peso;
        private double altura;
        private double resultado;
        private string r;
        private double x;

        public IMC()
        {
            this.peso = 0;
            this.altura = 0;
            this.x = 0;
        }
        public IMC(double peso, double altura, double x)
        {
            this.peso = peso;
            this.altura = altura;
            this.x = x;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setAltura(double altura)
        {
            this.altura = altura;
        }
        public double getPeso()
        {
            return this.peso;
        }
        public double getaltura()
        {
            return this.altura;
        }
        public double getResultado()
        {
            return this.resultado;
        }
        public void operacao()
        {
            x = this.altura * this.altura;
            resultado = this.peso / this.x;
        }
        public void compara()
        {
            if (this.resultado < 20)
            {
                r = "Abaixo do peso";
            }
            if (this.resultado > 25)
            {
                r = "Acima do peso";
            }
            else
            if (this.resultado >= 20 && this.resultado <= 25)
            {
                r = "Peso ideal";
            }
        }
        public string getR()
        {
            return this.r;
        }
    }
}
