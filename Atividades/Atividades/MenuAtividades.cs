using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Atividades
{
    public partial class MenuAtividades : Form
    {
        public MenuAtividades()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menu3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

          var menuP = new MenuQuestoes1();
           menuP.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
