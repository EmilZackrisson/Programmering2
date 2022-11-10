using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister_Övning2._2
{
    internal class Konsult : Anställd
    {
        private double arbetateTimmar;
        private double timLön;

        public Konsult(string namn, double arbetadTid, double timLön) : base(namn)
        {
            this.arbetateTimmar = arbetadTid;
            this.timLön = timLön;
        }
        public override double BeräknaLön()
        {
            double lön = arbetateTimmar * timLön;
            return lön;
        }

        public override string ToString()
        {
            return base.ToString() + " (Konsult)";
        }
    }
}
