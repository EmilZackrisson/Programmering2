using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister_Övning2._2
{
    internal class Anställd
    {
        private string namn;
        public Anställd(string namn)
        {
            this.namn = namn;

        }



        public virtual double BeräknaLön()
        {
            return 0;
        }

        public override string ToString()
        {
            return namn;
        }

    }
}
