using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenPark
{
    internal abstract class Dier
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Dier (string naamin, int leeftijdin)
        {
            Naam = naamin;
            Leeftijd = leeftijdin;
        }

        public abstract string MaakGeluid();

        public void Tooninfo()
        {
            Console.WriteLine($"{Naam}, {Leeftijd}, geluid: {MaakGeluid()}");
        }
    }
}
