using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Account_Details
    {
        public int act_no;
        public double Principal;
        public double rate;
        public double time;

        public void GetAccountDetails()
        {
            Console.Write("enter act_no : ");
            act_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter Principal : ");
            Principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter Interest rate : ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter time : ");
            time = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("-------account's detail-------");
            Console.WriteLine("act_no is " + act_no);
            Console.WriteLine("principal is "+Principal);
            Console.WriteLine("Interest rate is " + rate);
            Console.WriteLine("time period is " + time);

        }
    }

    class Interest : Account_Details
    {
        public double Caluculate()
        {
            return (Principal * rate * time) / 100;
        }

        public void DisplayCalculate()
        {
            double total = Caluculate();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("total intrest is "+total);
        }
    }
}
