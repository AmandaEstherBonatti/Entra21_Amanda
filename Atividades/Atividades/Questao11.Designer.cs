
namespace Atividades
{
    partial class Questao11
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
            this.cotacaoReal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorDolar = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Converter Dólar em Real!";
            // 
            // cotacaoReal
            // 
            this.cotacaoReal.Location = new System.Drawing.Point(23, 106);
            this.cotacaoReal.Name = "cotacaoReal";
            this.cotacaoReal.Size = new System.Drawing.Size(153, 23);
            this.cotacaoReal.TabIndex = 2;
            this.cotacaoReal.TextChanged += new System.EventHandler(this.cotacaoReal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe a cotação do dólar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Informe o valor do dólar:";
            // 
            // valorDolar
            // 
            this.valorDolar.Location = new System.Drawing.Point(235, 106);
            this.valorDolar.Name = "valorDolar";
            this.valorDolar.Size = new System.Drawing.Size(153, 23);
            this.valorDolar.TabIndex = 5;
            this.valorDolar.TextChanged += new System.EventHandler(this.valorDolar_TextChanged);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(168, 165);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(75, 23);
            this.resultado.TabIndex = 6;
            this.resultado.Text = "Converter";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // Questao11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valorDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cotacaoReal);
            this.Controls.Add(this.label1);
            this.Name = "Questao11";
            this.Text = "Informe o valor do dólar:";
            this.Load += new System.EventHandler(this.Questao11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cotacaoReal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valorDolar;
        private System.Windows.Forms.Button resultado;
    }
}