using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAB
{
    public partial class Form1 : Form
    {
        int numero1, numero2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu resutado é {numero1 - numero2}");
        }

        private void btnMultiplicao_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu resutado é {numero1 * numero2}");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu resutado é {numero1 / numero2}");
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu resutado é {numero1 + numero2}");
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            numero2 = int.Parse(textBox2.Text);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            numero1 = int.Parse(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
