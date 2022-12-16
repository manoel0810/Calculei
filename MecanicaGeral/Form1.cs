using MecanicaGeral.Resultantes;
using System;
using System.Windows.Forms;


namespace MecanicaGeral
{
    public partial class Menu : Form
    {
        private Controle Ctrl_Save = null;

        public Menu()
        {
            InitializeComponent();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ForcaResultante_Click(object sender, EventArgs e)
        {
            if (Ctrl_Save != null)
            {
                Ctrl_Save.ShowDialog();
            }
            else
            {
                Ctrl_Save = new Controle();
                Ctrl_Save.ShowDialog();
            }
        }
    }
}
