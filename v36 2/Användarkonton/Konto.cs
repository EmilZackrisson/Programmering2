using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Användarkonton
{
    internal class Konto
    {
        private string namn;
        private string lösenord;

        public Konto(string namn, string lösenord)
        {
            this.namn = namn;
            this.lösenord = lösenord;
        }

        public string Namn
        {
            get { return namn; }
        }

        public string Lösenord
        {
            get { return lösenord; }
        }

        public static bool GodkännLösenord(string lösenord)
        {
            if (lösenord.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return namn;
        }
    }
}
