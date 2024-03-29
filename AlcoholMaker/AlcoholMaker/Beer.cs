﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    using Measurement.Hydrometer;

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
        public static double StrikeWaterVolume { get; set; }
        public static int StrikeWaterTempTarget { get; set; }
        public static int StrikeTempActual { get; set; }
        public static double WortVolume { get; set; }

        public static Hydrometer PreBoilGravUncorrected;
        public static Hydrometer PreBoilGravCorrected;

        public const double PointsPerGallon = 38.0;
        public static double ConversionEfficiency { get; set; }
        public static string HopVariety { get; set; }
        public static  double HopAAU { get; set; }

        public static Hydrometer PostBoilGravUncorrected;
        public static Hydrometer PostBoilGravCorrected;

        public static Hydrometer FinalGravUncorrected;
        public static Hydrometer FinalGravCorrected;

        public static double ApparentAttenuation { get; set; }
        public static int BottlesFilled { get; set; }
        public static List<Fermentation.Fermentation> FermTemps;

        public Beer(string name, double batchvolume, BrewMethod brewMethod, double IBUs) : base(name, batchvolume, brewMethod)
        {
            IBUvalue = IBUs;
            BeerEquipExtractList = new List<string>();
            BeerEquipAllGrainList = new List<string>();
        }

        public static double ConversionEfficiencyCalc(double wortVol, double grainBill)
        {
            return PointsPerGallon * (wortVol / 4.0) / grainBill;
        }

        public void IBUCalc()
        {
            throw new NotImplementedException();
        }
    }
}
