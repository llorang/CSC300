using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.Bottling
{
    public class Bottling
    {
        public static int CalcNumberOfBottles(double batchVol, int bottleVol)
        {
            return (int) (batchVol * 128 / bottleVol);
        }
    }
}
