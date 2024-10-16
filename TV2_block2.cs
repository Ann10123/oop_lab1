using System;
using System.Drawing;

namespace tvector2d
{
    public class TVector2D
    {
        protected double x, y;
        public TVector2D()
        {
            x = 0;
            y = 0;
        }
        public TVector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Input()
        {
            Console.Write("X: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());
        }
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public double Length
        {
            get
            {
                return (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));
            }
        }
        public string Normalization
        {
            get
            {
                if (Length == 0)
                {
                    return "Неможливо нормалізувати нульовий вектор";
                }
                return ($"{x / Length}, {y / Length}");
            }
        }

        public string Equality(TVector2D other)
        {

            if (x == other.X && y == other.Y)
            {
                return "Вектори рівні";
            }
            else
            {
                return "Вектори не рівні"; 
            }
        }

        public static TVector2D operator +(TVector2D v1, TVector2D v2)
        {
            return new TVector2D(v1.x + v2.x, v1.y + v2.y);
        }

        public static TVector2D operator -(TVector2D v1, TVector2D v2)
        {
            return new TVector2D(v1.x - v2.x, v1.y - v2.y);
        }

        public static double operator *(TVector2D v1, TVector2D v2)
        {
            return v1.x * v2.x + v1.y * v2.y;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
