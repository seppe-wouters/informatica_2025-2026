using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Reservering
    {
        public string Naam { get; private set; }
        public DateTime Tijdslot { get; private set; }
        public int AantalPersonen { get; private set; }

        public Reservering(string naam, DateTime tijdslot, int aantalPersonen)
        {
            Naam = naam;
            Tijdslot = tijdslot;
            AantalPersonen = aantalPersonen;
        }

        public override string ToString()
        {
            return $"{Naam} - {Tijdslot.Day}/{Tijdslot.Month} - {AantalPersonen}";
        }
    }
}
