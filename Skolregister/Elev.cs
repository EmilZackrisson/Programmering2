using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skolregister
{
    internal class Elev
    {
        public string PersonNr { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }

        public Elev(string personNr, string förnamn, string efternamn)
        {
            if (personNr.Length > 10 || personNr.Length < 8)
            {
                MessageBox.Show("Personnummret stämmer inte.");
                return;
            }

            this.PersonNr = personNr;
            this.Förnamn = förnamn;
            this.Efternamn = efternamn;
        }
    }
}
