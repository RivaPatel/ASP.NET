using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Staff
    {
        public string name;
        public string department;
        public string designation;
        public int experience;
        public int salary;

        public void GetStaffDetails()
        {
            Console.Write("enter name : ");
            name = Console.ReadLine();
            Console.Write("enter department : ");
            department = Console.ReadLine();
            Console.Write("enter designation : ");
            designation = Console.ReadLine();
            Console.Write("enter experience : ");
            experience = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter salary : ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("name is " + name);
            Console.WriteLine("salary is " + salary);
        }
    }
}
