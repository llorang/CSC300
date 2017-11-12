using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    public class BarleyWine : Beer
    {
        protected override string _beerType { get { return "BarleyWine"; } }

        public BarleyWine(string name, double batchvolume, BrewMethod brewMethod, double IBUs) : base(name, batchvolume, brewMethod, IBUs)
        {
            throw new NotImplementedException();
        }

    }
}
 