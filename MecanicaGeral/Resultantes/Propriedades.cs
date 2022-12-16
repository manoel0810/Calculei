using MecanicaGeral.Calculo;
using MecanicaGeral.Objetos;
using System;
using System.Windows.Forms;

namespace MecanicaGeral.Resultantes
{
    public partial class Propriedades : Form
    {
        readonly Vetor Vector;

        public Propriedades(Vetor Vector)
        {
            InitializeComponent();
            this.Vector = Vector;
        }

        private void Propriedades_Load(object sender, EventArgs e)
        {
            Tb_PI.Text = $"X:{Vector.GetPoint(0).GetX} Y:{Vector.GetPoint(0).GetY} Z:{Vector.GetPoint(0).GetZ}";
            Tb_PF.Text = $"X:{Vector.GetPoint(1).GetX} Y:{Vector.GetPoint(1).GetY} Z:{Vector.GetPoint(1).GetZ}";

            Tb_CosX.Text = Vector.GetCossins[0].ToString();
            Tb_CosY.Text = Vector.GetCossins[1].ToString();
            Tb_CosZ.Text = Vector.GetCossins[2].ToString();

            Tb_Magnitude.Text = Vector.Magnitude.ToString();
            Tb_FU.Text = Vector.UnidadeDeForca == 0 ? "Kn" : "N";

            Tb_Modulo.Text = Vector.Modulo.ToString();
            Tb_MU.Text = Vector.UnidadeDeMedida == 0 ? "Cm" : "M";

            Tb_Fx.Text = Vector.GetComponents[0].ToString();
            Tb_Fy.Text = Vector.GetComponents[1].ToString();
            Tb_Fz.Text = Vector.GetComponents[2].ToString();

            Tb_AngX.Text = AlgebraVetorial.GetAngleByCossin(Vector.GetCossins[0]).ToString();
            Tb_AngY.Text = AlgebraVetorial.GetAngleByCossin(Vector.GetCossins[1]).ToString();
            Tb_AngZ.Text = AlgebraVetorial.GetAngleByCossin(Vector.GetCossins[2]).ToString();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
