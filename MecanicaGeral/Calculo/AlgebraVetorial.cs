using MecanicaGeral.Objetos;
using MecanicaGeral.Resultantes.Classes;
using System;

namespace MecanicaGeral.Calculo
{
    internal class AlgebraVetorial
    {
        /// <summary>
        /// Calcula o tamanho (Módulo) de um vetor
        /// </summary>
        /// <param name="Vector">Objeto do tipo <b>Vetor</b></param>
        /// <returns>Um <b>double</b> com o tamanho do vetor</returns>

        public static double GetModule(Vetor Vector)
        {
            double[] Lenghts = GetLenght(Vector);
            double Module = Math.Sqrt(Lenghts[0] * Lenghts[0] + Lenghts[1] * Lenghts[1] + Lenghts[2] * Lenghts[2]);
            return Module;
        }

        /// <summary>
        /// Calcula o tamanho (Módulo) a partir das componentes X, Y e Z
        /// </summary>
        /// <param name="Components">Componentes para o módulo</param>
        /// <returns>Um <b>double</b> com o tamanho do vetor</returns>

        public static double GetModule(double[] Components)
        {
            double Module = Math.Sqrt(Components[0] * Components[0] + Components[1] * Components[1] + Components[2] * Components[2]);
            return Module;
        }

        /// <summary>
        /// Calcula o tamanho (Módulo) de um vetor
        /// </summary>
        /// <param name="Vector">Objeto do tipo <b>Vetor</b></param>
        /// <returns>Um <b>double[]</b> com as medias em X, Y e Z</returns>

        public static double[] GetLenght(Vetor Vector)
        {
            double X = Vector.GetPoint(1).GetX - Vector.GetPoint(0).GetX;
            double Y = Vector.GetPoint(1).GetY - Vector.GetPoint(0).GetY;
            double Z = Vector.GetPoint(1).GetZ - Vector.GetPoint(0).GetZ;

            return new double[] { X, Y, Z };
        }

        /// <summary>
        /// Calcula o cosseno diretor único que corresponde à variável {CossinOf}
        /// </summary>
        /// <param name="Vector">Objeto do tipo <b>Vetor</b></param>
        /// /// <param name="CossinOf">Identifica qual será o eixo sob qual o cosseno será obtido</param>
        /// <returns>Um <b>double</b> com o valor do cosseno em graus</returns>

        public static double GetCossinDirector(Vetor Vector, Coordenada CossinOf)
        {
            double Module = GetModule(Vector);

            if (CossinOf.Equals(Coordenada.X))
                return GetLenght(Vector)[0] / Module;
            else if (CossinOf.Equals(Coordenada.Y))
                return GetLenght(Vector)[1] / Module;
            else if (CossinOf.Equals(Coordenada.Z))
                return GetLenght(Vector)[2] / Module;

            return 0;
        }

        /// <summary>
        /// Calcula os cossenos diretores de um vetor R3
        /// </summary>
        /// <param name="Vector">Objeto do tipo <b>Vetor</b></param>
        /// <returns></returns>

        public static double[] GetCossinDirector(Vetor Vector)
        {
            double Module = GetModule(Vector);
            double[] Cossenos = new double[3];

            Cossenos[0] = GetLenght(Vector)[0] / Module;
            Cossenos[1] = GetLenght(Vector)[1] / Module;
            Cossenos[2] = GetLenght(Vector)[2] / Module;

            return Cossenos;
        }

        /// <summary>
        /// Calculo a decomposição de um vetor em suas componentes Fx, Fy e Fz
        /// </summary>
        /// <param name="DirectorCossin">Cossenos diretores de X, Y e Z</param>
        /// <param name="Magnitude">Magnitude do vetor</param>
        /// <returns></returns>

        public static double[] GetComponents(double[] DirectorCossin, double Magnitude)
        {
            double[] Componentes = new double[3];
            Componentes[0] = DirectorCossin[0] * Magnitude;
            Componentes[1] = DirectorCossin[1] * Magnitude;
            Componentes[2] = DirectorCossin[2] * Magnitude;

            return Componentes;
        }

