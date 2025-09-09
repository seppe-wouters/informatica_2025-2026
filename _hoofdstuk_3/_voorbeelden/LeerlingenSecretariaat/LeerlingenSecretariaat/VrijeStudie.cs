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

        public VrijeStudie(string lokaal, int capaciteit)
        {
            Lokaal = lokaal;
            Capaciteit = capaciteit;
        }

        public void Inschrijven(int _aantal)
        {
            if (_aantal+AantalBezettePlaatsen > Capaciteit)
            {
                throw new Exception("Geen plaats meer");
            }
            else
            {
                AantalBezettePlaatsen += _aantal;
            }
        }
    }
}
