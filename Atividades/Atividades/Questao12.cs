using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Atividades
{
    public partial class Questao12 : Form
    {
        string identificador = " ";
        double codigo = 0;
        double preco = 0;
        int quantidade = 0;

        public Questao12()
        {
            InitializeComponent();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            preco = double.Parse(txtPreco.Text);
        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {
            identificador = txtIdentificador.Text;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            codigo = double.Parse(txtCodigo.Text);
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            double resultado = preco * 0.5;

            MessageBox.Show($"Identificador: {identificador} \n" +
                            $"Código do produto: {codigo} \n" +
                            $"Preço do produto: {preco} \n" +
                            $"Quantidade: {quantidade} \n" +
                            $"Seu resultado final é: {resultado} ");
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            quantidade = int.Parse(txtQuantidade.Text);
        }
    }
}
