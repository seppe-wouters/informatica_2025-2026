using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePersonage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Karakter> karakters = new List<Karakter>();
            Random rng = new Random();

            karakters.Add(new Strijder("bob", 8, 2));
            karakters.Add(new Tovenaar("wilfried", 2, 6));
            karakters.Add(new Strijder("jeff", 5, 10));
            karakters.Add(new Tovenaar("merlijn", 3, 10));

            for (int i = 0; i < 5; i++)
            {
                int persoon1 = rng.Next(0, 4);
                int persoon2 = rng.Next(0, 4);


                int random = rng.Next(1, 6);

                if ( random == 1)
                {
                    karakters[persoon1].SpecialMove(karakters[persoon2]);
                    if (karakters[persoon2] is IBeweegbaar bewegen)
                    {
                        bewegen.Bewegen(5, 5);
                    }
                }
                else
                { 
                   karakters[persoon1].ValAan(karakters[persoon2]);
                }
            }

            
        }

    }
}
