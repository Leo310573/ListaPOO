using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAgoraVai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quadrado quadrado;
            quadrado = new Quadrado(

                double.Parse(txtArea.Text),
                double.Parse(txtDiagonal.Text));
            quadrado.operacao();
            quadrado.operacaolado();
        }
    }
}
