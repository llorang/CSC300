using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.Measurement.Hydrometer
{
    public class Hydrometer
    {
        public double Reading { get; private set; }
        public int Temp { get; private set; }

        public Hydrometer(double reading, int temp)
        {
            Reading = reading;
            Temp = temp;
        }

        public Hydrometer TempCorrect(int TC)   //TC = calibration temperature (60 F or 68 F)
        {
            return new Hydrometer(
            Reading * ((1.00130346 - 0.000134722124 * Temp + 0.00000204052596 * Math.Pow(Temp, 2) - 0.00000000232820948 * Math.Pow(Temp, 3)) /
            (1.00130346 - 0.000134722124 * TC + 0.00000204052596 * Math.Pow(TC, 2) - 0.00000000232820948 * Math.Pow(TC, 3))),
            TC);
        }
    }
}
