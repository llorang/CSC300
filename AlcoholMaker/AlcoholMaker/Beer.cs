using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    public abstract class Beer : FermentedProducts
    {
        protected override string _productType { get { return "Beer"; } }
        protected virtual string _beerType { get { return "Generic Beer"; } }

        public double IBUvalue { get; set; }

        public static int CurrentBatchNumber { get; private set; }
        public static int PrevBatchNumber { get; private set; }

        public static List<string> BeerEquipExtractList;
        public static List<string> BeerEquipAllGrainList;

        public static List<string> BeerIngredExtractList;
        public static List<string> BeerIngredAllGrainList;

        public const double H2OtoGrainRatio = 2.0;
        public const double H2ORetentionRatio = 0.5;
        public static int MashTime { get; set; }
        public static int MashTemp { get; set; }
        public static int StrikeTempActual { get; set; }
        double PreBoilGrav;



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

        public Beer(string name, double batchvolume, BrewMethod brewMethod, double IBUs) : base(name, batchvolume, brewMethod)
        {
            IBUvalue = IBUs;
            BeerEquipExtractList = new List<string>();
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
