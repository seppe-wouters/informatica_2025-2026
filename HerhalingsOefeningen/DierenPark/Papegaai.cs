using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenPark
{
    internal class Papegaai : Dier, IVoeder
    {
        public Papegaai(string naamin, int leeftijdin) : base(naamin, leeftijdin) { }

        public override string MaakGeluid()
        {
            return "Ik ben een papegaai";
        }

        public void Voeder()
        {
            Console.WriteLine($"Het {Naam} is gevoederd");
        }
    }
}
