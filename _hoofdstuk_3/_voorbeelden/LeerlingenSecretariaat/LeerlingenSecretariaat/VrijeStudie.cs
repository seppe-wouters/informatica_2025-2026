using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerlingenSecretariaat
{
    public class VrijeStudie
    {
        public string Lokaal { get; }
        public int Capaciteit { get; }
        public int AantalBezettePlaatsen { get; set; } = 0;
        public int AantalLaptops { get; }
        public int AantalLaptopsGereserveerd { get; set; } = 0;

        public VrijeStudie(string lokaal, int capaciteit, int aantalLaptops)
        {
            Lokaal = lokaal;
            Capaciteit = capaciteit;
            AantalLaptops = aantalLaptops;
        }

        public void Inschrijven(int _aantalMensen, int _aantalLaptops)
        {
            if (_aantalMensen+AantalBezettePlaatsen > Capaciteit || _aantalLaptops+AantalLaptopsGereserveerd > AantalLaptops)
            {
                throw new Exception("Geen plaats meer of er zijn niet genoeg laptops");
            }
            else
            {
                AantalBezettePlaatsen += _aantalMensen;
                AantalLaptopsGereserveerd += _aantalLaptops;
            }
        }
    }
}
