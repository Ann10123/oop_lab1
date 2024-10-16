using System;
using System.Drawing;
using System.Numerics;

namespace tvector2d
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                Console.WriteLine("Введіть координати першого вектора:");
                TVector2D vector1 = new TVector2D();
                vector1.Input();
                Console.WriteLine("Введіть координати другого вектора:");
                TVector2D vector2 = new TVector2D();
                vector2.Input();
                Console.WriteLine();
                Console.WriteLine("-Двовимірний простір:");
                Console.Write("Координати першого вектора:" + vector1.ToString() + "\n");
                Console.Write("Координати другого вектора:" + vector2.ToString() + "\n");
                Console.WriteLine("Довжина вектора: " + vector1.Length);
                Console.WriteLine("Нормалізація вектора: " + vector1.Normalization);
                Console.WriteLine("Рівність векторів: " + vector1.Equality(vector2));
                Console.WriteLine("Сума векторів: " + (vector1 + vector2));
                Console.WriteLine("Різниця векторів: " + (vector1 - vector2));
                Console.WriteLine("Скалярний добуток векторів: " + (vector1 * vector2) + "\n");

                Console.WriteLine("-Тривимірний простір:");
                TVector3D vector3 = new TVector3D(vector1, 0);
                Console.Write("1-ий вектор ");
                vector3.Input();
                TVector3D vector4 = new TVector3D(vector2, 0);
                Console.Write("2-ий вектор ");
                vector4.Input();
                Console.WriteLine();
                Console.Write("Координати першого вектора:" + vector3.ToString() + "\n");
                Console.Write("Координати другого вектора:" + vector4.ToString() + "\n");
                Console.WriteLine("Довжина вектора: " + vector3.Length);
                Console.WriteLine("Нормалізація вектора: " + vector3.Normalization);
                Console.WriteLine("Рівність векторів: " + vector3.Equality(vector4));
                Console.WriteLine("Сума векторів: " + (vector3 + vector4));
                Console.WriteLine("Різниця векторів: " + (vector3 - vector4));
                Console.WriteLine("Скалярний добуток векторів: " + (vector3 * vector4) + "\n");
            }
            finally
            {
                Console.WriteLine("Тестування завершено!");
            }
        }
    }
}