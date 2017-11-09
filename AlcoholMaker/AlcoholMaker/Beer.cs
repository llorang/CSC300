using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    public abstract class Beer : FermentedProducts
    {
        public static int CurrentBatchNumber { get; private set; }
        public static int PrevBatchNumber { get; private set; }
        const double H2OtoGrainRatio = 2.0;
        const double H2ORetentionRatio = 0.5;
        double PreBoilGrav;
        double IBUvalue;

        public double StrikeWaterVolume
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double StrikeWaterTemperature
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        protected Beer()
        {
            throw new NotImplementedException();
        }

        public void InfusionSingleRest()
        {
            throw new NotImplementedException();
        }

        public void GrainBill()
        {
            throw new NotImplementedException();
        }

        public double MashRunnings()
        {
            throw new NotImplementedException();
        }

        public double PreBoilGravity()
        {
            throw new NotImplementedException();
        }

        public double ConversionEfficiency()
        {
            throw new NotImplementedException();
        }

        public void IBUcalculation()
        {
            throw new NotImplementedException();
        }
    }
}
