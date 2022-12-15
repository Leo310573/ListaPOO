using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAgoraVai9
{
    internal class Comparacao02
    {
        private double v1;
        private double v2;
        private string m;

        public Comparacao02()
        {
            this.v1 = 0;
            this.v2 = 0;
        }
        public Comparacao02(double v1, double v2)
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
        public double getV2()
        {
            return this.v2;
        }
        public double getV1()
        {
            return this.v1;
        }
        public void compara()
        {
            if (this.v1 > this.v2)
            {
                this.m = "1º";
            }
            if (this.v1 < this.v2)
            {
                this.m = "2º";
            }
            else
            if (this.v1 == this.v2)
            {
                this.m = "Ambos os valores são iguais";
            }
        }

        public string getM()
        {
            return this.m;
        }
    }
}
