using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    class Kalkulator
    {
        // kod deklaratywny 

        //1) Pola -- cechy (właściwości) obiektu 
        //2) Właściwości -- to samo co pole (są pewne drobne różnice) 
        //3) Konstruktory -- określają  jaki sposób tworzymy dany obiekt 
        //4) Metody -- określają co dany obiekt może zrobić (umiejętności)

        public string Kolor;



        public int Dodaj(int a , int b)
        {
            // tutaj (czyli w metodzie) mamy kod wykonawczym
            int c = a + b;
          //  return "5";
            return c;
        }

        public int Odejmij(int a, int b)
        {
            return a - b;
        }

    }
}
