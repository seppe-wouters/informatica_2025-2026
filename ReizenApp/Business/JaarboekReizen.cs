using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business
{
    public class JaarboekReizen
    {
        private int _jaar;
        private List<Reis> _reizen;

        public JaarboekReizen(int jaar)
        {
            _jaar = jaar;
            _reizen = new List<Reis>();
        }

        public int Jaar
        {
            get { return _jaar; }
        }
        public List<Reis> Reizen
        {
            get { return _reizen; }
        }

        public void VoegReisToe(Reis reis)
        {
            _reizen.Add(reis);
        }

        public int GeefAantalReizen()
        {
            return _reizen.Count;
        }

        public Reis GeefReis(int nr)
        {
            if (nr >= 0 && nr < _reizen.Count)
            {
                return _reizen[nr];
            }
            else return null;
        }

        public decimal TotaleKostprijs()
        {
            decimal totaal = 0;
            foreach (Reis reis in _reizen)
            {
                totaal += reis.Kostprijs;
            }

            return totaal;
        }

        public void VerwijderOpNummer(int nr)
        {
            if (nr >= 0 && nr < _reizen.Count)
            {
                _reizen.RemoveAt(nr);
            }
        } 

        public void VerwijderOpReis(Reis reis)
        {
            _reizen.Remove(reis);
        }

        public void WisReizenLand(string land)
        {
            for (int i = _reizen.Count -1; i >= 0; i--)
            {
                if (_reizen[i].Land == land)
                {
                    _reizen.RemoveAt(i);
                }
            }
        }
    }
}
