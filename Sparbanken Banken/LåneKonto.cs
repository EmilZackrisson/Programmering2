using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal class LåneKonto : BankKonto
    {
        private double kreditgräns;

        public LåneKonto(string personNummer, double behållning, double räntesats) : base(personNummer, behållning, räntesats)
        {
        }

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

        public double BeräknaRänta()
        {
            behållning = behållning * (kreditgräns / 100);
            return behållning;
        }
    }
}
