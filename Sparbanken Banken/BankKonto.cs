using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal abstract class BankKonto : Bank
    {
        protected string personNummer;
        protected double behållning;
        protected double räntesats;

        public double Behållning;

        protected BankKonto(string personNummer, double behållning, double räntesats)
        {
            this.personNummer = personNummer;
            this.Behållning = behållning;
            this.räntesats = räntesats;
        }

        public void Insättning (double belopp)
        {

        }

        public abstract bool Uttag(double belopp);

        public double BeräknaRänta()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
