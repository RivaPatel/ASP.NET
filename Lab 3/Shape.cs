using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal interface Shape
    {
        double circle(double r);
        double square(double s);
        double triangle(double b , double h);
    }

    class implementShape : Shape
    {
        public double circle(double r) {
            return (3.14 * r *r);
        }

        public double square(double s) {
            return (s * s);
        }

        public double triangle(double b, double h)
        {
            return (b * h);
        }
    }
}
