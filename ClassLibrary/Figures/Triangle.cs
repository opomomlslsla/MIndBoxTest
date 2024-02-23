using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Figures
{
    public class Triangle
    {
        public double AreaCalc(double a, double b, double c)
        {
            if (a + b > c & b + c > a & c + a > b)
            {
                var p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                throw new ArgumentException("Такого треугольника не существует");
            }
        }
    }
}