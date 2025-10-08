using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class MenuItem
    {
        public string Naam { get; private set; }
        public decimal Prijs { get; private set; }
        public int Calorieen { get; private set; }

        public MenuItem(string naam, decimal prijs, int calorieen)
        {
            Naam = naam;
            Prijs = prijs;
            Calorieen = calorieen;
        }

        public override string ToString()
        {
            return $"{ Naam} - { Prijs} EUR - { Calorieen} kcal";
        }
    }
}
