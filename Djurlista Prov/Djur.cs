using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurlista_Prov
{
    internal class Djur
    {
        public string Namn;

        public Djur(string namn)
        {
            Namn = namn;
        }

        public virtual int Ålder { get; internal set; }

        public virtual bool Opererad { get; internal set; }

        public virtual string Ras { get; internal set; }

        public virtual string Id { get; internal set; }
    }
}
