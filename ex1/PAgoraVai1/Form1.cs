using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAgoraVai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retangulo retangulo;
            retangulo = new Retangulo(
                int.Parse(txtAltura.Text),
                int.Parse(txtBase.Text),
                int.Parse(txtArea1.Text));
            retangulo.calcular();

        }
    }
}
