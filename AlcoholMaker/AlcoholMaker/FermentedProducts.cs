using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    public abstract class FermentedProducts : Alcohol
    {
         KeyValuePair<double,string> LowerTempRange;
         KeyValuePair<double, string> UpperTempRange;
        //KeyValuePair<double, double> keyValue = new KeyValuePair<double, double>("string", 1);

        public string Name{get;set;}

        public virtual string Type
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

        public virtual string Method
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

        public double BatchVolume { get; set; }

        public BrewMethod CurrentMethod = BrewMethod.Extract;
        public enum BrewMethod { Extract, PartialMash, AllGrain, Other}

        public FermentedProducts(string name)
        {
            Name = name;
        }

        public FermentedProducts(string name,bool extract)
        {
            Name = name;
        }

        public virtual void YeastCalc()
        {
            throw new NotImplementedException();
        }
    }
}
