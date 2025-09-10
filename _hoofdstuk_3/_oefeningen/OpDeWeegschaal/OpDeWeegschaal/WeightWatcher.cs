using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpDeWeegschaal
{
    public class WeightWatcher
    {
        public int Gewicht { get; }
        public double Lengte { get; }

        public WeightWatcher(int gewicht, double lengte)
        {
            Gewicht = gewicht;
            Lengte = lengte;
        }

        public double BerekenBMI()
        {
            return Gewicht / Math.Pow(Lengte, 2);
        }

        public string GeefStatus()
        {
            double bmi = BerekenBMI();

            if (bmi > 0 && bmi < 20) return "ondergewicht";
            else if (bmi >= 20 && bmi < 25) return "ok";
            else if (bmi >= 25 && bmi < 30) return "overgewicht";
            else if (bmi < 30) return "obees";
            else return "fout";
        }
    }
}
