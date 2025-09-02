using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Bestelling
    {
        public List<Bestelregel> BestelRegels { get; set; } = new List<Bestelregel>();

        public void BerekenTotaal()
        {
            double totaalprijs = 0;
            foreach (var bestelregel in BestelRegels)
            {
                totaalprijs += (bestelregel.BesteldProduct.Prijs * bestelregel.Aantal);
            }

            Console.WriteLine($"De totaalprijs is {totaalprijs}");
        }
    }
}
