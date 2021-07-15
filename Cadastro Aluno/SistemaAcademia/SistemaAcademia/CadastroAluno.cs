using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class CadastroAluno : Form
    {
        Academia academia;
        bool novo;
        string mensagemDeErro = "Os dados a seguir não foram digitados corretamente\npor favor digite-os:";

        public CadastroAluno()
        {
            InitializeComponent();
            academia = new Academia();
        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparDados();
            txtNomeAluno.Focus();
            novo = true;
            btnSalvar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarDados())
            {
                if (novo)
                {
                    academia.AdicionarAluno(
                        txtNomeAluno.Text,
                        txtModalidade.Text,
                        mtbCelularAluno.Text,
                        mtbCPFAluno.Text);
                    btnNovo_Click(sender, e);
                }
                else
                {
                    if (lbxCadastros.SelectedIndex >= 0)
                    {
                        academia.EditarAluno(
                            lbxCadastros.SelectedIndex,
                            txtNomeAluno.Text,
                            txtModalidade.Text,
                            mtbCelularAluno.Text,
                            mtbCPFAluno.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram digitados corretamente\npor favor digite-os:";
            }
            AtualizarListaCadastros();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (lbxCadastros.SelectedIndex >= 0)
            {
                academia.DeletarAluno(lbxCadastros.SelectedIndex);
                btnNovo_Click(sender, e);
                AtualizarListaCadastros();
            }
        }

        private void lbxCadastros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxCadastros.SelectedIndex >= 0)
            {
                txtNomeAluno.Text = academia.ListaAlunos[lbxCadastros.SelectedIndex].Nome;
                txtModalidade.Text = academia.ListaAlunos[lbxCadastros.SelectedIndex].Modalidade;
                mtbCelularAluno.Text = academia.ListaAlunos[lbxCadastros.SelectedIndex].Telefone;
                mtbCPFAluno.Text = academia.ListaAlunos[lbxCadastros.SelectedIndex].CPF;
                novo = false;
                btnSalvar.Enabled = true;
                btnDeletar.Enabled = true;
            }
        }

        private void AtualizarListaCadastros()
        {
            lbxCadastros.Items.Clear();
            foreach (var aluno in academia.ListaAlunos)
            {
                lbxCadastros.Items.Add(aluno);
            }
        }

        private void LimparDados()
        {
            txtNomeAluno.Clear();
            txtModalidade.Clear();
            mtbCelularAluno.Clear();
            mtbCPFAluno.Clear();
        }

        public bool VerificarDados()
        {
            bool verificacao = true;
            if (String.IsNullOrEmpty(txtNomeAluno.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Nome.";
            }
            if (String.IsNullOrEmpty(txtModalidade.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Modalidade.";
            }
            if (!mtbCelularAluno.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Telefone.";
            }
            if (!mtbCPFAluno.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> CPF.";
            }
            return verificacao;
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            var menu = new MDIAcademia();
            menu.Show();
            this.Hide();
        }

        private void mtbCPFAluno_TextChanged(object sender, EventArgs e)
        {
            if (mtbCPFAluno.MaskCompleted)
            {
                btnSalvar.Enabled = true;
            }
        }
    }
}
