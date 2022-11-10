using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister_Övning2._2
{
    internal class Kontorist : Anställd
    {
        private double månadslön;
        public Kontorist(string namn, double månadslön) : base(namn)
        {
            this.månadslön = månadslön;
        }

        public override double BeräknaLön()
        {
            return månadslön;
        }

        public override string ToString()
        {
            return base.ToString() + "Lön: " + this.månadslön;
        }
    }
}
