using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_1._7_Felsäkra_dina_program
{
    internal class Konto
    {
        string epost;
        string lösenord;

        public class LösenFormatExeption : Exception
        {
            string message = "Lösenordet måste innehålla både bokstäver och siffror";
            public override string ToString()
            {
                return message;
            }
        }

        public class EpostFormatExeption : Exception
        {
            string message = "Epost är inte i rätt format (kalle.anka@hej.se)";
            public override string ToString()
            {
                return message;
            }
        }

        public Konto(string epost, string lösenord)
        {
            int antalSiffror = 0;
            for (int i = 0; i < lösenord.Length; i++)
            {
                if (char.IsDigit(lösenord[i]))
                {
                    antalSiffror++;
                }
            }

            if (0 < antalSiffror && antalSiffror < lösenord.Length)
            {

                this.lösenord = lösenord;
            }
            else throw new LösenFormatExeption();

            if (epost.Contains("@"))
            {
                if (epost.Contains("."))
                {
                    this.epost = epost;
                }
            }
            else throw new EpostFormatExeption();
        }
    }
}
