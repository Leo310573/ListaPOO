using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai8
{
    internal class Comparacao
    {
        private double v1;
        private double v2;
        private double m;

        public Comparacao()
        {
            this.v1 = 0;
            this.v2 = 0;
            
        }
        public Comparacao(double v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            
        }


        public void setV1(double v1)
        {
            this.v1 = v1;
        }
        public void setV2(double v2)
        {
            this.v2 = v2;
        }
        public double getV1()
        {
            return this.v1;
        }
        public double getV2()
        {
            return this.v2;
        }
        public void comp1()
        {
            if (this.v1 > this.v2)
            {
                this.m = this.v1;
            }
        }
        public void comp2()
        {
            if (this.v2 > this.v1)
            {
                this.m = this.v2;
            }
        }
        public double getM()
        {
            return this.m;
        }
    }
}
