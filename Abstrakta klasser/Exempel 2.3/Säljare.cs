using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_2._3
{
    internal class Säljare : Anställd
    {
        double försäljning = 0;
        double provision = 0;

        public Säljare(string namn, double f, double p) : base(namn)
        {
            försäljning = f;
            provision = p;

        }

        public override double BeräknaLön()
        {
            double lön = försäljning * provision / 100;
            return lön;
        }
    }
}
