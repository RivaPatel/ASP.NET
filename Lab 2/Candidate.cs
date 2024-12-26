using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Candidate
    {
        public int id;
        public string name;
        public int age;
        public double weight;
        public double height;

        public void GetCandidateDetails()
        {
            Console.Write("enter id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter name : ");
            name = Convert.ToString(Console.ReadLine());
            Console.Write("enter age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter weight : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter height : ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("-------candidate's detail-------");
            Console.WriteLine("id is " + id);
            Console.WriteLine("name is " + name);
            Console.WriteLine("age is " + age);
            Console.WriteLine("weight is " + weight);
            Console.WriteLine("height is " + height);
        }
    }
}
