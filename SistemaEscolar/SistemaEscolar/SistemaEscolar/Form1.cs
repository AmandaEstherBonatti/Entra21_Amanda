using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class Form1 : Form
    {
        Cadastro cadastro;
        bool novo;
        String mensagemDeErro = "Os dados a seguir não foram digitados corretamente!\npor favor digite-os novamente: ";
        public Form1()
        {
            InitializeComponent();
            cadastro = new Cadastro();
            txtNomeResponsavel2.Enabled = false;
            MTxtCPFResponsavel2.Enabled = false;
        }
        private void bntSave_Click(object sender, EventArgs e)
        {
            if(VerificarDados())
            {
                if(novo)
                {
                    cadastro.AdicionarAluno(
                    txtNomeAluno.Text,
                    MTxtDataNascimento.Text,
                    MTxtCPFAluno.Text,
                    CBSexo.Text,
                    CBAnoEscolar.Text,
                    txtNomeResponsavel.Text,
                    MTxtCPFResponsavel.Text,
                    txtNomeResponsavel2.Text,
                    MTxtCPFResponsavel2.Text);

                    bntAdd_Click(sender, e);
                }
                else
                {
                    if(LBCadastro.SelectedIndex >= 0)
                    {
                        cadastro.EditarAluno(
                        LBCadastro.SelectedIndex,
                        txtNomeAluno.Text,
                        MTxtDataNascimento.Text,
                        MTxtCPFAluno.Text,
                        CBSexo.Text,
                        CBAnoEscolar.Text,
                        txtNomeResponsavel.Text,
                        MTxtCPFResponsavel.Text,
                        txtNomeResponsavel2.Text,
                         MTxtCPFResponsavel2.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show(mensagemDeErro);
                mensagemDeErro = "Os dados a seguir não foram digitados corretamente!\npor favor digite-os novamente: ";
            }

            AtualizarLista();
            LimparAluno();
            txtNomeAluno.Focus();
            bntDelete.Enabled = false;


        }
        private void bntAdd_Click(object sender, EventArgs e)
        {
            LimparAluno();
            txtNomeAluno.Focus();
            novo = true;
            bntSave.Enabled = false;
            bntDelete.Enabled = false;
        }
        private void bntDelete_Click(object sender, EventArgs e)
        {
            if(LBCadastro.SelectedIndex >= 0)
            {
                cadastro.DeletarAluno(LBCadastro.SelectedIndex);
                bntAdd_Click(sender, e);
                AtualizarLista();
            }
        }

        private void CBPais2_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPais2.Checked)
            {
                txtNomeResponsavel2.Enabled = true;
                MTxtCPFResponsavel2.Enabled = true;
            }
            else
            {
                txtNomeResponsavel2.Enabled = false;
                MTxtCPFResponsavel2.Enabled = false;
            }
        }

        private void LimparAluno()
        {
            txtNomeAluno.Clear();
            MTxtDataNascimento.Clear();
            MTxtCPFAluno.Clear();
            CBSexo.SelectedItem = null;
            CBAnoEscolar.SelectedItem = null;
            txtNomeResponsavel.Clear();
            MTxtCPFResponsavel.Clear();
            txtNomeResponsavel2.Clear();
            MTxtCPFResponsavel2.Clear();
        }
       
        private void LBCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(LBCadastro.SelectedIndex >= 0)
            {
                txtNomeAluno.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].NomeAluno;
                MTxtDataNascimento.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].DataNascimento;
                MTxtCPFAluno.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].CPFAluno;
                CBSexo.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].Genero;
                CBAnoEscolar.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].AnoEscolar;
                txtNomeResponsavel.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].NomeResponsavel;
                MTxtCPFResponsavel.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].CPFResponsavel;
                txtNomeResponsavel2.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].NomeResponsavel2;
                MTxtCPFResponsavel2.Text = cadastro.ListaAlunos[LBCadastro.SelectedIndex].CPFResponsavel2;
                novo = false;
                bntSave.Enabled = true;
               bntDelete.Enabled = true;
            }

        }

        private void AtualizarLista()
        {
            LBCadastro.Items.Clear();
            foreach (var aluno in cadastro.ListaAlunos)
            {
                LBCadastro.Items.Add(aluno);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bntAdd_Click(sender, e);
        }

        public bool VerificarDados()
        {
            bool verificacao = true;
            if(String.IsNullOrEmpty(txtNomeAluno.Text))
            {
                verificacao = false;
                mensagemDeErro += "\n--> Precisamos saber seu nome!";
            }
            if(!MTxtCPFAluno.MaskCompleted)
            {
                verificacao = false;
                mensagemDeErro += "\n--> Precisamos saber seu CPF!";
            }
            if(String.IsNullOrEmpty(txtNomeResponsavel.Text))
            {
                if(String.IsNullOrEmpty(txtNomeResponsavel2.Text))
                {
                    verificacao = false;
                    mensagemDeErro += "\n--> Precisamos saber o nome de pelo menos um responsavel!";
                }
            }
           
            return verificacao;
        }

        private void MTxtCPFResponsavel_TextChanged(object sender, EventArgs e)
        {
            if(MTxtCPFResponsavel.MaskCompleted)
            {
                bntSave.Enabled = true;
            }
        }
    }
}
