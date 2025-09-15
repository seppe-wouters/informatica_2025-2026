using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets250915
{
    internal class Tankbeurt
    {
        //props
        public int AantalLiters { get; set; }
        public int Kilometerstand { get; set; }
        public int VorigeKilometerstand { get; set; }
        public double TotalePrijs { get; }
        public double PrijsPerLiter { get; set; }
        public double VerbruikPer100km { get; }

        //constructor
        public Tankbeurt(int aantalLiters, int kilometerstand, int vorigeKilometerstand, double prijsPerLiter)
        {
            AantalLiters = aantalLiters;
            Kilometerstand = kilometerstand;
            VorigeKilometerstand = vorigeKilometerstand;
            PrijsPerLiter = prijsPerLiter;
        }

        //methodes
        public double BerekenVerbruik()
        {
            return (Convert.ToDouble(AantalLiters) / (Convert.ToDouble(Kilometerstand) - Convert.ToDouble(VorigeKilometerstand))) * 100; ;
        }

        public double BerekenTotPrijs()
        {
            return AantalLiters * PrijsPerLiter;
        }

    }
}
