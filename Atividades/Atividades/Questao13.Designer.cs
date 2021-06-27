
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
            this.bntResultado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntResultado
            // 
            this.bntResultado.Location = new System.Drawing.Point(173, 152);
            this.bntResultado.Name = "bntResultado";
            this.bntResultado.Size = new System.Drawing.Size(75, 23);
            this.bntResultado.TabIndex = 5;
            this.bntResultado.Text = "Resultado";
            this.bntResultado.UseVisualStyleBackColor = true;
            this.bntResultado.Click += new System.EventHandler(this.bntResultado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(113, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe seu ano de nascimento:";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(148, 110);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(126, 23);
            this.txtNascimento.TabIndex = 4;
            this.txtNascimento.TextChanged += new System.EventHandler(this.txtNascimento_TextChanged);
            // 
            // Questao13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.bntResultado);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.label3);
            this.Name = "Questao13";
            this.Text = "Questao13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntResultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNascimento;
    }
}