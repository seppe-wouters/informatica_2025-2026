using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public enum Genres { Rock, Grunge, Metal, Alternative}
    public class Band
    {
        //props
        public int ID { get; set; }
        public string Naam { get; set; }
        public Genres Genre { get; set; }
        public string Land { get; set; }
        public int Populariteit { get; set; }

        //standaard constructor
        public Band() { }
        //ingevulde constructor
        public Band(string naam, Genres genre, string land, int populariteit)
        {
            Naam = naam;
            Genre = genre;
            Land = land;
            Populariteit = populariteit;
        }

        //tostring override
        public override string ToString()
        {
            return $"{Naam} - {Genre} - {Land} - {Populariteit}";
        }
    }
}
