using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAgoraVai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dolar dolar;
            dolar = new Dolar(

                double.Parse(txtCotacao.Text),
                double.Parse(txtDolar.Text),
                double.Parse(txtReais.Text));
            dolar.operacao();
        }
    }
}
