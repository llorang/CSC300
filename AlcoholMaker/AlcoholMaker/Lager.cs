using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    using Bottling;

    public class Lager : Beer, IBottlingBeer
    {
        protected override string _beerType { get { return "Lager"; } }
        public string BeerType { get; set; }

        public string BottleType { get; set; }
        public int BottleVolume { get; set; }
        public string PrimingSugarType { get { return "corn sugar"; } }

        public Lager(string name, double batchvolume, BrewMethod brewMethod, double IBUs) : base(name, batchvolume, brewMethod, IBUs)
        {
            BeerType = _beerType;
        }

        public double PrimingSugarAmount(double batchVolume)
        {
            return 4.0 * (batchVolume / 5.0);  //Returns sugar amount in dry ounces (3.7 dry oz corn sugar per 5 gal)
        }
    }
}
