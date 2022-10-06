using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oförberättprov_Klasser
{

    internal class Planet
    {
        private string namn;
        private int volym;
        private double radie;
        private bool beboelig;

        public Planet(string namn, int volym, double radie, bool beboelig)
        {
            this.namn = namn;
            this.volym = volym;
            this.radie = radie;
            this.beboelig = beboelig;
        }

        public string Namn
        {
            get { return namn; }
        }

        public int Volym
        {
            get { return volym; }
        }

        public double Radie
        {
            get { return radie; }
        }

        public bool Beboelig
        {
            get { return beboelig; }
        }

        public override string ToString()
        {
            return "Namn: " + namn + " Vol: " + volym + " Radie: " + radie + " Beboelig: " + beboelig;
        }
    }
}
