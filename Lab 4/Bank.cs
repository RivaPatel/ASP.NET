using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Bank
    {
        public class RBI
        {
            // Virtual method to calculate interest
            public virtual void CalculateInterest()
            {
                Console.WriteLine("RBI: Generic Interest Calculation");
            }
        }

        public class HDFC : RBI
        {
            // Overriding the CalculateInterest method
            public override void CalculateInterest()
            {
                Console.WriteLine("HDFC: Calculating interest at 6.5% per annum.");
            }
        }

        public class SBI : RBI
        {
            // Overriding the CalculateInterest method
            public override void CalculateInterest()
            {
                Console.WriteLine("SBI: Calculating interest at 5.5% per annum.");
            }
        }

        public class ICICI : RBI
        {
            // Overriding the CalculateInterest method
            public override void CalculateInterest()
            {
                Console.WriteLine("ICICI: Calculating interest at 7% per annum.");
            }
        }

    }
}
