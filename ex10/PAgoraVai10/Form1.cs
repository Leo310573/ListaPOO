using System;
using System.Windows.Forms;

namespace PAgoraVai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Terreno terreno;
            terreno = new Terreno();
            double.Parse(txtPrimeiro.Text);
            double.Parse(txtSegundo.Text);
            terreno.tp();
            terreno.tg();

            if (double.Parse(txtPrimeiro.Text) > 100)
            {
                lblTerreno.Text = "Terreno Grande";
            }
            else
            {
                lblTerreno.Text = "Terreno pequeno";
            }

        }
    }
}
