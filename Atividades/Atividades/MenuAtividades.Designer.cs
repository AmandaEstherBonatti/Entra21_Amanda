
namespace Atividades
{
    partial class MenuAtividades
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
            this.menu3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3.SuspendLayout();
            this.menu2.SuspendLayout();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu3
            // 
            this.menu3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.menu3.Location = new System.Drawing.Point(0, 48);
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(188, 24);
            this.menu3.TabIndex = 0;
            this.menu3.Text = "menuStrip1";
            this.menu3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu3_ItemClicked);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 20);
            this.toolStripMenuItem3.Text = "Terceira Atividade";
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menu2.Location = new System.Drawing.Point(0, 24);
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(188, 24);
            this.menu2.TabIndex = 1;
            this.menu2.Text = "menuStrip2";
            this.menu2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu2_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 20);
            this.toolStripMenuItem2.Text = "Segunda Atividade";
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(188, 24);
            this.menu1.TabIndex = 2;
            this.menu1.Text = "Primeira Atividade";
            this.menu1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menu1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 20);
            this.toolStripMenuItem1.Text = "Primeira Atividade";
            // 
            // MenuAtividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 72);
            this.Controls.Add(this.menu3);
            this.Controls.Add(this.menu2);
            this.Controls.Add(this.menu1);
            this.MainMenuStrip = this.menu3;
            this.Name = "MenuAtividades";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu3.ResumeLayout(false);
            this.menu3.PerformLayout();
            this.menu2.ResumeLayout(false);
            this.menu2.PerformLayout();
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu3;
        private System.Windows.Forms.MenuStrip menu2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

