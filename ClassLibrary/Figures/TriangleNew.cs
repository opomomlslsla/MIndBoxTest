using ClassLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Figures
{
    public class TriangleNew :Triangle
    {
        public bool IsRight(double a, double b, double c)
        {
            List<double> list = new List<double>() { a, b, c };
            if (a * a == b * b + c * c | b * b == a * a + c * c | c * c == b * b + a * a)
            {
                return true;
            }

            return false;
        }
    }
}
