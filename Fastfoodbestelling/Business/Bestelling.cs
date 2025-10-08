using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Bestelling
    {
        public List<MenuItem> Items { get; set; }

        public Bestelling()
        {
            Items = new List<MenuItem>();
        }

        public decimal TotaalPrijs()
        {
            return Items.Sum(item => item.Prijs);
        }

        public void voegtoeItemToe(MenuItem item)
        {
            Items.Add(item);
        }

        public void verwijderItem(MenuItem item)
        {
            Items.Remove(item);
        }
    }
}
