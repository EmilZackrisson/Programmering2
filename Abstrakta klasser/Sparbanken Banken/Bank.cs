using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal class Bank
    {
        public double Behållning = 0;

        public List<Bankkonto> konton = new List<Bankkonto>();

        public override string ToString()
        {
            return "hej";
        }
    }
}
