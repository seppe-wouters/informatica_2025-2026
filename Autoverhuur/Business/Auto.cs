using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Auto
    {
        public string Merk { get; set; }
        public string Type { get; set; }
        public double HuurpijsPerDag { get; set; }
        public bool IsBeschikbaar { get; set; }

        public Auto(string merk, string type, double huurprijsPerDag)
        {
            Merk = merk;
            Type = type;
            HuurpijsPerDag = huurprijsPerDag;
            IsBeschikbaar = true; 
        }

        public override string ToString()
        {
            return $"{Merk} {Type} - {HuurpijsPerDag:C} per dag - {(IsBeschikbaar ? "Beschikbaar" : "Niet beschikbaar")}";
        }


    }
}
