using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class CadastroModalidade : Form
    {
        Academia _academia;
        bool novo;
        public CadastroModalidade(Academia academiaM)
        {
            InitializeComponent();
            _academia = academiaM;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            novo = true;
            LimparDados();
            txtNomemodalidade.Focus();
            btnDeletar.Enabled = false;
        }
        private void LimparDados()
        {
            txtNomemodalidade.Clear();
            CBProfessor.SelectedItem = null;
            MSKPrecoHora.Clear();
            CBVezesSemana.SelectedItem = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                _academia.AdicionarModalidade(txtNomemodalidade.Text,
                                             (Professor)CBProfessor.SelectedItem,
                                             double.Parse(MSKPrecoHora.Text),
                                             Convert.ToInt32(CBVezesSemana.SelectedItem));
                btnNovo_Click(sender, e);
            }
            else
            {
                if(lbxCadastrosM.SelectedIndex >= 0)
                {
                    _academia.EditarModalidade(lbxCadastrosM.SelectedIndex,
                                             txtNomemodalidade.Text,
                                             (Professor)CBProfessor.SelectedItem,
                                             double.Parse(MSKPrecoHora.Text),
                                             Convert.ToInt32(CBVezesSemana.SelectedItem));
                    btnSalvar.Focus();
                    btnDeletar.Enabled = true;
                    btnNovo.Enabled = true;


                }
            }
            AtualizarListaCadastros();
        }

        public void ComboProfessor()
        {
            foreach (var P in _academia.ListaProfessor)
            {
                CBProfessor.Items.Add(P);
            }
        }

        private void CadastroModalidade_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
            btnDeletar.Enabled = false;
        }

        private void AtualizarListaCadastros()
        {
            lbxCadastrosM.Items.Clear();
            foreach (var modalidade in _academia.ListaModalidade)
            {
                lbxCadastrosM.Items.Add(modalidade);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lbxCadastrosM.SelectedIndex >= 0)
            {
              _academia.DeletarModalidade(lbxCadastrosM.SelectedIndex);
                btnNovo_Click(sender, e);
                AtualizarListaCadastros();
            }
        }

        private void lbxCadastrosM_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbxCadastrosM.SelectedIndex >= 0)
            {
                txtNomemodalidade.Text = _academia.ListaModalidade[lbxCadastrosM.SelectedIndex].NomeModalidade;
                CBProfessor.SelectedItem = _academia.ListaModalidade[lbxCadastrosM.SelectedIndex].Professor;
                MSKPrecoHora.Text = _academia.ListaModalidade[lbxCadastrosM.SelectedIndex].PrecoHora.ToString();
                CBVezesSemana.SelectedItem = _academia.ListaModalidade[lbxCadastrosM.SelectedIndex].VezesSemana;
                novo = false;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            var menu = new MDIAcademia();
            menu.Show();
            this.Hide();
        }

        private void CadastroModalidade_Enter(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
            CBProfessor.Items.Clear();
            foreach ( var p in _academia.ListaProfessor)
            {
                CBProfessor.Items.Add(p);
            }
        }

        private void MSKPrecoHora_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
