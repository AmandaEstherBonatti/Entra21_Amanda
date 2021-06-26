using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividades
{
    public partial class MenuQuestoes1 : Form
    {
        public MenuQuestoes1()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var questao13 = new Questao13();
            questao13.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var questao12 = new Questao12();
            questao12.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var  questao11 = new Questao11();
            questao11.Show();
        }
    }
}
