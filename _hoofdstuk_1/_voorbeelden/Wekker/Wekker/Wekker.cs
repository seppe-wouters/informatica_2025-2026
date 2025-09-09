using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wekker
{
    public class Wekker
    {
        private int uur;
        private int minuut;

        public Wekker()
        {
            uur = 0;
            minuut = 0;
        }

        public int GetUur()
        {
            return uur;
        }

        public int GetMinuut()
        {
            return minuut;
        }

        public void SetUur(int uur)
        {
            this.uur = uur;
        }

        public void SetMinuut(int minuut)
        {
            this.minuut = minuut;
        }

        public void UrenPlus()
        {
            uur++;
            if (uur > 23)
            {
                uur = uur - 24;
            }
        }

        public void UrenMin()
        {
            uur--;
            if (uur < 0)
            {
                uur = uur + 24;
            }
        }

        public void MinutenPlus()
        {
            minuut++;
            if (minuut > 59)
            {
                minuut = minuut - 60;
            }
        }

        public void MinutenMin()
        {
            minuut--;
            if (minuut < 0)
            {
                minuut = minuut + 60;
            }
        }

        public String AlarmOm()
        {
            String minuutString;
            String uurString;

            minuutString = DisplayTweeCijfers(minuut);
            uurString = DisplayTweeCijfers(uur);

            return uurString + ":" + minuutString;
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

    }
}
