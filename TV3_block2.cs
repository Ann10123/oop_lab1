using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace tvector2d
{
    public class TVector3D : TVector2D
    {
        private  double z;
        public TVector3D() : base()
        {
            z = 0;
        }
        public TVector3D(double x, double y, double z) : base(x, y)
        {
            this.z = z;
        }
        public TVector3D(TVector2D vector2D, double z) : base(vector2D.X, vector2D.Y)
        {
            this.z = z;
        }
        public new void Input()
        {
            Console.Write("Z: ");
            z = double.Parse(Console.ReadLine());
        }
        public new double Length
        {
            get
            {
                double a = base.Length + Math.Pow(z, 2);
                return a;
            }
        }
        public string Normalization
        {
            get
            {
                double length = Length;
                if (length == 0)
                {
                    return "Неможливо нормалізувати нульовий вектор";
                }
                return $"{x / length}, {y / length}, {z / length}";
            }
        }
        public string Equality(TVector3D other)
        {
            if (x == other.X && y == other.Y && z == other.z)
            {
                return "Вектори рівні";
            }
            else
            {
                return "Вектори не рівні";
            }
        }
        public static TVector3D operator +(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static TVector3D operator -(TVector3D v1, TVector3D v2)
        {
            return new TVector3D(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static double operator *(TVector3D v1, TVector3D v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
