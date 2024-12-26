using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Area2
    {

       
        public double CalculateArea(double side)
        {
            return side * side;
        }

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public float Calculatearea(float radius)
        {

            return (float)3.14 * radius * radius; 
       
        }
    }
}

