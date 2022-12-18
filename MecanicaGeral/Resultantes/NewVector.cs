using MecanicaGeral.Objetos;
using System;
using System.Windows.Forms;

namespace MecanicaGeral.Resultantes
{
    public partial class NewVector : Form
    {
        /// <summary>
        /// Vetor carregado com dados do usuário
        /// </summary>

        public Vetor Vector { get; set; }

        public NewVector()
        {
            InitializeComponent();
        }

        private void Btn_Adicionar_Click(object sender, EventArgs e)
        {
            //Validar
            if (Tb_PF.Text.Trim().Length == 0 || Tb_Nome.Text.Trim().Length == 0 || Cb_FU.SelectedIndex == -1 || Cb_MU.SelectedIndex == -1)
            {
                MessageBox.Show("Informe os dados corretamente");
                return;
            }

            try
            {
                bool ALL = false;
                double[] XYZF = new double[3];
                double[] XYZI = new double[3];
                var Split = Tb_PF.Text.Split(';');
                for (int i = 0; i < 3; i++)
                    XYZF[i] = Convert.ToDouble(Split[i]);

                if (Tb_PI.Text.Trim().Length != 0)
                {
                    Split = Tb_PI.Text.Split(';');
                    for (int i = 0; i < 3; i++)
                        XYZI[i] = Convert.ToDouble(Split[i]);
                    ALL = true;
                }

                if (ALL)
                {
                    Vector = new Vetor(new Ponto(x: XYZI[0], y: XYZI[1], z: XYZI[2]), new Ponto(x: XYZF[0], y: XYZF[1], z: XYZF[2]))
                    {
                        Magnitude = Convert.ToDouble(Tb_Mag.Text),
                        Name = Tb_Nome.Text,
                        Theta = Convert.ToDouble(Tb_Theta.Text),
                        UnidadeDeForca = Cb_FU.Text.Equals("Kn") ? ForceUnit.Kn : ForceUnit.N,
                        UnidadeDeMedida = Cb_MU.Text.Equals("Cm") ? MetricUnit.Cm : MetricUnit.M
                    };
                }
                else
                {
                    Vector = new Vetor(new Ponto(0, 0, 0), new Ponto(x: XYZF[0], y: XYZF[1], z: XYZF[2]))
                    {
                        Magnitude = Convert.ToDouble(Tb_Mag.Text),
                        Name = Tb_Nome.Text,
                        Theta = Convert.ToDouble(Tb_Theta.Text),
                        UnidadeDeForca = Cb_FU.Text.Equals("Kn") ? ForceUnit.Kn : ForceUnit.N,
                        UnidadeDeMedida = Cb_MU.Text.Equals("Cm") ? MetricUnit.Cm : MetricUnit.M
                    };
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar criar o vetor. Verifique se todos os dados foram informados corretamente\nErro: " + Ex.Message, "Novo vetor");
                return;
            }

            Vector.LoadComponents();
            Close();
        }
    }
}
