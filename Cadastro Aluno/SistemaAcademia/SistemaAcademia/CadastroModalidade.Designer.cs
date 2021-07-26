
namespace SistemaAcademia
{
    partial class CadastroModalidade
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
            this.MSKPrecoHora = new System.Windows.Forms.MaskedTextBox();
            this.CBProfessor = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lbxCadastrosM = new System.Windows.Forms.ListBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomemodalidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CBVezesSemana = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // MSKPrecoHora
            // 
            this.MSKPrecoHora.Location = new System.Drawing.Point(227, 192);
            this.MSKPrecoHora.Mask = "00000";
            this.MSKPrecoHora.Name = "MSKPrecoHora";
            this.MSKPrecoHora.Size = new System.Drawing.Size(167, 23);
            this.MSKPrecoHora.TabIndex = 51;
            this.MSKPrecoHora.ValidatingType = typeof(int);
            this.MSKPrecoHora.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MSKPrecoHora_MaskInputRejected);
            // 
            // CBProfessor
            // 
            this.CBProfessor.FormattingEnabled = true;
            this.CBProfessor.Location = new System.Drawing.Point(227, 159);
            this.CBProfessor.Name = "CBProfessor";
            this.CBProfessor.Size = new System.Drawing.Size(167, 23);
            this.CBProfessor.TabIndex = 50;
            // 
            // btnNovo
            // 
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNovo.Location = new System.Drawing.Point(227, 271);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(48, 23);
            this.btnNovo.TabIndex = 48;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lbxCadastrosM
            // 
            this.lbxCadastrosM.FormattingEnabled = true;
            this.lbxCadastrosM.ItemHeight = 15;
            this.lbxCadastrosM.Location = new System.Drawing.Point(482, 59);
            this.lbxCadastrosM.Name = "lbxCadastrosM";
            this.lbxCadastrosM.Size = new System.Drawing.Size(246, 319);
            this.lbxCadastrosM.TabIndex = 47;
            this.lbxCadastrosM.SelectedIndexChanged += new System.EventHandler(this.lbxCadastrosM_SelectedIndexChanged);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.BackColor = System.Drawing.Color.Aqua;
            this.btnVoltarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltarMenu.Location = new System.Drawing.Point(61, 358);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(77, 40);
            this.btnVoltarMenu.TabIndex = 46;
            this.btnVoltarMenu.Text = "Voltar ao menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = false;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(70, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Insira as informações abaixo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(61, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 33);
            this.label8.TabIndex = 44;
            this.label8.Text = "Seja Bem - Vindo!";
            // 
            // btnDeletar
            // 
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletar.Location = new System.Drawing.Point(334, 271);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(60, 23);
            this.btnDeletar.TabIndex = 43;
            this.btnDeletar.Text = "Deletar     ";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(281, 271);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(47, 23);
            this.btnSalvar.TabIndex = 42;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(98, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 41;
            this.label4.Text = "Preço por Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(70, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nome do Professor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(82, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Vezes na Semana:";
            // 
            // txtNomemodalidade
            // 
            this.txtNomemodalidade.Location = new System.Drawing.Point(227, 124);
            this.txtNomemodalidade.Name = "txtNomemodalidade";
            this.txtNomemodalidade.Size = new System.Drawing.Size(167, 23);
            this.txtNomemodalidade.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(56, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Nome da Modalidade:";
            // 
            // CBVezesSemana
            // 
            this.CBVezesSemana.FormattingEnabled = true;
            this.CBVezesSemana.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.CBVezesSemana.Location = new System.Drawing.Point(227, 231);
            this.CBVezesSemana.Name = "CBVezesSemana";
            this.CBVezesSemana.Size = new System.Drawing.Size(167, 23);
            this.CBVezesSemana.TabIndex = 52;
            // 
            // CadastroModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(787, 430);
            this.Controls.Add(this.CBVezesSemana);
            this.Controls.Add(this.MSKPrecoHora);
            this.Controls.Add(this.CBProfessor);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lbxCadastrosM);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomemodalidade);
            this.Controls.Add(this.label7);
            this.Name = "CadastroModalidade";
            this.Text = "CadastroModalidade";
            this.Load += new System.EventHandler(this.CadastroModalidade_Load);
            this.Enter += new System.EventHandler(this.CadastroModalidade_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MSKPrecoHora;
        private System.Windows.Forms.ComboBox CBProfessor;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListBox lbxCadastrosM;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomemodalidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CBVezesSemana;
    }
}