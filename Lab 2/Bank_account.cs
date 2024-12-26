using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Bank_account
    {
        public int act_no;
        public string email;
        public string u_name;
        public string act_type;
        public double act_balance;

        public void GetaccountDetails()
        {
            Console.Write("enter act_no : ");
            act_no = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter email : ");
            email = Convert.ToString(Console.ReadLine());
            Console.Write("enter u_name : ");
            u_name = Convert.ToString(Console.ReadLine());
            Console.Write("enter act_type : ");
            act_type = Convert.ToString(Console.ReadLine());
            Console.Write("enter act_balance : ");
            act_balance = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayaccountDetails()
        {
            Console.WriteLine("-------account's detail-------");
            Console.WriteLine("act_no is " + act_no);
            Console.WriteLine("email is " + email);
            Console.WriteLine("u_name is " + u_name);
            Console.WriteLine("act_type is " + act_type);
            Console.WriteLine("act_balance is " + act_balance);
        }
    }
}
