using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Business
{
    public class SpookHuis
    {
        public List<Reservering> Wachtrij { get; private set; }
        public int AantalVerwerkt { get; private set; }

        public SpookHuis()
        {
            Wachtrij = new List<Reservering>();
        }

        public void VoegReserveringToe(Reservering res)
        {
            Wachtrij.Add(res);
        }

        public void VerwerkEerste()
        {
            AantalVerwerkt += Wachtrij[0].AantalPersonen;
            Wachtrij.RemoveAt(0);
        }

        public void VerwerkMetVoorang(Reservering res)
        {
            AantalVerwerkt += res.AantalPersonen;
            Wachtrij.Remove(res);
        }
    }
}
