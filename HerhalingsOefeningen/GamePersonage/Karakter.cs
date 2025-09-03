using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePersonage
{
    internal abstract class Karakter
    {
        public string Naam { get; set; }
        public int Level { get; set; }
        public int HP { get; set; } = 100;
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

        public Karakter(string naamin, int levelin)
        {
            Naam = naamin;
            Level = levelin;
        }

        public abstract void ValAan(Karakter Doelwit);
        public abstract void SpecialMove(Karakter Doelwit);
            
    }
}
