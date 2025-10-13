using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Presentatie 
{
    internal class SorterenOpPrijs : IComparer<Kledingstuk>
    {
        public int Compare(Kledingstuk x, Kledingstuk y)
        {
            if (x.Prijs > y.Prijs) return -1;
            else if (x.Prijs < y.Prijs) return 1;
            else return 0;
        }
    }
}
