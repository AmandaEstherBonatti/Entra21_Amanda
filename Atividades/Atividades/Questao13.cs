using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Questao13 : Form
    {
        int anoNascimeto = 0;
      
        public Questao13()
        {
            InitializeComponent();
        }

        private void txtNascimento_TextChanged(object sender, EventArgs e)
        {
            anoNascimeto = int.Parse(txtNascimento.Text);
        }

        private void bntResultado_Click(object sender, EventArgs e)
        {
            int idadeEmAnos = 2021 - anoNascimeto;
            int idadeEmMeses = idadeEmAnos * 12;
            int idadeEmDias = idadeEmAnos * 365;

            MessageBox.Show($"Sua idade em anos é:{idadeEmAnos} \n" +
                            $"Sua idade em meses é:{idadeEmMeses} \n " +
                            $"Sua idade em dias é:{idadeEmDias}");
        }
    }
}
