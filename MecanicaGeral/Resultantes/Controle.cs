using MecanicaGeral.Objetos;
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
            if (Dgv_Vetores.SelectedRows.Count > 0)
                Dgv_Vetores.Rows.Remove(Dgv_Vetores.SelectedRows[0]);
        }
    }
}
