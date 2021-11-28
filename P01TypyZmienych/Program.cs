using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01TypyZmienych
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            char b = 'x';
            string c = "napis";
            double d = 6.45;

            string e = "28-11-2021";

            DateTime dt = new DateTime(2021, 11, 28);

            StringBuilder sb = new StringBuilder();
            sb.Append("ala");
            sb.Append(" ma ");
            sb.Append("kota");

            string s = sb.ToString();
            string s2 = "ala ma kota";
            string s3 = "ala" + " ma " + "kota";

            WebClient wc = new WebClient();

        }
    }
}
