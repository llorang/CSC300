using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.Measurement
{
     public class ABV
    {
        //Function returns ABV in units of percent.
        //Equation from BYO Magazine, Vol 18, Issue 1
        public static double CalculateABV(double OG, double FG)
        {
            return (OG - FG) * 0.129 * 1000;  
        }
    }
}
