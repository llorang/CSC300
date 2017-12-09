using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.Fermentation
{
     public class Fermentation
    {
        public int Day { get; set; }
        public double Temp { get; set; }

        public string Display
        { get
            {
                return String.Format("Day {0}  Temp {1}", Day, Temp);
            }
        }

    }
}
