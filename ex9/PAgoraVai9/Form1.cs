using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAgoraVai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comparacao02 comparacao02;
            comparacao02 = new Comparacao02(

                double.Parse(txtPrimeiro.Text),
                double.Parse(txtSegundo.Text));
            comparacao02.compara();
                
                if (double.Parse(txtPrimeiro.Text) > double.Parse(txtSegundo.Text))
            {
                lblResultado.Text = "Primeiro";
            }
            else
            {
                lblResultado.Text = "Segundo";
            }
              if (double.Parse(txtPrimeiro.Text) == double.Parse(txtSegundo.Text))
            {
                lblResultado.Text = "ERRO!! Os valores são iguais";
            }


        }
    }
}
