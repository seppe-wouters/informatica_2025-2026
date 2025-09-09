using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aftelklok
{
    public class Aftelklok
    {
        private int _minuten;
        private int _secoden;

        public Aftelklok(int minuten, int seconden)
        {
            _minuten = minuten;
            _secoden = seconden;
        }

        public int GetMinuten()
        {
            return _minuten;
        }

        public int GetSeconde()
        {
            return _secoden;
        }

        public void SetMinuten(int minuten)
        {
            _minuten = minuten;
        }

        public void SetSeconden(int seconden)
        {
            _secoden = seconden;
        }

        public void TijdInstellen(int minuten, int seconden)
        {
            SetSeconden(seconden);
            SetMinuten(minuten);
        }

        public void Aftellen()
        {
            if (_minuten == 0 && _secoden == 0)
            {
                Console.WriteLine("de tijd is om");
            }
            else
            {
                if (_secoden == 0)
                {
                    _minuten--;
                    _secoden = 59;
                }
                else
                {
                    _secoden--;
                }
            }
        }

        private String DisplayTweeCijfers(int getal)
        {
            String displayString;

            if (getal < 10)
            {
                displayString = "0" + getal.ToString();
            }
            else
            {
                displayString = getal.ToString();
            }

            return displayString;
        }

        public String ResterendeTijd()
        { 
            return $"{DisplayTweeCijfers(_minuten)}:{DisplayTweeCijfers(_secoden)}";
        }

    }
}
