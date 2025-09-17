using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace Wielertenue
{
    class BestellingWielertenue
    {
        public int _aantal { get; set; }  // hoeveel stuks bestel je
        public bool _waterdichtZakje { get; set; } // is er in het truitje een waterdicht GSM-opbergzakje voorzien
        public bool _broek { get; set; }  // neem je ook de wielerbroek (of anders enkel het wielertruitje)
        public bool _superZeem { get; set; } // is de wielerbroek voorzien van een zeem met hogere kwaliteit

        public BestellingWielertenue(int aantal, bool waterdichtZakje, bool broek, bool superZeem)
        {
            _aantal = aantal;
            _waterdichtZakje = waterdichtZakje;
            _broek = broek;
            _superZeem = superZeem;
        }

        public double berekenPrijs()
        {
            double totprijs = 45;
            if (_waterdichtZakje) totprijs += 3.50;
            if (_broek) totprijs += 35;
            if (_superZeem) totprijs += 5.50;

            return Math.Round(totprijs * Convert.ToDouble(_aantal), 2);
        }
    }
}
