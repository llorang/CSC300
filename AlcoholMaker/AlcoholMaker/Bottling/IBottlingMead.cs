using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholMaker.Bottling
{
    public interface IBottlingMead
    {
        string BottleType { get; set; }
        int BottleVolume { get; set; }
        string PrimingHoneyType { get; }
        double PrimingHoneyAmount(double batchVolume);
    }
}
