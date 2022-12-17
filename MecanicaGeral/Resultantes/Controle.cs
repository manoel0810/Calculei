using MecanicaGeral.Calculo;
using MecanicaGeral.Objetos;
using MecanicaGeral.Resultantes.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MecanicaGeral.Resultantes
{
    public partial class Controle : Form
    {
        readonly List<Vetor> Vetores = new List<Vetor>();

        public Controle()
        {
            InitializeComponent();
        }

        public void LoadDGV(List<Vetor> Vetores)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("Name");
            Table.Columns.Add("Magnitude");
            Table.Columns.Add("F. Unit");
            Table.Columns.Add("Theta");
            Table.Columns.Add("PI");
            Table.Columns.Add("PF");
            Table.Columns.Add("Modulo");
            Table.Columns.Add("M. Unit");

            foreach (Vetor v in Vetores)
            {
                DataRow Row = Table.NewRow();
                Row["Name"] = v.Name;
                Row["Magnitude"] = v.Magnitude;
                Row["F. Unit"] = v.UnidadeDeForca == 0 ? "Kn" : "N";
                Row["Theta"] = v.Theta.ToString();
                Row["PI"] = $"X:{v.GetPoint(0).GetX} Y:{v.GetPoint(0).GetY} Z:{v.GetPoint(0).GetZ}";
                Row["PF"] = $"X:{v.GetPoint(1).GetX} Y:{v.GetPoint(1).GetY} Z:{v.GetPoint(1).GetZ}";
                Row["Modulo"] = v.Modulo.ToString();
                Row["M. Unit"] = v.UnidadeDeMedida == 0 ? "Cm" : "M";

                Table.Rows.Add(Row);
            }

            Dgv_Vetores.DataSource = Table;
            Table.Dispose();

            for (int i = 0; i < 4; i++)
                Dgv_Vetores.Columns[i].Width = 60;
        }

        private void NovoVetor_Click(object sender, EventArgs e)
        {
            NewVector Vector = new NewVector();
            Vector.ShowDialog();

            var Vetor = Vector.Vector;
            Vetores.Add(Vetor);
            Vector.Dispose();

            LoadDGV(Vetores);
        }

        private void Btn_Prop_Click(object sender, EventArgs e)
        {
            if (Dgv_Vetores.SelectedRows.Count > 0)
            {
                Vetor V = null;
                foreach (Vetor vetor in Vetores)
                {
                    if (vetor.Name == Dgv_Vetores.SelectedRows[0].Cells[0].Value.ToString())
                    {
                        V = vetor;
                        break;
                    }
                }

                if (V != null)
                {
                    Propriedades Prop = new Propriedades(V);
                    Prop.ShowDialog();
                    Prop.Dispose();
                }
            }
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < Vetores.Count; i++)
            {
                if (Dgv_Vetores.SelectedRows[0].Cells[0].Value.ToString() == Vetores[i].Name)
                {
                    index = i;
                    break;
                }
            }

            Vetores.RemoveAt(index);
            if (Dgv_Vetores.SelectedRows.Count > 0)
                Dgv_Vetores.Rows.Remove(Dgv_Vetores.SelectedRows[0]);
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            double Rx = 0, Ry = 0, Rz = 0;
            var Convencao = VariaveisGlobais.Unidades.UnidadeResultante;

            foreach (var item in Vetores)
            {
                var Unidade = item.UnidadeDeForca;

                if ((int)Unidade == (int)Convencao)
                {
                    Rx += item.GetComponents[0];
                    Ry += item.GetComponents[1];
                    Rz += item.GetComponents[2];
                }
                else
                {
                    if (Unidade == 0 && (int)Convencao == 1)
                    {
                        Rx += item.GetComponents[0] * 1000;
                        Ry += item.GetComponents[1] * 1000;
                        Rz += item.GetComponents[2] * 1000;
                    }
                    else if ((int)Unidade == 1 && Convencao == 0)
                    {
                        Rx += item.GetComponents[0] / 1000;
                        Ry += item.GetComponents[1] / 1000;
                        Rz += item.GetComponents[2] / 1000;
                    }
                }
            }

            double Module = AlgebraVetorial.GetModule(new double[] { Rx, Ry, Rz });
            double CossX, CossY, CossZ;
            double ArcX, ArcY, ArcZ;

            CossX = Rx / Module;
            CossY = Ry / Module;
            CossZ = Rz / Module;

            ArcX = Math.Acos(CossX) * 180 / Math.PI;
            ArcY = Math.Acos(CossY) * 180 / Math.PI;
            ArcZ = Math.Acos(CossZ) * 180 / Math.PI;

            Tb_Resultante.Text = $"{Module}({(CossX > 0 ? "+" : "")}{CossX}I{(CossX > 0 ? "+" : "")}{CossY}J{(CossX > 0 ? "+" : "")}{CossZ}K)" + (Convencao == 0 ? "Kn" : "N");
            Tb_CosX.Text = CossX.ToString();
            Tb_CosY.Text = CossY.ToString();
            Tb_CosZ.Text = CossZ.ToString();

            Tb_ACosX.Text = ArcX.ToString() + "°";
            Tb_ACosY.Text = ArcY.ToString() + "°";
            Tb_ACosZ.Text = ArcZ.ToString() + "°";

            Tb_Rx.Text = Rx.ToString();
            Tb_Ry.Text = Ry.ToString();
            Tb_Rz.Text = Rz.ToString();

            Tb_Magnitude.Text = Module.ToString();
        }

        private void ConvençãoDeUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Convencoes Unidades = new Convencoes();
            Unidades.ShowDialog();
            Unidades.Dispose();
        }
    }
}
