using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class CadastroProfessor : Form
    {
        Academia _academia;
        bool novo;
        string mensagemDeErro = "Por favor digite-os:";
        public CadastroProfessor(Academia academiaP)
        {
            InitializeComponent();
            _academia = academiaP;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            txtNomeProfessor.Focus();
            novo = true;
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
        }

        private void LimparDados()
        {
            txtNomeProfessor.Clear();
            MSKCelularProfessor.Clear();
            MSKCPFProfessor.Clear();
            TXTSalario.Clear();
            CBTurnoProfessor.SelectedItem = "";
        }
        private void AtualizarListaCadastros()
        {
            lbxCadastrosP.Items.Clear();
            foreach (var professor in _academia.ListaProfessor)
            {
                lbxCadastrosP.Items.Add(professor);
            }
        }
        public bool VerificarDados()
        {
            bool verificacao = true;
            if (String.IsNullOrEmpty(txtNomeProfessor.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n Nome do Professor.";
            }
            if (!MSKCelularProfessor.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n Número para contato do Professor!";
            }
            if (String.IsNullOrEmpty(CBTurnoProfessor.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n Turno do Professor.";
            }
            return verificacao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarDados())
            {
                if (novo)
                {
                   
                    _academia.AdicionarProfessor(
                        txtNomeProfessor.Text,
                        MSKCelularProfessor.Text,
                        MSKCPFProfessor.Text,
                        TXTSalario.Text,
                        CBTurnoProfessor.Text);
                    btnNovo_Click(sender, e);
                }
                else
                {
                    if (lbxCadastrosP.SelectedIndex >= 0)
                    {
                        _academia.EditarProfessor(
                        lbxCadastrosP.SelectedIndex,
                         txtNomeProfessor.Text,
                        MSKCelularProfessor.Text,
                        MSKCPFProfessor.Text,
                        TXTSalario.Text,
                        CBTurnoProfessor.Text);
                        
                       
                    }
                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro, "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mensagemDeErro = "Por favor digite-os:";
            }
            AtualizarListaCadastros();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            if (lbxCadastrosP.SelectedIndex >= 0)
            {
                _academia.DeletarProfessor(lbxCadastrosP.SelectedIndex);
                btnNovo_Click(sender, e);
                AtualizarListaCadastros();
            }
        }

        private void lbxCadastrosP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCadastrosP.SelectedIndex >= 0)
            {
                txtNomeProfessor.Text = _academia.ListaProfessor[lbxCadastrosP.SelectedIndex].Nome;
                MSKCelularProfessor.Text = _academia.ListaProfessor[lbxCadastrosP.SelectedIndex].Telefone;
                MSKCPFProfessor.Text = _academia.ListaProfessor[lbxCadastrosP.SelectedIndex].CPF;
                TXTSalario.SelectedText = _academia.ListaProfessor[lbxCadastrosP.SelectedIndex].Salario;
                novo = false;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
            }
        }

        private void MSKCelularProfessor_TextChanged(object sender, EventArgs e)
        {
            if (MSKCelularProfessor.MaskCompleted)
            {
                btnSalvar.Enabled = true;
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            var menu = new MDIAcademia();
            menu.Show();
            this.Hide();
        }

        private void CadastroProfessor_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
        }
    }
}
