
namespace SistemaEscolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.MTxtCPFAluno = new System.Windows.Forms.MaskedTextBox();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.CBAnoEscolar = new System.Windows.Forms.ComboBox();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.MTxtCPFResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeResponsavel2 = new System.Windows.Forms.TextBox();
            this.MTxtCPFResponsavel2 = new System.Windows.Forms.MaskedTextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.MTxtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.CBPais2 = new System.Windows.Forms.CheckBox();
            this.LBCadastro = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF do Aluno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gênero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano Escolar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome do Responsável:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPF do Responsável:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nome do Segundo Responsável:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "CPF do Segundo Responsável";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cadastro Escolar";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(157, 46);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(191, 28);
            this.txtNomeAluno.TabIndex = 11;
            // 
            // MTxtCPFAluno
            // 
            this.MTxtCPFAluno.Location = new System.Drawing.Point(156, 114);
            this.MTxtCPFAluno.Mask = "000-000-000-00";
            this.MTxtCPFAluno.Name = "MTxtCPFAluno";
            this.MTxtCPFAluno.Size = new System.Drawing.Size(103, 28);
            this.MTxtCPFAluno.TabIndex = 12;
            // 
            // CBSexo
            // 
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.CBSexo.Location = new System.Drawing.Point(156, 150);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(47, 31);
            this.CBSexo.TabIndex = 14;
            // 
            // CBAnoEscolar
            // 
            this.CBAnoEscolar.FormattingEnabled = true;
            this.CBAnoEscolar.Items.AddRange(new object[] {
            "Primeiro",
            "Segundo",
            "Terceiro",
            "Quarto",
            "Quinto",
            "Sexto",
            "Sétimo",
            "Oitavo",
            "Nono"});
            this.CBAnoEscolar.Location = new System.Drawing.Point(157, 187);
            this.CBAnoEscolar.Name = "CBAnoEscolar";
            this.CBAnoEscolar.Size = new System.Drawing.Size(121, 31);
            this.CBAnoEscolar.TabIndex = 15;
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(157, 227);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(191, 28);
            this.txtNomeResponsavel.TabIndex = 16;
            // 
            // MTxtCPFResponsavel
            // 
            this.MTxtCPFResponsavel.Location = new System.Drawing.Point(157, 258);
            this.MTxtCPFResponsavel.Mask = "000-000-000-00";
            this.MTxtCPFResponsavel.Name = "MTxtCPFResponsavel";
            this.MTxtCPFResponsavel.Size = new System.Drawing.Size(102, 28);
            this.MTxtCPFResponsavel.TabIndex = 17;
            this.MTxtCPFResponsavel.TextChanged += new System.EventHandler(this.MTxtCPFResponsavel_TextChanged);
            // 
            // txtNomeResponsavel2
            // 
            this.txtNomeResponsavel2.Location = new System.Drawing.Point(225, 320);
            this.txtNomeResponsavel2.Name = "txtNomeResponsavel2";
            this.txtNomeResponsavel2.Size = new System.Drawing.Size(145, 28);
            this.txtNomeResponsavel2.TabIndex = 18;
            // 
            // MTxtCPFResponsavel2
            // 
            this.MTxtCPFResponsavel2.Location = new System.Drawing.Point(225, 354);
            this.MTxtCPFResponsavel2.Mask = "000-000-000-00";
            this.MTxtCPFResponsavel2.Name = "MTxtCPFResponsavel2";
            this.MTxtCPFResponsavel2.Size = new System.Drawing.Size(102, 28);
            this.MTxtCPFResponsavel2.TabIndex = 19;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(22, 423);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(89, 43);
            this.bntAdd.TabIndex = 22;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(282, 423);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 43);
            this.bntDelete.TabIndex = 23;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(159, 423);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 43);
            this.bntSave.TabIndex = 24;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // MTxtDataNascimento
            // 
            this.MTxtDataNascimento.Location = new System.Drawing.Point(159, 83);
            this.MTxtDataNascimento.Mask = "00/00/0000";
            this.MTxtDataNascimento.Name = "MTxtDataNascimento";
            this.MTxtDataNascimento.Size = new System.Drawing.Size(100, 28);
            this.MTxtDataNascimento.TabIndex = 28;
            this.MTxtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // CBPais2
            // 
            this.CBPais2.AutoSize = true;
            this.CBPais2.Location = new System.Drawing.Point(12, 290);
            this.CBPais2.Name = "CBPais2";
            this.CBPais2.Size = new System.Drawing.Size(206, 27);
            this.CBPais2.TabIndex = 29;
            this.CBPais2.Text = "Há mais de um responsável?";
            this.CBPais2.UseVisualStyleBackColor = true;
            this.CBPais2.CheckedChanged += new System.EventHandler(this.CBPais2_CheckedChanged);
            // 
            // LBCadastro
            // 
            this.LBCadastro.FormattingEnabled = true;
            this.LBCadastro.ItemHeight = 23;
            this.LBCadastro.Location = new System.Drawing.Point(469, 46);
            this.LBCadastro.Name = "LBCadastro";
            this.LBCadastro.Size = new System.Drawing.Size(280, 349);
            this.LBCadastro.TabIndex = 30;
            this.LBCadastro.SelectedIndexChanged += new System.EventHandler(this.LBCadastro_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.Controls.Add(this.LBCadastro);
            this.Controls.Add(this.CBPais2);
            this.Controls.Add(this.MTxtDataNascimento);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.MTxtCPFResponsavel2);
            this.Controls.Add(this.txtNomeResponsavel2);
            this.Controls.Add(this.MTxtCPFResponsavel);
            this.Controls.Add(this.txtNomeResponsavel);
            this.Controls.Add(this.CBAnoEscolar);
            this.Controls.Add(this.CBSexo);
            this.Controls.Add(this.MTxtCPFAluno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.MaskedTextBox MTxtCPFAluno;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.ComboBox CBAnoEscolar;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.MaskedTextBox MTxtCPFResponsavel;
        private System.Windows.Forms.TextBox txtNomeResponsavel2;
        private System.Windows.Forms.MaskedTextBox MTxtCPFResponsavel2;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.MaskedTextBox MTxtDataNascimento;
        private System.Windows.Forms.CheckBox CBPais2;
        private System.Windows.Forms.ListBox LBCadastro;
    }
}

