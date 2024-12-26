using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        public int Dis1;
        public int Dis2;
        public int Dis3;

        public Distance(int dis1, int dis2)
        {
            Dis1 = dis1; 
            Dis2 = dis2;
        }

        public void CalculateDistance()
        {
            Dis3 = Dis1 + Dis2;
        }

        public void DisplayDistance()
        {
            Console.WriteLine("total distance is " + Dis3);
        }
    }
}
