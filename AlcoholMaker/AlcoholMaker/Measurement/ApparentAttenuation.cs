using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.Measurement
{
    public class ApparentAttenuation
    {
        //Function returns ABV in units of percent.
        //Equation from BYO Magazine, Vol 15, Issue 4
        public static double CalcAA(double OG, double FG)
        {
            return (OG - FG) / FG * 100;
        }
    }
}
