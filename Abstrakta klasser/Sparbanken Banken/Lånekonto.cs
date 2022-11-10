using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal class Lånekonto : Bankkonto
    {
        private double kreditGräns;


        public Lånekonto() : base(personNummer, räntesats)
        {
            
            this.kreditGräns = kreditGräns;
            
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

        public override double BeräknaRänta()
        {
            throw new NotImplementedException();
        }
    }
}
