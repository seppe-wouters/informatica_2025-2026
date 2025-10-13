using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Kledingstuk : IComparable<Kledingstuk>
    {
        private string _naam;
        private string _categorie;
        private string _maat;
        private double _prijs;

        public Kledingstuk(string naam, string categorie, string maat, double prijs)
        {
            _naam = naam;
            _categorie = categorie;
            _maat = maat;
            _prijs = prijs;
        }

        public string Naam
        {
            get { return _naam; }
        }
        public string Categorie
        {
            get { return _categorie; }
        }
        public string Maat
        {
            get { return _maat; }
        }
        public double Prijs
        {
            get { return _prijs; }
        }

        public int CompareTo(Kledingstuk other)
        {
            return this.Naam.CompareTo(other.Naam);
        }

        public override string ToString()
        {
            return $"{Naam} - {Maat} - {Prijs} - {Categorie}";
        }
    }
}
