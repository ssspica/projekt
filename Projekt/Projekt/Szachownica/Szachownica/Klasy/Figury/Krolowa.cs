using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Szachownica.Klasy;

namespace Szachownica.Klasy.Figury
{
    class Krolowa : Figura
    {
        public Krolowa(string kolor)
            : base(kolor)
        {
            nazwa = "Królowa";
            switch (kolor)
            {
                case kolorbialy:
                    pozycja = new Pozycja("D1");
                    break;
                case kolorczarny:
                    pozycja = new Pozycja("D8");
                    break;
            }
        }
        public override bool RuchMozliwy(Pozycja nadajPozycje)
        {
            int aktA = pozycja.A;
            int aktB = pozycja.B;
            List<Pozycja> mozliwaPozycja = new List<Pozycja>();
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktB + 1));
            mozliwaPozycja.Add(new Pozycja(aktA + 2, aktB + 2));
            mozliwaPozycja.Add(new Pozycja(aktA + 3, aktB + 3));
            mozliwaPozycja.Add(new Pozycja(aktA + 4, aktB + 4));
            mozliwaPozycja.Add(new Pozycja(aktA + 5, aktB + 5));
            mozliwaPozycja.Add(new Pozycja(aktA + 6, aktB + 6));
            mozliwaPozycja.Add(new Pozycja(aktA + 7, aktB + 7));
            mozliwaPozycja.Add(new Pozycja(aktA + 8, aktB + 8));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktB + 1));
            mozliwaPozycja.Add(new Pozycja(aktA - 2, aktB + 2));
            mozliwaPozycja.Add(new Pozycja(aktA - 3, aktB + 3));
            mozliwaPozycja.Add(new Pozycja(aktA - 4, aktB + 4));
            mozliwaPozycja.Add(new Pozycja(aktA - 5, aktB + 5));
            mozliwaPozycja.Add(new Pozycja(aktA - 6, aktB + 6));
            mozliwaPozycja.Add(new Pozycja(aktA - 7, aktB + 7));
            mozliwaPozycja.Add(new Pozycja(aktA - 8, aktB + 8));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktB - 1));
            mozliwaPozycja.Add(new Pozycja(aktA - 2, aktB - 2));
            mozliwaPozycja.Add(new Pozycja(aktA - 3, aktB - 3));
            mozliwaPozycja.Add(new Pozycja(aktA - 4, aktB - 4));
            mozliwaPozycja.Add(new Pozycja(aktA - 5, aktB - 5));
            mozliwaPozycja.Add(new Pozycja(aktA - 6, aktB - 6));
            mozliwaPozycja.Add(new Pozycja(aktA - 7, aktB - 7));
            mozliwaPozycja.Add(new Pozycja(aktA - 8, aktB - 8));
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktB - 1));
            mozliwaPozycja.Add(new Pozycja(aktA + 2, aktB - 2));
            mozliwaPozycja.Add(new Pozycja(aktA + 3, aktB - 3));
            mozliwaPozycja.Add(new Pozycja(aktA + 4, aktB - 4));
            mozliwaPozycja.Add(new Pozycja(aktA + 5, aktB - 5));
            mozliwaPozycja.Add(new Pozycja(aktA + 6, aktB - 6));
            mozliwaPozycja.Add(new Pozycja(aktA + 7, aktB - 7));
            mozliwaPozycja.Add(new Pozycja(aktA + 8, aktB - 8));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 1));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 2));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 3));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 4));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 5));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 6));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 7));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB - 8));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 1));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 2));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 3));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 4));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 5));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 6));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 7));
            mozliwaPozycja.Add(new Pozycja(aktA, aktB + 8));
            mozliwaPozycja.Add(new Pozycja(aktA + 1, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 2, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 3, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 4, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 5, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 6, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 7, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA + 8, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 1, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 2, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 3, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 4, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 5, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 6, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 7, aktB));
            mozliwaPozycja.Add(new Pozycja(aktA - 8, aktB));
            foreach (Pozycja poz in mozliwaPozycja)
            {
                Console.WriteLine(poz);
                if (base.RuchMozliwy(poz) && poz.Pole == nadajPozycje.Pole)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
