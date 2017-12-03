using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.Bottling
{
    public interface IBottlingBeer
    {
        string BottleType { get; set; }
        int BottleVolume { get; set; }
        string PrimingSugarType { get;}
        double PrimingSugarAmount(double batchVolume);
    }
}
