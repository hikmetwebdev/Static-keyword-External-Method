using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_keyword__External_Method_home.Modes
{
    public static class Extension2
    {
        public static bool isPrime(this int number)
        {
            if (number <= 1) return false; 
            if (number == 2) return true;

            int d = 0;
            for (int i = 3; i < number; i++)
            {
                if (number %i==0)
                {
                    d++;
                }
            }
            if (d == 2)
            {
                return false;   
            }
            return true;
        }
    }
}
