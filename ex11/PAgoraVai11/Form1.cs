using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAgoraVai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IMC imc;
            imc = new IMC();

            double.Parse(txtSegundo.Text);
            double.Parse(txtPrimeiro.Text);
            imc.compara();
            imc.getResultado();
            

            if (imc.getResultado() > 20)
            {
                lblResultado.Text = "Abaixo do peso";
            }
            if (imc.getResultado() > 25)
            {
                lblResultado.Text = "Acima do peso";
            }
            else
           if (imc.getResultado() >= 20 && imc.getResultado() <= 25)
            {
                lblResultado.Text = "Peso ideal";
            }




        }
    }
}
