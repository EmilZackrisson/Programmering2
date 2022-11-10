using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister_Övning2._2
{
    internal class Säljare : Anställd
    {
        private double provision;
        private double försäljning;
        public Säljare(string namn, double provision, double försäljning) : base(namn)
        {
            this.provision = provision;
            this.försäljning = försäljning;
        }

        public override double BeräknaLön()
        {
            double lön = försäljning * (provision / 100);
            return lön;
        }

        public override string ToString()
        {
            return base.ToString() + " (Säljare)";
        }
    }
}
