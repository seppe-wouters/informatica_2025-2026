using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePersonage
{
    internal class Strijder : Karakter, IBeweegbaar
    {
        public int Kracht { get; set; }

        public Strijder(string naamin, int levelin, int Krachtin) : base(naamin, levelin)
        {
            Kracht = Krachtin;
        }

        public override void SpecialMove(Karakter Doelwit)
        {
            Console.WriteLine($"{Naam} valt {Doelwit.Naam} aan met een kracht van {Kracht*2 + Level} (Special move)");
            Doelwit.HP -= Kracht * 2 + Level;
        }

        public override void ValAan(Karakter Doelwit)
        {
            Console.WriteLine($"{Naam} valt {Doelwit.Naam} aan met een kracht van {Kracht} ");
            Doelwit.HP -= Kracht + Level;
        }

        public void Bewegen(int x, int y)
        {
            if (x > 10 || x < -10)
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
