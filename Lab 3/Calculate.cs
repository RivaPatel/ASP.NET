using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface  Calculate
    {
        int add(int a,int b);

        int sub(int a,int b);

    }

    class result : Calculate
    {
        public int add(int a, int b)
        {
            return (a + b);
        }
        public int sub(int a, int b)
        {
            return (a - b); 
        }

    }
}
