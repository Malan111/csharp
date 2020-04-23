using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MyLib
    {
        public static double Circle(float r)
        {
            double result = -1;
            if (r < 0)
                Console.WriteLine("Радиус не может быть отрицательным");
            else
                result = Math.PI * Math.Pow(r, 2);

            return result;

        }


        public static double Triangle(float a, float b, float c)
        {
            double result = -1;
            float p = 0;
            double max, test;
            if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("Стороны треугольника не могут быть отрицательными");
            else
            {
                p = (a + b + c) / 2;
                result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                if (a > b && a > c)
                {
                    max = a;
                    test = c * c + b * b;
                    max = Math.Pow(max, 2);
                }
                else if (b > c)
                {
                    max = b;
                    test = a * a + c * c;
                    max = Math.Pow(max, 2);
                }
                else
                {
                    max = c;
                    test = a * a + b * b;
                    max = Math.Pow(max, 2);
                }

                if (max == test)
                    Console.WriteLine("Треугольник прямоугольный");

            }



            return result;
        }
    }
}
