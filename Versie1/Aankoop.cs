using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Versie1
{
    class Aankoop
    {
        private double dblPrijs;
        private int intIdAankoop, intAantal;

        public int idAankoop
        {
            get { return intIdAankoop; }
            set { intIdAankoop = value; }
        }
        public double prijs
        {
            get { return dblPrijs; }
            set { dblPrijs = value; }
        }
        public int aantal
        {
            get { return intAantal; }
            set { intAantal = value; }
        }

        public Aankoop(int pintIdAankoop, double pdblPrijs, int pintAantal)
        {
            intIdAankoop = pintIdAankoop;
            dblPrijs = pdblPrijs;
            intAantal = pintAantal;
        }


    }
}
