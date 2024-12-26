using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
     public class Hospital
    {
        public virtual void HospitalDetails()
        {
            Console.WriteLine("General Hospital Details.");
        }
    }
    

    public class Apollo : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Apollo Hospital: Multispeciality hospital with advanced treatment facilities.");
        }
    }

    public class Wockhardt : Hospital
    {
        public override void HospitalDetails()
        {
            Console.WriteLine("Wockhardt Hospital: Known for cardiac care and critical surgeries.");
        }
    }

    public class Gokul_Superspeciality : Hospital
    {
        // Overriding the HospitalDetails method
        public override void HospitalDetails()
        {
            Console.WriteLine("Gokul Superspeciality Hospital: Specialized in oncology and orthopedics.");
        }

    }
}