        /// <summary>
        /// Retorna o ângulo theta em graus
        /// </summary>
        /// <param name="Cossin">Cosseno</param>
        /// <returns></returns>

        public static double GetAngleByCossin(double Cossin)
        {
            return (Math.Acos(Cossin) * 180) / Math.PI;
        }

        /// <summary>
        /// Calcula o momento de uma força F, sob um ponto P
        /// </summary>
        /// <param name="Vector">Objeto <b>Vetor</b></param>
        /// <param name="P">Ponto de estudo</param>
        /// <returns>double[] com os momentos em i, j e k, respectivamente no vetor double[]</returns>

        public static double[] GetMomento(Vetor Vector, Ponto P)
        {
            double Ri, Rj, Rk;

            if (VariaveisGlobais.Unidades.UnidadeMomento == ConvencaoUnidades.MomentunUnit.KnM)
            {
                Ri = Math.Abs(Vector.GetPoint(0).GetX * (Vector.UnidadeDeMedida == MetricUnit.M ? 1 : (1 / 100)) - P.GetX);    //i
                Rj = Math.Abs(Vector.GetPoint(0).GetY * (Vector.UnidadeDeMedida == MetricUnit.M ? 1 : (1 / 100)) - P.GetY);    //j
                Rk = Math.Abs(Vector.GetPoint(0).GetZ * (Vector.UnidadeDeMedida == MetricUnit.M ? 1 : (1 / 100)) - P.GetZ);    //k
            }
            else
            {
                Ri = Math.Abs(Vector.GetPoint(0).GetX * (Vector.UnidadeDeMedida == MetricUnit.Cm ? 1 : 100) - P.GetX);    //i
                Rj = Math.Abs(Vector.GetPoint(0).GetY * (Vector.UnidadeDeMedida == MetricUnit.Cm ? 1 : 100) - P.GetY);    //j
                Rk = Math.Abs(Vector.GetPoint(0).GetZ * (Vector.UnidadeDeMedida == MetricUnit.Cm ? 1 : 100) - P.GetZ);    //k
            }

            double Fx, Fy, Fz;

            if (VariaveisGlobais.Unidades.UnidadeMomento == ConvencaoUnidades.MomentunUnit.KnM)
            {
                Fx = Vector.GetComponents[0] * (Vector.UnidadeDeForca == ForceUnit.Kn ? 1 : 1 / 1000);
                Fy = Vector.GetComponents[1] * (Vector.UnidadeDeForca == ForceUnit.Kn ? 1 : 1 / 1000);
                Fz = Vector.GetComponents[2] * (Vector.UnidadeDeForca == ForceUnit.Kn ? 1 : 1 / 1000);
            }
            else
            {
                Fx = Vector.GetComponents[0] * (Vector.UnidadeDeForca == ForceUnit.N ? 1 : 1000);
                Fy = Vector.GetComponents[1] * (Vector.UnidadeDeForca == ForceUnit.N ? 1 : 1000);
                Fz = Vector.GetComponents[2] * (Vector.UnidadeDeForca == ForceUnit.N ? 1 : 1000);
            }

            double Mi, Mj, Mk;

            Mi = Rj * Fz - Rk * Fy;
            Mj = Rk * Fx - Ri * Fz;
            Mk = Ri * Fy - Rj * Fx;

            return new double[] { Mi, Mj, Mk };
        }
    }

    /// <summary>
    /// Identifica uma coordenada cartesiana
    /// </summary>

    public enum Coordenada
    {
        X,
        Y,
        Z
    }

    /// <summary>
    /// Identifica o quadrante de um ângulo, medido em sentido anti-horário a partir do semi-eixo das abiscissas
    /// </summary>

    public enum Quadrantes
    {
        I,
        II,
        III,
        IV
    }
}
