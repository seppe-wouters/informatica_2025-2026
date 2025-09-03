using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolbib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bib bib = new Bib();

            Boek boek1 = new Boek("Door het vuur", "M.J. Arlidge", 2025);
            Boek boek2 = new Boek("Waar de zon de sneeuw raakt", "Mélissa Da Costa", 2025);

            bib.Boeken.Add(boek1);
            bib.Boeken.Add(boek2);

            bib.VoegToe(new Boek("De zomerdochter", "Tessa Collins", 2025));
            bib.VerwijderBoek(boek1);
            bib.VoegToe(boek1);

            Console.WriteLine();

            for (int i = 0; i < bib.Boeken.Count; i++)
            {
                Console.WriteLine($"{bib.Boeken[i].Titel} - {bib.Boeken[i].Auteur}");
            }

            Console.WriteLine();
            bib.Boeken.Sort();

            for (int i = 0; i < bib.Boeken.Count; i++)
            {
                Console.WriteLine($"{bib.Boeken[i].Titel} - {bib.Boeken[i].Auteur}");
            }

        }
    }
}
