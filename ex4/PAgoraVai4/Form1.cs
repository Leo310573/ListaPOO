using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAgoraVai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo triangulo;
            triangulo = new Triangulo(

                double.Parse(txtAltura.Text),
                double.Parse(txtArea.Text),
                double.Parse(txtBase.Text));
            triangulo.operacao();

        }
    }
}
