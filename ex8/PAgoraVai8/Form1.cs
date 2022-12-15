using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAgoraVai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comparacao comparacao;
            comparacao = new Comparacao(
                double.Parse(txtPrimeiro.Text),
                double.Parse(txtSegundo.Text));
            comparacao.comp1();
            comparacao.comp2();

            if (double.Parse(txtPrimeiro.Text) > double.Parse(txtSegundo.Text))
            {
                lblResultado.Text = "Primeiro";
            }
            else
            {
                lblResultado.Text = "Segundo";
            }
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
