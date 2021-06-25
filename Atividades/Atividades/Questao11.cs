using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Questao11 : Form
    {
        double cotacao = 0;
        double dolar = 0;

        public Questao11()
        {
            InitializeComponent();
        }

        private void Questao11_Load(object sender, EventArgs e)
        {

        }

        private void cotacaoReal_TextChanged(object sender, EventArgs e)
        {
            cotacao = double.Parse(cotacaoReal.Text);
        }

        private void valorDolar_TextChanged(object sender, EventArgs e)
        {
            dolar = double.Parse(valorDolar.Text);
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{cotacao * dolar}");
        }
    }
}
