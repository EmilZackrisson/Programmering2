using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klass
{
    internal class Jämnt_tal
    {
        private int tal;

        public Jämnt_tal()
        {
            this.tal = 0;
        }

        public Jämnt_tal(Jämnt_tal copyMe)
        {
            this.tal = copyMe.tal;
        }

        // Property
        public int Tal
        {
            get { return tal; }
            set
            {
                if (value % 2 == 0)
                {
                    tal = value;
                }
            }
        }

        // metod
        public void Öka()
        {
            tal += 2;
        }

        public override string ToString()
        {
            return "Värde: " + tal.ToString();
        }

        public static bool ÄrJämnt(int tal)
        {
            if (tal % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
