using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02WlasneKlasy
{
    class Program
    {
        static void Main(string[] args)
        {
            // kod wykonawczy
            int a = 54;
            StringBuilder sb = new StringBuilder();

            Kalkulator k = new Kalkulator();

            Kalkulator k2 = new Kalkulator();

            new Kalkulator();

            int b = k.Dodaj(3, 6);

            k.Kolor = "czerwony";

            k2.Kolor = "czarny";


            Czlowiek c1 = new Czlowiek();
            c1.Imie = "Jan";
            c1.Krzycz();

            Czlowiek c2 = new Czlowiek();
            c2.Imie = "Adam";
            c2.Krzycz();

            Czlowiek[] osoby = new Czlowiek[2];
            osoby[0] = c1;
            osoby[1] = c2;

            Console.WriteLine(c1.PrzedstawSie());
            Console.WriteLine(c2.PrzedstawSie());

           

        }
    }
}
