using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    using Bottling;

    public class Ale : Beer, IBottlingBeer
    {
        protected override string _beerType { get { return "Ale"; } }
        public string BeerType { get;}
      
        public string BottleType { get; set; }
        public int BottleVolume { get; set; }
        public string PrimingSugarType { get { return "cane sugar"; } }

        public Ale(string name, double batchvolume, BrewMethod brewMethod, double IBUs, string bottleType, int bottleVol) : base(name, batchvolume, brewMethod, IBUs)
        {
            BeerType = _beerType;
            BottleType = bottleType;
            BottleVolume = bottleVol;
        }

        public double PrimingSugarAmount(double batchVolume)
        {
            return 3.7 * (batchVolume / 5.0);  //Returns sugar amount in dry ounces (3.7 dry oz cane sugar per 5 gal)
        }
    }


}
