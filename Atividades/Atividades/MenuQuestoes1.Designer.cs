
namespace Atividades
{
    partial class MenuQuestoes1
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
            this.Questão1_1 = new System.Windows.Forms.Button();
            this.Questão1_2 = new System.Windows.Forms.Button();
            this.Questão1_3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Questão1_1
            // 
            this.Questão1_1.Location = new System.Drawing.Point(52, 148);
            this.Questão1_1.Name = "Questão1_1";
            this.Questão1_1.Size = new System.Drawing.Size(159, 70);
            this.Questão1_1.TabIndex = 0;
            this.Questão1_1.Text = "Questão Um";
            this.Questão1_1.UseVisualStyleBackColor = true;
            this.Questão1_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Questão1_2
            // 
            this.Questão1_2.Location = new System.Drawing.Point(283, 148);
            this.Questão1_2.Name = "Questão1_2";
            this.Questão1_2.Size = new System.Drawing.Size(159, 70);
            this.Questão1_2.TabIndex = 1;
            this.Questão1_2.Text = "Questão Dois";
            this.Questão1_2.UseVisualStyleBackColor = true;
            this.Questão1_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Questão1_3
            // 
            this.Questão1_3.Location = new System.Drawing.Point(525, 148);
            this.Questão1_3.Name = "Questão1_3";
            this.Questão1_3.Size = new System.Drawing.Size(159, 70);
            this.Questão1_3.TabIndex = 2;
            this.Questão1_3.Text = "Questão Três";
            this.Questão1_3.UseVisualStyleBackColor = true;
            this.Questão1_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Questão1_3);
            this.panel1.Controls.Add(this.Questão1_1);
            this.panel1.Controls.Add(this.Questão1_2);
            this.panel1.Location = new System.Drawing.Point(31, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 397);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MenuQuestoes1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 461);
            this.Controls.Add(this.panel1);
            this.Name = "MenuQuestoes1";
            this.Text = "MenuQuestoes1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Questão1_1;
        private System.Windows.Forms.Button Questão1_2;
        private System.Windows.Forms.Button Questão1_3;
        private System.Windows.Forms.Panel panel1;
    }
}