using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.GeneralBeer.Hops
{
    public class Hops
    {
        public string Variety { get; set; }
        public double Weight { get; set; }
        public double AApercent { get; set; }
        public int BoilTime { get; set; }

        public Hops(string variety, double weight, double aaPercent, int time)
        {
            Variety = variety;
            Weight = weight;
            AApercent = aaPercent;
            BoilTime = time;
        }

        public double CalculateIBU(double wortGravity, double wortVolume)
        {
            double gravFactor = 1.65 * Math.Pow(0.000125, (wortGravity - 1.0));               //Utilization factor as a function of wort gravity
            double timeFactor = (1.0 - Math.Exp(-0.04 * BoilTime)) / 4.15;                    //Utilization factor as a function of boil time
            double IBU = Weight * AApercent * gravFactor * timeFactor * 75.0 / wortVolume;    //75 is a conversion factor from English units to metric
            return IBU;                                                                       //IBU units are milligrams per liter
        }
    }
}
