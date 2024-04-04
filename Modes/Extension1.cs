using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_keyword__External_Method_home.Modes
{
    public static class Extension1
    {
       public static long FindFactorial(this int number)
        {
            if (number < 0)
                throw new ArgumentException("Number must be non-negative.");

            long factorial = 1;
            for (int i =1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial; 
        }
    }
}
