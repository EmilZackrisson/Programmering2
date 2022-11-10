using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heltal
{
    internal class Password
    {
        public Password(string lösenord)
        {
            int antalTecken = lösenord.Length;
            if (antalTecken >= 8)
            {
                MessageBox.Show("Ditt lösenord är skapat");
            }
            else
            {
                throw new CheckMyPasswordExeption();
            }
        }
    }
}
