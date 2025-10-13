using Presentatie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Kledingwinkel 
    {
        private List<Kledingstuk> _stukken;
        private List<Kledingstuk> _gefiltert;
        public List<Kledingstuk> Gefiltert
        {
            get { return _gefiltert; }
        }

        public Kledingwinkel()
        {
            _stukken = new List<Kledingstuk>();
            _gefiltert = new List<Kledingstuk>();
        }

        public void FilterOpCategorie(string categorie)
        {
            
            _gefiltert = _stukken;
            for (int i = _stukken.Count; i >= 0; i--)
            {
                if (categorie == "Broek") _gefiltert.RemoveAt(i);
                else if (categorie == "Tshirt") _gefiltert.RemoveAt(i);
                else if (categorie == "Trui") _gefiltert.RemoveAt(i);
            }
        }

        public void SorteerOpNaam()
        {
            _gefiltert.Sort();
            _stukken.Sort();
        }
        public void SorteerOpPrijs()
        {
            _gefiltert.Sort(new SorterenOpPrijs());
            _stukken.Sort(new SorterenOpPrijs());
        }
    }
}
