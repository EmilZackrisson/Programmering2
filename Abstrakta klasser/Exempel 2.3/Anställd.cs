using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_2._3
{
    internal abstract class Anställd
    {
        string namn = "";
        public Anställd(string n)
        {
            n = namn;
        }

        public abstract double BeräknaLön();
        
    }
}
