
namespace SistemaAcademia
{
    partial class CadastroAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCelularAluno = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPFAluno = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.lbxCadastros = new System.Windows.Forms.ListBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.CMBModalidade = new System.Windows.Forms.ComboBox();
            this.bntPagar = new System.Windows.Forms.Button();
            this.lbxPagos = new System.Windows.Forms.ListBox();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMensalidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(103, 109);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(167, 23);
            this.txtNomeAluno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modalidade:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Celular:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mtbCelularAluno
            // 
            this.mtbCelularAluno.Location = new System.Drawing.Point(103, 137);
            this.mtbCelularAluno.Mask = "(00) 00000-0000";
            this.mtbCelularAluno.Name = "mtbCelularAluno";
            this.mtbCelularAluno.Size = new System.Drawing.Size(167, 23);
            this.mtbCelularAluno.TabIndex = 5;
            this.mtbCelularAluno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCelularAluno_MaskInputRejected);
            // 
            // mtbCPFAluno
            // 
            this.mtbCPFAluno.Location = new System.Drawing.Point(103, 166);
            this.mtbCPFAluno.Mask = "000,000,000-00";
            this.mtbCPFAluno.Name = "mtbCPFAluno";
            this.mtbCPFAluno.Size = new System.Drawing.Size(167, 23);
            this.mtbCPFAluno.TabIndex = 6;
            this.mtbCPFAluno.TextChanged += new System.EventHandler(this.mtbCPFAluno_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(439, 349);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(58, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletar.Location = new System.Drawing.Point(503, 348);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(63, 24);
            this.btnDeletar.TabIndex = 9;
            this.btnDeletar.Text = "Deletar     ";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seja Bem - Vindo!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Insira suas informações abaixo:";
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnVoltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltarMenu.Location = new System.Drawing.Point(16, 344);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(77, 40);
            this.btnVoltarMenu.TabIndex = 14;
            this.btnVoltarMenu.Text = "Voltar ao menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // lbxCadastros
            // 
            this.lbxCadastros.FormattingEnabled = true;
            this.lbxCadastros.ItemHeight = 15;
            this.lbxCadastros.Location = new System.Drawing.Point(336, 23);
            this.lbxCadastros.Name = "lbxCadastros";
            this.lbxCadastros.Size = new System.Drawing.Size(230, 319);
            this.lbxCadastros.TabIndex = 15;
            this.lbxCadastros.SelectedIndexChanged += new System.EventHandler(this.lbxCadastros_SelectedIndexChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Location = new System.Drawing.Point(282, 109);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(48, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // CMBModalidade
            // 
            this.CMBModalidade.FormattingEnabled = true;
            this.CMBModalidade.Location = new System.Drawing.Point(103, 198);
            this.CMBModalidade.Name = "CMBModalidade";
            this.CMBModalidade.Size = new System.Drawing.Size(167, 23);
            this.CMBModalidade.TabIndex = 17;
            this.CMBModalidade.SelectedIndexChanged += new System.EventHandler(this.CMBModalidade_SelectedIndexChanged);
            // 
            // bntPagar
            // 
            this.bntPagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntPagar.Location = new System.Drawing.Point(336, 348);
            this.bntPagar.Name = "bntPagar";
            this.bntPagar.Size = new System.Drawing.Size(97, 24);
            this.bntPagar.TabIndex = 18;
            this.bntPagar.Text = "Pagar";
            this.bntPagar.UseVisualStyleBackColor = true;
            this.bntPagar.Click += new System.EventHandler(this.bntPagar_Click);
            // 
            // lbxPagos
            // 
            this.lbxPagos.FormattingEnabled = true;
            this.lbxPagos.ItemHeight = 15;
            this.lbxPagos.Location = new System.Drawing.Point(593, 23);
            this.lbxPagos.Name = "lbxPagos";
            this.lbxPagos.Size = new System.Drawing.Size(230, 319);
            this.lbxPagos.TabIndex = 19;
            // 
            // txtProfessor
            // 
            this.txtProfessor.Location = new System.Drawing.Point(103, 227);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(167, 23);
            this.txtProfessor.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Professor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mensalidade:";
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(103, 284);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(167, 23);
            this.txtTurno.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(35, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Turno:";
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.Location = new System.Drawing.Point(103, 256);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(167, 23);
            this.txtMensalidade.TabIndex = 26;
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(846, 396);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProfessor);
            this.Controls.Add(this.lbxPagos);
            this.Controls.Add(this.bntPagar);
            this.Controls.Add(this.CMBModalidade);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbxCadastros);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbCPFAluno);
            this.Controls.Add(this.mtbCelularAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroAluno";
            this.Load += new System.EventHandler(this.CadastroAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbCelularAluno;
        private System.Windows.Forms.MaskedTextBox mtbCPFAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.ListBox lbxCadastros;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox CMBModalidade;
        private System.Windows.Forms.Button bntPagar;
        private System.Windows.Forms.ListBox lbxPagos;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMensalidade;
    }
}