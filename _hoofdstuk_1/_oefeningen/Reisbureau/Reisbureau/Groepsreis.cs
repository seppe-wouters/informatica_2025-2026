using System;

namespace Reisbureau
{
    public class Groepsreis
    {
        private string _bestemming;
        private int _maxDeelnemers;
        private int _inschrijvingen;
        private double _prijsPerPersoon;
        private bool _kinderenToegelaten;
        private char _klasseVerblijf;

        public Groepsreis(string bestemming, int maxDeelnermers, double prijsPerPersoon)
        {
            _bestemming = bestemming;
            _maxDeelnemers = maxDeelnermers;
            _prijsPerPersoon = prijsPerPersoon;
            _kinderenToegelaten = true;
            _klasseVerblijf = 'B';
            _inschrijvingen = 1;
        }
        //methoden
        public void SchrijfVolwassenenIn()
        {
            if (_inschrijvingen < _maxDeelnemers)
            {
                _inschrijvingen++;
            }
            else
            {
                Console.WriteLine("kan niet meer inschrijven");
            }

        }

        public void SchrijfKindIn()
        {
            if (_kinderenToegelaten)
            {
                if (_inschrijvingen < _maxDeelnemers)
                {
                    _inschrijvingen++;
                }
                else
                {
                    Console.WriteLine("kan niet meer inschrijven");
                }
            }
            else
            {
                Console.WriteLine("kinderen niet toegelaten");
            }
        }
        
    }
}
