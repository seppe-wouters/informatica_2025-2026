using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class AlleBands
    {
        //list prop 
        public List<Band> Bands { get; set; }

        //list init
        public AlleBands()
        {
            Bands = new List<Band>();
        }

        //voeg toe methode
        public void VoegToe(Band b)
        {
            Bands.Add(b);
        }
    }
}
