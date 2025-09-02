using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Bestelregel
    {
        public Product BesteldProduct { get; set; }
        public int Aantal { get; set; }

        public Bestelregel(Product productin, int aantalin)
        {
            BesteldProduct = productin;
            Aantal = aantalin;
        }
    }
}
