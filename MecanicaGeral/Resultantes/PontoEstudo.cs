using MecanicaGeral.Resultantes.Classes;
using System;
using System.Windows.Forms;

namespace MecanicaGeral.Resultantes
{
    public partial class PontoEstudo : Form
    {
        public PontoEstudo()
        {
            InitializeComponent();
        }

        private void PontoEstudo_Load(object sender, EventArgs e)
        {
            Tb_XV.Text = VariaveisGlobais.PontoEstudo.GetX.ToString();
            Tb_YV.Text = VariaveisGlobais.PontoEstudo.GetY.ToString();
            Tb_ZV.Text = VariaveisGlobais.PontoEstudo.GetZ.ToString();
        }

        private void PontoEstudo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                VariaveisGlobais.PontoEstudo = new Objetos.Ponto(double.Parse(Tb_XV.Text), double.Parse(Tb_YV.Text), double.Parse(Tb_ZV.Text));

            }
            catch
            {
                MessageBox.Show("Não foi possível definir o ponto de estudo. Verifique se a entrada de dados estava correta", "Ponto de estudo");
            }
        }

        private void PontoEstudo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Close();
        }
    }
}
