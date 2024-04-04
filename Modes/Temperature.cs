using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_keyword__External_Method_home.Modes
{
    public static class Temperature
    {

        public static double ConvertTemp( this double temp)
        { 
            return (temp * 9) / 5 + 32;
        }
    }
}
