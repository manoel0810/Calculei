namespace MecanicaGeral.Resultantes.Classes
{
    internal class ConvencaoUnidades
    {
        public enum MomentunUnit
        {
            KnM,
            NCm
        }

        public enum ResultanteUnit
        {
            Kn,
            N
        }

        public MomentunUnit UnidadeMomento { get; set; }
        public ResultanteUnit UnidadeResultante { get; set; }
    }
}
