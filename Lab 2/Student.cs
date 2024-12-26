using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
        public long envno;
        public string name;
        public int sem;
        public double spi;
        public double cpi;

        public Student(long envno, string name, int sem, double spi, double cpi)
        {
            this.envno = envno;
            this.name = name;
            this.sem = sem;
            this.spi = spi;
            this.cpi = cpi;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("enrollment no is " + envno);
            Console.WriteLine("name  is " + name);
            Console.WriteLine("sem is " + sem);
            Console.WriteLine("spi is " + spi);
            Console.WriteLine("cpi is " + cpi);
        }
    }
}
