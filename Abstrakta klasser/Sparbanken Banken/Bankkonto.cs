using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal abstract class Bankkonto
    {
        protected string personNummer;
        protected double räntesats;
        protected double behållning;

        public double Behållning;

        public Bankkonto(string personNummer, double räntesats)
        {
            this.personNummer = personNummer;
            this.Behållning = behållning;
            this.räntesats = räntesats;

            behållning = Behållning;
        }


        public void Insättning(double belopp)
        {
            Behållning = Behållning + belopp;
        }

        public abstract bool Uttag(double belopp);

        public abstract double BeräknaRänta();

        public override string ToString()
        {
            return personNummer + ": " + Behållning;
        }
    }
}
