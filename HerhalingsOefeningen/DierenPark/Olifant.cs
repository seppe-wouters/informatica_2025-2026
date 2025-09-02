using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenPark
{
    internal class Olifant : Dier, IVoeder
    {
        public Olifant(string naamin, int leeftijdin) : base(naamin, leeftijdin) { }

        public override string MaakGeluid()
        {
            return "Ik ben een olifant";
        }

        public void Voeder()
        {
            Console.WriteLine($"Het {Naam} is gevoederd");
        }
    }
}
