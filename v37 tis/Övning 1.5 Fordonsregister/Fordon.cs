using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Övning_1._5_Fordonsregister
{
    internal class Fordon
    {
        private string regNr, märke, modell, typ;
        enum FordonsTyp { Bil, MC };



        public string RegNr
        {
            get { return regNr; }
            set
            {
                regNr = value;
            }
        }



        public string Märke
        {
            get { return märke; }
            set
            {
                märke = value;
            }
        }

        public string Modell
        {
            get { return modell; }
            set
            {
                modell = value;
            }
        }

        public string Typ
        {
            get { return typ; }
            set
            {
                typ = value;

            }
        }

        /*public string FordonsTyp()
        {
            if(this.FordonsTyp == 0){
            return "Bil";
        }
        }*/


        public static bool GodkännRegNr(string regNr)
        {
            if (regNr.Length != 6)
            {
                return false;
            }

            string förstaTre = regNr.Substring(0, 3);
            string sistaTre = regNr.Substring(3, 3);

            bool förstaTreStämmer = false;
            bool sistaTreStämmer = false;

            if (förstaTre.Any(char.IsDigit)) // Kolla om första tre inte har siffror
            {
                return false;
            }

            // Kolla om första tre innehåller å/ä/ö
            if (förstaTre.ToUpper().Contains("Å") || förstaTre.ToUpper().Contains("Ä") || förstaTre.ToUpper().Contains("Ö"))
            {
                return false;
            }

            förstaTreStämmer = true;

            if (sistaTre.All(char.IsDigit)) // Kolla om sista tre är siffror
            {
                sistaTreStämmer = true;
                return true;
            }
            else
            {
                return false;
            }

        }

        public override string ToString()
        {
            return Märke + " " + Modell + " " + RegNr.ToUpper() + " " + Typ;
        }
    }
}
