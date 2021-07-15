using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class MDIAcademia : Form
    {
        private int childFormNumber = 0;

        public MDIAcademia()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void bttnAluno_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ca = new CadastroAluno();
            ca.Show();
               
        }

        private void MDIAcademia_Load(object sender, EventArgs e)
        {
            bttnAluno.Focus();
        }
    }
}
