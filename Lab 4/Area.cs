using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Area
    {
    public int CalculateArea(int side)
        {
            return side * side;
        }

    public int CalculateArea(int length, int width)
        {
            return length * width;
        }
    }
}
