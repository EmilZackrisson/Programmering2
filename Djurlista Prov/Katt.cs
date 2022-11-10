using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurlista_Prov
{
    internal class Katt : Djur
    {
        private int ålder;
        private bool opererad;
        public Katt(string Namn, int Ålder, bool Opererad) : base(Namn)
        {
            this.ålder = Ålder;
            this.opererad = Opererad;
        }

        public override int Ålder { get { return ålder; } }
        public override bool Opererad { get { return opererad; } }


        public override string ToString()
        {
            return Namn + " Ålder: " + Ålder + " Opererad: " + Opererad;
        }
    }
}
