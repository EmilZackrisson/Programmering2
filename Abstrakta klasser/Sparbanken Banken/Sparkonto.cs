using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal class Sparkonto : Bankkonto
    {
        public override bool Uttag(double belopp)
        {
            if (belopp <= behållning)
            {
                behållning = behållning - belopp;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double BeräknaRänta()
        {
            double beloppEfterRänta = Behållning + behållning * (räntesats / 100);
            return beloppEfterRänta;
        }
    }
}
