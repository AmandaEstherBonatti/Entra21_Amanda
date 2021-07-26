
namespace SistemaAcademia
{
    partial class CadastroProfessor
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.lbxCadastrosP = new System.Windows.Forms.ListBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.MSKCelularProfessor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTSalario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeProfessor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBTurnoProfessor = new System.Windows.Forms.ComboBox();
            this.MSKCPFProfessor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Location = new System.Drawing.Point(203, 310);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(48, 23);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lbxCadastrosP
            // 
            this.lbxCadastrosP.FormattingEnabled = true;
            this.lbxCadastrosP.ItemHeight = 15;
            this.lbxCadastrosP.Location = new System.Drawing.Point(465, 57);
            this.lbxCadastrosP.Name = "lbxCadastrosP";
            this.lbxCadastrosP.Size = new System.Drawing.Size(246, 319);
            this.lbxCadastrosP.TabIndex = 30;
            this.lbxCadastrosP.SelectedIndexChanged += new System.EventHandler(this.lbxCadastrosP_SelectedIndexChanged);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnVoltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltarMenu.Location = new System.Drawing.Point(44, 356);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(77, 40);
            this.btnVoltarMenu.TabIndex = 29;
            this.btnVoltarMenu.Text = "Voltar ao menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(53, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Insira suas informações abaixo:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletar.Location = new System.Drawing.Point(317, 310);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(60, 23);
            this.btnDeletar.TabIndex = 26;
            this.btnDeletar.Text = "Deletar     ";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(257, 310);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(47, 23);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(162, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "CPF:";
            // 
            // MSKCelularProfessor
            // 
            this.MSKCelularProfessor.Location = new System.Drawing.Point(210, 153);
            this.MSKCelularProfessor.Mask = "(00) 00000-0000";
            this.MSKCelularProfessor.Name = "MSKCelularProfessor";
            this.MSKCelularProfessor.Size = new System.Drawing.Size(167, 23);
            this.MSKCelularProfessor.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(140, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Celular:";
            // 
            // TXTSalario
            // 
            this.TXTSalario.Location = new System.Drawing.Point(210, 228);
            this.TXTSalario.Name = "TXTSalario";
            this.TXTSalario.Size = new System.Drawing.Size(167, 23);
            this.TXTSalario.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(140, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sálario:";
            // 
            // txtNomeProfessor
            // 
            this.txtNomeProfessor.Location = new System.Drawing.Point(210, 122);
            this.txtNomeProfessor.Name = "txtNomeProfessor";
            this.txtNomeProfessor.Size = new System.Drawing.Size(167, 23);
            this.txtNomeProfessor.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(53, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nome do Professor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(44, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(382, 33);
            this.label8.TabIndex = 27;
            this.label8.Text = "Seja Bem - Vindo Professor!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(140, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Turno:";
            // 
            // CBTurnoProfessor
            // 
            this.CBTurnoProfessor.FormattingEnabled = true;
            this.CBTurnoProfessor.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Noturno"});
            this.CBTurnoProfessor.Location = new System.Drawing.Point(210, 265);
            this.CBTurnoProfessor.Name = "CBTurnoProfessor";
            this.CBTurnoProfessor.Size = new System.Drawing.Size(167, 23);
            this.CBTurnoProfessor.TabIndex = 33;
            // 
            // MSKCPFProfessor
            // 
            this.MSKCPFProfessor.Location = new System.Drawing.Point(210, 190);
            this.MSKCPFProfessor.Mask = "000,000,000,00";
            this.MSKCPFProfessor.Name = "MSKCPFProfessor";
            this.MSKCPFProfessor.Size = new System.Drawing.Size(167, 23);
            this.MSKCPFProfessor.TabIndex = 34;
            // 
            // CadastroProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.MSKCPFProfessor);
            this.Controls.Add(this.CBTurnoProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbxCadastrosP);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MSKCelularProfessor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeProfessor);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "CadastroProfessor";
            this.Text = "CadastroProfessor";
            this.Load += new System.EventHandler(this.CadastroProfessor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListBox lbxCadastrosP;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MSKCelularProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTSalario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeProfessor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBTurnoProfessor;
        private System.Windows.Forms.MaskedTextBox MSKCPFProfessor;
    }
}