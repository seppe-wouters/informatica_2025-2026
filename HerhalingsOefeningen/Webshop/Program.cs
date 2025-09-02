using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product appelmoes = new Product("appelmoes", 2.5, "het is appelmoes");
            Product chips = new Product("chips", 3.5, "het is chips");

            Bestelregel bestelregel1 = new Bestelregel(appelmoes, 3);
            Bestelregel bestelregel2 = new Bestelregel(chips, 2);

            Bestelling bestelling = new Bestelling();
            bestelling.BestelRegels.Add(bestelregel1);
            bestelling.BestelRegels.Add(bestelregel2);

            bestelling.BerekenTotaal();
        }
    }
}
