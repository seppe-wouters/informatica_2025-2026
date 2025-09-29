using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Business
{
    public class PartnerTepee
    {
        //velden
        private bool _airco;
        private bool _autoRadio;

        //read-only props
        public bool Airco
        {
            get { return _airco; }
            set { _airco = value; }
        }

        public bool AutoRadio
        {
            get { return _autoRadio; }
            set { _autoRadio = value; }
        }

        //constructor
        public PartnerTepee(bool airco, bool autoRadio)
        {
            _airco = airco;
            _autoRadio = autoRadio;
        }

        //geefPrijs methode
        public int GeefPrijs()
        {
            int prijs = 13904;
            if (_airco) prijs += 1500;
            if (_autoRadio) prijs += 750;
            return prijs;
        }


    }
}
