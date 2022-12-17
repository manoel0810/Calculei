namespace MecanicaGeral.Calculo
{
    internal class Convercoes
    {
        public enum Unidade
        {
            Kn,
            N,
            Cm,
            M
        }

        /// <summary>
        /// Converte o valor passado em <b>Value</b> para a unidade expecificada em <b>Unit</b>
        /// </summary>
        /// <param name="Value">Valor que será convertido</param>
        /// <param name="Unit">Unidade final</param>
        /// <returns>Valor convetido para a unidade final de força</returns>

        public static double ParseForce(double Value, Unidade Unit)
        {
            if (Unit == Unidade.Kn)
                return Value / 1000;
            else if (Unit == Unidade.N)
                return Value * 1000;

            return 0;
        }

        /// <summary>
        /// Converte o valor passado em <b>Value</b> para a unidade expecificada em <b>Unit</b>
        /// </summary>
        /// <param name="Value">Valor que será convertido</param>
        /// <param name="Unit">Unidade final<</param>
        /// <returns>Valor convetido para a unidade final métrica</returns>

        public static double ParseUnit(double Value, Unidade Unit)
        {
            if (Unit == Unidade.Cm)
                return Value * 100;
            else if (Unit == Unidade.M)
                return Value / 100;

            return 0;
        }
    }
}
