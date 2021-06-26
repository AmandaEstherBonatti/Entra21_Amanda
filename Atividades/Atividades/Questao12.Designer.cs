
namespace Atividades
{
    partial class Questao12
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
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btnComissao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador do vendedor: ";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Location = new System.Drawing.Point(168, 12);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(204, 23);
            this.txtIdentificador.TabIndex = 1;
            this.txtIdentificador.TextChanged += new System.EventHandler(this.txtIdentificador_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código do produto:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(168, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(204, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço unitario da peça:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(168, 70);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(204, 23);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade vendida: ";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(168, 99);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(204, 23);
            this.txtQuantidade.TabIndex = 7;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // btnComissao
            // 
            this.btnComissao.Location = new System.Drawing.Point(131, 158);
            this.btnComissao.Name = "btnComissao";
            this.btnComissao.Size = new System.Drawing.Size(156, 78);
            this.btnComissao.TabIndex = 8;
            this.btnComissao.Text = "Boleto de pagamento da comissão";
            this.btnComissao.UseVisualStyleBackColor = true;
            this.btnComissao.Click += new System.EventHandler(this.btnComissao_Click);
            // 
            // Questao12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 270);
            this.Controls.Add(this.btnComissao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.label1);
            this.Name = "Questao12";
            this.Text = "Identificador do vendedor: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnComissao;
    }
}