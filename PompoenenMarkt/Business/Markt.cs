using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Markt
    {
        public List<Pompoen> Catalogus { get; set; }
        public List<Pompoen> Gefiltererd { get; set; }
        public Markt()
        {
            Catalogus = new List<Pompoen>();
            Gefiltererd = new List<Pompoen>();
        }

        public void VoegToe(Pompoen pompoen)
        {
            Catalogus.Add(pompoen);
        }

        public List<Pompoen> FilterOpSoort(string Soort)
        {
            Gefiltererd = Catalogus.Where(p => p.Soort == Soort).ToList();
            return Gefiltererd;
        }
        public void GeenFilter()
        {
            Gefiltererd = Catalogus;
        }
    }
}
