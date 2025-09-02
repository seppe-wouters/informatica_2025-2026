using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    internal class Product
    {
        public string Naam { get; set; }
        public int Prijs { get; set; }
        public string Beschrijving { get; set; }

        public Product( string naamin, int prijsin, string beschrijvingin)
        {
            Naam = naamin;
            Prijs = prijsin;
            Beschrijving = beschrijvingin;
        }


    }
}
