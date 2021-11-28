using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    class Czlowiek
    {
        public string Imie;
        public string Nazwisko;
        public int Wiek;

        public void Krzycz()
        {
            Console.WriteLine("aaaaaaaaaaa!!!!");
        }

        public string Krzycz2()
        {
            return "aaaaaaaaaa!!!!";
        }

        public string PrzedstawSie()
        {
            return "Nazywam sie " + Imie;
        }

    }
}
