﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker
{
    public class Lager : Beer
    {
        protected override string _beerType { get { return "Lager"; } }

        public Lager(string name, double batchvolume, BrewMethod brewMethod, double IBUs) : base(name, batchvolume, brewMethod, IBUs)
        {
            throw new NotImplementedException();
        }

    }
}
