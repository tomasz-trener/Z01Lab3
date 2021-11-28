using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ZadanieKalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            KalkulatorDodajacy kd = new KalkulatorDodajacy();
            int wynik = kd.Dodaj(4, 5);

            KalkulatorUniwersalny ku = new KalkulatorUniwersalny();
            ku.operacja = '+';
            int wynik2 = ku.WykonajOperacje(4,5);
        }
    }
}
