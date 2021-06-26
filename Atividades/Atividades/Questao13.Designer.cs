
namespace Atividades
{
    partial class Questao13
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
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.bntResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a sua idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(146, 53);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(126, 23);
            this.txtIdade.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe seu ano de nascimento:";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(146, 141);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(126, 23);
            this.txtNascimento.TabIndex = 4;
            // 
            // bntResultado
            // 
            this.bntResultado.Location = new System.Drawing.Point(172, 201);
            this.bntResultado.Name = "bntResultado";
            this.bntResultado.Size = new System.Drawing.Size(75, 23);
            this.bntResultado.TabIndex = 5;
            this.bntResultado.Text = "Resultado";
            this.bntResultado.UseVisualStyleBackColor = true;
            // 
            // Questao13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.bntResultado);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.label1);
            this.Name = "Questao13";
            this.Text = "Questao13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Button bntResultado;
    }
}