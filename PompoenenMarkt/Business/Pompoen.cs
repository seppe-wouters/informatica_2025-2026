using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pompoen
    {
        public string Soort { get; set; }
        public double GewichtKg { get; set; }
        public decimal PrijsPerKg { get; set; }

        public Pompoen(string soort, double gewichtKg, decimal prijsPerKg)
        {
            Soort = soort;
            GewichtKg = gewichtKg;
            PrijsPerKg = prijsPerKg;
        }

        public decimal TotaalPrijs()
        {
            return (decimal)GewichtKg * PrijsPerKg;
        }

        public override string ToString()
        {
            return $"{Soort} - {PrijsPerKg} EUR - {GewichtKg} KG";
        }
    }
}
