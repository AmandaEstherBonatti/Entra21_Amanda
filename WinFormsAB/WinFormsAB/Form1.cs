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
        int[] historicoCalculadora = new int[100];
        int indiceHistorio = 0;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void BtnSubtracao_Click(object sender, EventArgs e)
        {
            adicionarHistorio(numero1 - numero2);
        }

        private void BtnMultiplicao_Click(object sender, EventArgs e)
        {
            adicionarHistorio(numero1 * numero2);
        }

        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            adicionarHistorio(numero1 / numero2);
        }

        private void BtnSoma_Click(object sender, EventArgs e)
        {
            adicionarHistorio(numero1 + numero2);
        }
        private void adicionarHistorio(int valor)
        {
            historicoCalculadora[indiceHistorio] = valor;
            indiceHistorio++;
            MessageBox.Show($"{valor}");

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            numero1 = int.Parse(textBox1.Text);
        }

        private void historico_Click(object sender, EventArgs e)
        {
            string mensagem = "";
            foreach (var item in historicoCalculadora)
            {
                mensagem += $"{item} \n ";
            }
            MessageBox.Show(mensagem);
        }

        private void limpador_Click(object sender, EventArgs e)
        {
            //historicoCalculadora = new int[];
            //indiceHistorio = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            numero2 = int.Parse(textBox2.Text);
        }
    }
}
