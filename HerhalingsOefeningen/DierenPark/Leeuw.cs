using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenPark
{
    internal class Leeuw : Dier
    {
        public Leeuw(string naamin, int leeftijdin) : base(naamin, leeftijdin) {}

        public override string MaakGeluid()
        {
            return "WRAGH";
        }
        
    }
}
