using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heltal
{
    internal class CheckMyPasswordExeption : Exception
    {
        string medelande = "Inte giltigt lösenord";

        public override string ToString()
        {
            return medelande;
        }
    }
}
