using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Rectangle
    {
        public int length;
        public int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public void DisplayRectangleArea()
        {
            Console.WriteLine("Rectangle area is "+(length*width));
        }
    }
}
