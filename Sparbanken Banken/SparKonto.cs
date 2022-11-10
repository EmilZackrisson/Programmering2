using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal class SparKonto : BankKonto
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

        public SparKonto(string personNummer, double beheållning, double räntesats) : base(personNummer, beheållning, räntesats)
        {
            
        }

        public double BeräknaRänta()
        {
            return 0;
        }

        public override string ToString()
        {
            return "Sparkonto " + personNummer + ", " + behållning + " kr," + räntesats + "%";
        }
    }
}
