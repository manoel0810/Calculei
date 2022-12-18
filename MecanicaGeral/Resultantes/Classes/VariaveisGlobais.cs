using MecanicaGeral.Objetos;

namespace MecanicaGeral.Resultantes.Classes
{
    internal class VariaveisGlobais
    {
        public static ConvencaoUnidades Unidades = new ConvencaoUnidades()
        {
            UnidadeMomento = ConvencaoUnidades.MomentunUnit.KnM,
            UnidadeResultante = ConvencaoUnidades.ResultanteUnit.N
        };

        public static Ponto PontoEstudo = new Ponto(0, 0, 0);
    }
}
