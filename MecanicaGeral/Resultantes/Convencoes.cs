using MecanicaGeral.Resultantes.Classes;
using System;
using System.Windows.Forms;

namespace MecanicaGeral.Resultantes
{
    public partial class Convencoes : Form
    {
        public Convencoes()
        {
            InitializeComponent();
        }

        private void Convencoes_Load(object sender, EventArgs e)
        {
            if (VariaveisGlobais.Unidades.UnidadeResultante == ConvencaoUnidades.ResultanteUnit.Kn)
                Rb_ResultanteKn.Checked = true;
            else
                Rb_ResultanteN.Checked = true;

            if (VariaveisGlobais.Unidades.UnidadeMomento == ConvencaoUnidades.MomentunUnit.KnM)
                Rb_MomentoKnM.Checked = true;
            else
                Rb_MomentoNCm.Checked = true;
        }

        private void Convencoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            VariaveisGlobais.Unidades = new ConvencaoUnidades()
            {
                UnidadeMomento = Rb_MomentoKnM.Checked ? ConvencaoUnidades.MomentunUnit.KnM : ConvencaoUnidades.MomentunUnit.NCm,
                UnidadeResultante = Rb_ResultanteKn.Checked ? ConvencaoUnidades.ResultanteUnit.Kn : ConvencaoUnidades.ResultanteUnit.N
            };
        }
    }
}
