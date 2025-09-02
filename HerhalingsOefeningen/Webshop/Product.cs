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
        public double Prijs { get; set; }
        public string Beschrijving { get; set; }

        public Product( string naamin, double prijsin, string beschrijvingin)
        {
            Naam = naamin;
            Prijs = prijsin;
            Beschrijving = beschrijvingin;
        }


    }
}
