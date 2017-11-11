using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct RangePair{
    public double lower;
    public double upper;
};

namespace AlcoholMaker
{
    public abstract class FermentedProducts : Alcohol
    {
         KeyValuePair<double,string> LowerTempRange;
         KeyValuePair<double, string> UpperTempRange;
        //KeyValuePair<double, double> keyValue = new KeyValuePair<double, double>("string", 1);

        public string Name{get;set;}
        public double BatchVolume { get; set; }

        protected virtual string _productType {get { return "Fermented Product"; }}



        public double OG
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

        public double FG
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

        public int BatchID
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

        public virtual string YeastType
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



        public BrewMethod CurrentMethod;
        public enum BrewMethod { Extract, PartialMash, AllGrain, Other}

        //Constructor for cider, mead & wine
        public FermentedProducts(string name, double BatchVolume)
        {
            Name = name;
        }

        //Constructor for beer requires multiple brewing methods
        public FermentedProducts(string name, double batchVolume, BrewMethod brewMethod)
        {
            Name = name;
            BatchVolume = batchVolume;
            CurrentMethod = brewMethod;
        }

        public virtual void YeastCalc()
        {
            throw new NotImplementedException();
        }
    }
}
