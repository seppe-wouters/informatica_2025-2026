using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolbib
{
    internal class Boek : IComparable<Boek>
    {
        public string Titel { get; set; }
        public string Auteur { get; set; }
        public int Jaar { get; set; }

        public Boek(string titelin, string auteurin, int jaarin)
        {
            Titel = titelin;
            Auteur = auteurin;
            Jaar = jaarin;
        }

        public int CompareTo(Boek other)
        {
            return this.Titel.CompareTo(other.Titel);
        }
    }
}
