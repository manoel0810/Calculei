using MecanicaGeral.Calculo;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MecanicaGeral.Objetos
{
    public class Vetor
    {
        private readonly List<Ponto> Pontos = new List<Ponto>();
        private double[] CossinDirector = new double[3];
        private double[] Componentes = new double[3];
        private double[] Momentus = new double[3];

        /// <summary>
        /// Carrega as componentes do vetor
        /// </summary>

        public void LoadComponents()
        {
            Componentes = AlgebraVetorial.GetComponents(CossinDirector, Magnitude);
        }

        /// <summary>
        /// Sequência de inicialização do objeto <b>Vetor</b>, após sua instância inicial
        /// </summary>

        private void Load()
        {
            Modulo = AlgebraVetorial.GetModule(this);
            CossinDirector = AlgebraVetorial.GetCossinDirector(this);

            if (Theta > 0 && Theta <= 90)
                Quandrante = Quadrantes.I;
            else if (Theta >= 90 && Theta <= 180)
                Quandrante = Quadrantes.II;
            else if (Theta > 180 && Theta <= 270)
                Quandrante = Quadrantes.III;
            else if (Theta > 270 && Theta <= 360)
                Quandrante = Quadrantes.IV;
        }

        /// <summary>
        /// Inicia um objeto [Vetor] de tamanho definido por (Ponto Final - Ponto Inicial)
        /// </summary>
        /// <param name="Inicial">Ponto inicial</param>
        /// <param name="Final">Ponto final</param>

        public Vetor(Ponto Inicial, Ponto Final)
        {
            Pontos.Add(Inicial);
            Pontos.Add(Final);

            Load();
        }

        /// <summary>
        /// Inicia um objeto [Vetor] de tamanho definido por (Ponto Final - Origem { 0, 0, 0 })
        /// </summary>
        /// <param name="Final">Ponto final</param>

        public Vetor(Ponto Final)
        {
            Pontos.Add(new Ponto(0, 0, 0));
            Pontos.Add(Final);

            Load();
        }

        /// <summary>
        /// Obter objeto [Ponto] de index X
        /// </summary>
        /// <param name="Index">Index do elemento [Ponto]</param>
        /// <returns>Um objeto do tipo [Ponto]</returns>

        public Ponto GetPoint(int Index)
        {
            if (Index > Pontos.Count || Index < 0)
            {
                MessageBox.Show("Valor de index inválido");
                return null;
            }

            return Pontos[Index];
        }

        /// <summary>
        /// Obtém o tamanho do vetor
        /// </summary>
        public double Modulo { get; private set; }
        /// <summary>
        /// Nome do vetor
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ângulo XoY
        /// </summary>
        public double Theta { get; set; }
        /// <summary>
        /// Magnitude da força
        /// </summary>
        public double Magnitude { get; set; }
        /// <summary>
        /// Define os momentos deste vetor em relação a um ponto P declarado na hora do cálculo
        /// </summary>
        public double[] SetMoment { set { Momentus = value; } }
        /// <summary>
        /// Retorna as componentes do memento deste vetor
        /// </summary>
        public double[] GetMoment { get { return Momentus; } }
        /// <summary>
        /// Unidade de medida da força em Kn ou N
        /// </summary>
        public ForceUnit UnidadeDeForca { get; set; }
        /// <summary>
        /// Unidade de medida das distâncias
        /// </summary>
        public MetricUnit UnidadeDeMedida { get; set; }
        /// <summary>
        /// Obtém ou define o quadrante em qual o ângulo é definido
        /// </summary>
        public Quadrantes Quandrante { get; private set; }

        //---------------------------------------------//

        /// <summary>
        /// Obtém os cossenos diretores do vetor
        /// </summary>
        public double[] GetCossins { get { return CossinDirector; } }
        /// <summary>
        /// Obtém as componentes da força do vetor
        /// </summary>
        public double[] GetComponents { get { return Componentes; } }
    }

    /// <summary>
    /// Unidade de força
    /// </summary>

    public enum ForceUnit
    {
        /// <summary>
        /// Kn: Quilo * Newton
        /// </summary>
        Kn,
        /// <summary>
        /// Newton
        /// </summary>
        N
    }

    /// <summary>
    /// Unidade de métrica
    /// </summary>

    public enum MetricUnit
    {
        /// <summary>
        /// Cm: Centímetros
        /// </summary>
        Cm,
        /// <summary>
        /// M: Metros
        /// </summary>
        M
    }
}
