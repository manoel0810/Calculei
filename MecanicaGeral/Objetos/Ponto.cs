namespace MecanicaGeral.Objetos
{
    public class Ponto
    {
        private readonly double X, Y, Z;

        public Ponto(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Ponto(double x, double y)
        {
            X = x;
            Y = y;
            Z = 0;
        }

        public double GetX { get { return X; } }
        public double GetY { get { return Y; } }
        public double GetZ { get { return Z; } }
    }
}
