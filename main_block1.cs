using System;
using System.Drawing;

namespace rectangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            try
            {
                Console.Write("Введіть першу сторону: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введіть другу сторону: ");
                double b = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(a, b);
                Console.Write("Периметр прямокутника: ");
                Console.WriteLine(rectangle.Perimeter);
                Console.Write("Площа прямокутника: ");
                Console.WriteLine(rectangle.Area);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}