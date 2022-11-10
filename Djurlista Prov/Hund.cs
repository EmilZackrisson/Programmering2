using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurlista_Prov
{
    internal class Hund : Djur
    {
        private string ras;
        private string id;
        public Hund(string Namn, string ras, string id) : base(Namn)
        {
            this.ras = ras;
            this.id = id;
        }

        public override string Ras { get { return ras; } }
        public override string Id { get { return id; } }

        public override string ToString()
        {
            return Namn + " Ras: " + Ras + " ID: " + Id;
        }

        public string Data()
        {
            return Namn + ";" + Ras +";"+Id;
        }
    }
}
