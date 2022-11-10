using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparbanken_Banken
{
    internal class Bank
    {
        public List<BankKonto> konton = new List<BankKonto>();
        public double Behållning = 0;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
