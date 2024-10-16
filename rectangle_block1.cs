using System;
using System.Drawing;

namespace rectangle
{
    public class Rectangle
    {
        private double a, b;
        public Rectangle(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                throw new ArgumentException("Неправильний формат чисел!");
            }
            this.a = a;
            this.b = b;
        }
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (a > 0)
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (b > 0)
                {
                    b = value;
                }
            }
        }
        public double Perimeter
        {
            get
            {
                return 2 * (a + b);
            }
        }
        public double Area
        {
            get
            {
                return a * b;
            }
        }
    }
}
