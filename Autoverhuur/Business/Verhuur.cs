using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Verhuur
    {
        public List<Auto> Gehuurd { get; set; }
        public List<Auto> Beschikbaar { get; set; }

        public Verhuur()
        {
            Gehuurd = new List<Auto>();
            Beschikbaar = new List<Auto>();
        }

        public void HuurAuto(Auto auto)
        {
            if (auto.IsBeschikbaar)
            {
                auto.IsBeschikbaar = false;
                Gehuurd.Add(auto);
            }
            else
            {
                throw new InvalidOperationException("Deze auto is niet beschikbaar voor verhuur.");
            }
        }

        public void BrengTerug(Auto auto)
        {
            if (Gehuurd.Contains(auto))
            {
                auto.IsBeschikbaar = true;
                Gehuurd.Remove(auto);
            }
            else
            {
                throw new InvalidOperationException("Deze auto is niet gehuurd via dit verhuurbedrijf.");
            }
        }
    }
}
