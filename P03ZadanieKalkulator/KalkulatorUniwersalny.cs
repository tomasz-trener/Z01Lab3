using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKalkulator
{
    class KalkulatorUniwersalny
    {
        public char operacja;
        public int WykonajOperacje(int a, int b)
        {
            if (operacja=='+')
            {
                KalkulatorDodajacy kd = new KalkulatorDodajacy();
                return kd.Dodaj(a, b) ;
            }
            if (operacja == '-')
            {
                KalkulatorOdejmujacy ko = new KalkulatorOdejmujacy();
                return ko.Odejmij(a,b);
            }

            throw new Exception("Nieobslugiwana operacja");
            //return 0;
        }
    }
}
