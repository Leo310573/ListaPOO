using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai1
{
    internal class Retangulo
    {
        private int n1;
        private int b2;
        private int area;
        public Retangulo()
        {
            this.n1 = 0;
            this.b2 = 0;
            this.area = 0;
        }
        public Retangulo(int n1, int b2, int area)
        {
            this.n1 = n1;
            this.b2 = b2;
            this.area = area;
        }
        public void setN1(int n1)
        {
            this.n1 = n1;
        }
        public void setB2(int b2)
        {
            this.b2 = b2;
        }
        public int getN1()
        {
            return this.n1;
        }
        public int getB2()
        {
            return this.b2;
        }
        public int getarea()
        {
            return this.area;
        }
        public void calcular()
        {
            this.area = this.n1 * this.b2;
        }

    }

}



