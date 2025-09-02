using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dier> Dieren = new List<Dier>();

            Olifant olifant = new Olifant("jeff", 8);
            Leeuw leeuw = new Leeuw("bob", 6);
            Papegaai papegaai = new Papegaai("kuba", 3);

            Dieren.Add(olifant);
            Dieren.Add(leeuw);
            Dieren.Add(papegaai);

            foreach (var dier in Dieren)
            {
                dier.Tooninfo();
            }

            olifant.Voeder();
            papegaai.Voeder();

        }
    }
}
