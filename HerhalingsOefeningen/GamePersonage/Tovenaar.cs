using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePersonage
{
    internal class Tovenaar : Karakter, IBeweegbaar
    {
        public int MagischeKracht { get; set; }

        public Tovenaar(string naamin, int levelin, int magischekrachtin) : base(naamin, levelin)
        {
            MagischeKracht = magischekrachtin;
        }
        public override void SpecialMove(Karakter Doelwit)
        {
            Console.WriteLine($"{Naam} valt {Doelwit.Naam} aan met een special move met de kracht van {MagischeKracht*2 + Level}");
            Doelwit.HP -= MagischeKracht * 2 + Level;
        }

        public override void ValAan(Karakter Doelwit)
        {
            Console.WriteLine($"{Naam} valt {Doelwit.Naam} aan met een standaard aanval met de kracht van {MagischeKracht}");
            Doelwit.HP -= MagischeKracht + Level;
        }

        public void Bewegen(int x, int y)
        {
            if (x > 20 || x < -20)
            {
                Console.WriteLine($"{Naam} probeert te ver te bewegen");
            }
            else
            {
                X = x;
                Y = y;
                Console.WriteLine($"{Naam} is bewogen met x = {x} en y = {y}");
            }
        }
    }
}
