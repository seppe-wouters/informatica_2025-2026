using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Reis
    {
        private string _land;
        private int _aantalDagen;
        private decimal _kostprijs;

        public Reis(string land, int aantalDagen, decimal kostprijs)
        {
            _land = land;
            _aantalDagen = aantalDagen;
            _kostprijs = kostprijs;
        }

        public string Land
        {
            get { return _land; }
            set { _land = value; }
        }
        public int AantalDagen   
        {
            get { return _aantalDagen; }
            set { _aantalDagen = value; }
        }
        public decimal Kostprijs
        {
            get { return _kostprijs; }
            set { _kostprijs = value; }
        }

        public string Omschijving()
        {
            return $"{AantalDagen.ToString()} dag/dagen naar {Land} voor {Kostprijs.ToString("C")}";
        }
    }
}
