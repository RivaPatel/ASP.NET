using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Salary
    {
        public double basic;
        public double TA;
        public double DA;
        public double HRA;

        public Salary(double basic, double TA, double DA=5,double HRA=10)
        {
            this.basic = basic; 
            this.TA = TA;
            this.DA = DA;
            this.HRA = HRA;
        }

        public double CalculateSalary()
        {
            double total = basic + TA + (basic * DA / 100) + (basic * HRA / 100);
            return total;
        }

        public void DisplaySalary()
        {
            Console.WriteLine("total salary is " + CalculateSalary());
        }


    }
}
