using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolbib
{
    internal class Bib
    {
        public List<Boek> Boeken { get; set; } = new List<Boek>();

        public void VerwijderBoek(Boek boek)
        {
            if (Boeken.Remove(boek))
            {
                Console.WriteLine($"het boek {boek.Titel} is verwijderd");
            }
            else
            {
                Console.WriteLine($"het boek {boek.Titel} zit niet in de bib");
            }
        }

        public void VoegToe(Boek boek)
        {
            if (Boeken.Any(b => b.Titel == boek.Titel))
            {
                Console.WriteLine($"het boek {boek.Titel} is al toegevoegd");
            }
            else
            {
                Boeken.Add(boek);
                Console.WriteLine($"het boek {boek.Titel} is toegevoegd");
            }
        }
    }
}
